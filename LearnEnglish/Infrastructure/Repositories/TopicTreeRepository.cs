using LearnEnglish.Domain.Aggregate.TopicTrees;
using LearnEnglish.Domain.Aggregate.Vocabs;
using LearnEnglish.Domain.Repositories;
using LearnEnglish.Infrastructure.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace LearnEnglish.Infrastructure.Repositories
{
    public class TopicTreeRepository : BaseRepository, ITopicTreeRepository
    {
        public TopicTreeRepository()
        {

        }

        public List<TopicTree> getListFolderAndListByParentId(int? parentId)
        {
            using (var dbs = this.CreateContextFactory())
            {
                if (parentId == null)
                {
                    var list = dbs.TopicTrees
                        .Where(u => u.DeletedAt == null)
                        .Where(u => u.Path == "/")
                        .ToList();

                    var compareEngine = new NaturalStringComparer();
                    list.Sort((a, b) =>
                    {
                        return compareEngine.Compare(a.Name, b.Name);
                    });

                    return list;
                }
                else
                {
                    var dbParent = dbs.TopicTrees.FirstOrDefault(u => u.Id == parentId);
                    string childPath = $"{dbParent.Path}{dbParent.Id}/";

                    var list = dbs.TopicTrees
                        .Where(u => u.DeletedAt == null)
                        .Where(u => u.Path == childPath)
                        .ToList();

                    var compareEngine = new NaturalStringComparer();
                    list.Sort((a, b) =>
                    {
                        return compareEngine.Compare(a.Name, b.Name);
                    });

                    return list;
                }
            }
        }

        public TopicTree addFolder(TopicTree topicTree)
        {
            using (var dbs = this.CreateContextFactory())
            {
                dbs.TopicTrees.Add(topicTree);
                dbs.SaveChanges();
                return topicTree;
            }
        }

        public TopicTree addList(TopicTree topicTree)
        {
            using (var dbs = this.CreateContextFactory())
            {
                dbs.TopicTrees.Add(topicTree);
                dbs.SaveChanges();
                return topicTree;
            }
        }

        public TopicTree updateTopicName(TopicTree topicTree)
        {
            using (var dbs = this.CreateContextFactory())
            {
                var dbTopicTree = dbs.TopicTrees.FirstOrDefault(u => u.Id == topicTree.Id);
                dbTopicTree.updateTopicName(topicTree.Name);
                dbs.SaveChanges();
                return dbTopicTree;
            }
        }

        public int numberOfVocabByTopicId(int topicId)
        {
            using (var dbs = this.CreateContextFactory())
            {
                return dbs.Vocabs
                    .Where(u => u.DeletedAt == null)
                    .Where(u => u.TopicTreeId == topicId)
                    .Select(u => 1).ToList().Sum();
            }
        }

        public TopicTree deleteTopic(TopicTree topicTree)
        {
            using (var dbs = this.CreateContextFactory())
            {
                var dbTopicTree = dbs.TopicTrees.FirstOrDefault(u => u.Id == topicTree.Id);

                var queryListChildren = from topic in dbs.TopicTrees
                                        where topic.Path.StartsWith($"{dbTopicTree.Path}{dbTopicTree.Id}/")
                                        select topic;

                var queryListChildrenId = from topic in queryListChildren
                                          select topic.Id;

                var queryDeleteVocab = from vocab in dbs.Vocabs
                                       where queryListChildrenId.Contains(vocab.TopicTreeId) || vocab.TopicTreeId == topicTree.Id
                                       select vocab;

                foreach (var topic in queryListChildren)
                {
                    topic.deleteTopic();
                }

                foreach (var vocab in queryDeleteVocab)
                {
                    vocab.deleteVocab();
                }

                dbTopicTree.deleteTopic();

                dbs.SaveChanges();

                try
                {
                    dbs.Database.ExecuteSqlRaw("VACUUM");
                }
                catch { }

                return dbTopicTree;
            }
        }

        public TopicTree getTopicTreeById(int id)
        {
            using (var dbs = this.CreateContextFactory())
            {
                return dbs.TopicTrees.FirstOrDefault(u => u.Id == id);
            }
        }

        public void importTopic(string fileName, int? parentId)
        {
            using (var dbs = this.CreateContextFactory())
            {
                using (var transaction = dbs.Database.BeginTransaction())
                {
                    try
                    {
                        TopicTree root = new TopicTree() { Id = -1, Path = "/" };
                        if (parentId != null)
                        {
                            root = dbs.TopicTrees.FirstOrDefault(u => u.Id == parentId);
                        }

                        Dictionary<TopicTree, List<TopicTree>> mapping = new Dictionary<TopicTree, List<TopicTree>>();
                        mapping[root] = new List<TopicTree>();

                        Func<string, TopicTree> getRelativeNode = (path) =>
                        {
                            TopicTree u = root;
                            var tokens = path.Split("/").Where(u => u.Length > 0).ToList();
                            string currentPath = root.Path;
                            for (int i = 0; i < tokens.Count; ++i)
                            {
                                string token = tokens[i];
                                if (u.Id > 0)
                                    currentPath += u.Id + "/";
                                if (mapping[u].FirstOrDefault(u => u.Name == token) == null)
                                {
                                    TopicTree child = null;
                                    if (i < tokens.Count - 1)
                                    {
                                        child = TopicTree.createFolder(token, currentPath);
                                    }
                                    else
                                    {
                                        child = TopicTree.createList(token, currentPath);
                                    }
                                    dbs.TopicTrees.Add(child);
                                    dbs.SaveChanges();
                                    mapping[u].Add(child);
                                    mapping[child] = new List<TopicTree>();
                                }
                                u = mapping[u].First(u => u.Name == token);
                            }
                            return u;
                        };

                        Action<string, byte[]> processTopic = (relativePath, topicZip) =>
                        {
                            var topicTree = getRelativeNode(relativePath);
                            using (MemoryStream ms = new MemoryStream(topicZip))
                            {
                                using (BinaryReader reader = new BinaryReader(ms))
                                {
                                    int numberOfTopics = reader.ReadInt32();
                                    for (int i = 0; i < numberOfTopics; ++i)
                                    {
                                        string eng = reader.ReadString();
                                        string vie = reader.ReadString();
                                        int audioSize = reader.ReadInt32();
                                        byte[] audio = reader.ReadBytes(audioSize);
                                        var newVocab = Vocab.createVocab(eng, vie, audio, topicTree.Id);
                                        dbs.Vocabs.Add(newVocab);
                                    }
                                    reader.Dispose();
                                }
                                ms.Dispose();
                            }
                            dbs.SaveChanges();
                            topicZip = null;
                        };

                        using (BinaryReader reader = new BinaryReader(new FileStream(fileName, FileMode.Open)))
                        {
                            byte[] header = reader.ReadBytes(3);
                            if (header[0] != 'L' || header[1] != 'E' || header[2] != 'E')
                                throw new Exception("Định dạng file không hợp lệ");
                            int version = reader.ReadInt32();
                            if (version < 0x00000003)
                            {
                                throw new Exception("Phiên bản của file này quá cũ");
                            }
                            DateTimeOffset unixTimeExport = DateTimeOffset.FromUnixTimeSeconds(reader.ReadInt64());
                            int numberOfTopics = reader.ReadInt32();
                            for (int i = 0; i < numberOfTopics; ++i)
                            {
                                string topicName = reader.ReadString();
                                int sizeTopic = reader.ReadInt32();
                                byte[] topicZip = reader.ReadBytes(sizeTopic);
                                processTopic(topicName, topicZip);
                            }
                            reader.Dispose();
                        }

                        transaction.Commit();
                    }
                    catch (Exception e)
                    {
                        transaction.Rollback();
                        throw e;
                    }
                }
            }
        }

        public void exportTopic(string fileName, int? id)
        {
            Func<string, string> convertIdToNamePath = (path) =>
            {
                using (var dbs = this.CreateContextFactory())
                {
                    var paths = path.Split("/")
                        .Where(u => u.Length > 0)
                        .Select(u =>
                        {
                            int topicId = int.Parse(u);
                            return dbs.TopicTrees.FirstOrDefault(u => u.Id == topicId).Name;
                        })
                        .ToList()
                        .Where(u => !u.Contains("//"));
                    return string.Join("/", paths);
                }
            };

            Func<int, byte[]> zipTopic = (topicId) =>
            {
                MemoryStream ms = new MemoryStream();
                using (BinaryWriter writer = new BinaryWriter(ms))
                {
                    using (var dbs = this.CreateContextFactory())
                    {
                        var vocabs = dbs.Vocabs
                            .Where(u => u.DeletedAt == null)
                            .Where(u => u.TopicTreeId == topicId)
                            .ToList();
                        writer.Write(vocabs.Count);
                        foreach (var vocab in vocabs)
                        {
                            string eng = vocab.Eng;
                            string vie = vocab.Vie;
                            byte[] audio = vocab.Audio;
                            writer.Write(eng);
                            writer.Write(vie);
                            writer.Write(audio.Length);
                            writer.Write(audio);
                            audio = null;
                        }
                        writer.Dispose();
                    }
                    ms.Dispose();
                }
                return ms.ToArray();
            };

            using (MemoryStream ms = new MemoryStream())
            {
                using (BinaryWriter writer = new BinaryWriter(ms))
                {
                    writer.Write(new byte[] { (byte)'L', (byte)'E', (byte)'E' }); //HEADER
                    writer.Write(0x00000003); //VERSION
                    writer.Write(DateTimeOffset.Now.ToUnixTimeSeconds()); //DATE-TIME-EXPORT

                    using (var dbs = this.CreateContextFactory())
                    {
                        var dbRoot = dbs.TopicTrees.FirstOrDefault(u => u.Id == id);
                        string rootPath = "/";
                        if (dbRoot != null)
                        {
                            rootPath = $"{dbRoot.Path}{dbRoot.Id}/";
                        }
                        var listTopics = dbs.TopicTrees.Where(u => u.Path.StartsWith(rootPath) && u.NodeType == "LIST" && u.DeletedAt == null).ToList();
                        writer.Write(listTopics.Count);
                        foreach (var topic in listTopics)
                        {
                            var relativePath = $"{topic.Path}{topic.Id}";
                            relativePath = convertIdToNamePath(relativePath);
                            byte[] topicZipBuffered = zipTopic(topic.Id);
                            writer.Write(relativePath);
                            writer.Write(topicZipBuffered.Length);
                            writer.Write(topicZipBuffered);
                            topicZipBuffered = null;
                        }
                    }
                    writer.Dispose();
                }

                byte[] output = ms.ToArray();
                File.WriteAllBytes(fileName, output);

                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();

                ms.Dispose();
            }
        }

        public List<TopicTree> getListFolderByParentId(int? parentId)
        {
            using (var dbs = this.CreateContextFactory())
            {
                if (parentId == null)
                {
                    var list = dbs.TopicTrees
                        .Where(u => u.DeletedAt == null)
                        .Where(u => u.Path == "/" && u.NodeType == "FOLDER")
                        .ToList();

                    var compareEngine = new NaturalStringComparer();
                    list.Sort((a, b) =>
                    {
                        return compareEngine.Compare(a.Name, b.Name);
                    });

                    return list;
                }
                else
                {
                    var dbParent = dbs.TopicTrees.FirstOrDefault(u => u.Id == parentId);
                    string childPath = $"{dbParent.Path}{dbParent.Id}/";

                    var list = dbs.TopicTrees
                        .Where(u => u.DeletedAt == null)
                        .Where(u => u.Path == childPath && u.NodeType == "FOLDER")
                        .ToList();

                    var compareEngine = new NaturalStringComparer();
                    list.Sort((a, b) =>
                    {
                        return compareEngine.Compare(a.Name, b.Name);
                    });

                    return list;
                }
            }
        }

        public TopicTree changeTopicParentByParentId(TopicTree topicTree, int? newParentId)
        {
            using (var dbs = this.CreateContextFactory())
            {
                var dbParent = dbs.TopicTrees.FirstOrDefault(u => u.Id == newParentId);
                var newParentPath = $"{dbParent.Path}{dbParent.Id}/";

                var dbTopicTree = dbs.TopicTrees.FirstOrDefault(u => u.Id == topicTree.Id);

                string prefix = $"{dbTopicTree.Path}{dbTopicTree.Id}/";

                var listTopicChanges = from topic in dbs.TopicTrees
                                       where topic.Path.StartsWith(prefix)
                                       select topic;

                dbTopicTree.Path = newParentPath;

                foreach (var topic in listTopicChanges)
                {
                    topic.Path = $"{dbParent.Path}{dbParent.Id}/{dbTopicTree.Id}/" + topic.Path.Substring(prefix.Length);
                }

                dbs.SaveChanges();
                return topicTree;
            }
        }
    }
}
