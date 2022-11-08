using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LearnEnglish.Infrastructure.Setting
{
    public class ESettingBase
    {
        private Dictionary<string, byte[]> mem = new Dictionary<string, byte[]>();
        public ESettingBase()
        {

        }

        private byte[] encrypt(byte[] text)
        {
            byte[] output = new byte[text.Length];
            for (int i = 0, j = 0, k = 0; i < text.Length; ++i)
            {
                j += text.Length - 1;
                k *= text.Length - 1;
                k ^= j;
                j %= text.Length;
                k %= 57;
                output[i] = (byte)(text[i] ^ k);
            }
            return output;
        }

        private byte[] decrypt(byte[] cipherText)
        {
            return encrypt(cipherText);
        }

        protected byte[] getSettingValue(string key)
        {
            if (!mem.ContainsKey(key))
                throw new Exception("Không tồn tại key này trong cài đặt");
            return this.decrypt(mem[key]);
        }

        protected string getString(string key, string defaultIfNull = "")
        {
            if (!mem.ContainsKey(key))
            {
                this.setString(key, defaultIfNull);
            }
            return Encoding.UTF8.GetString(this.getSettingValue(key));
        }

        protected void setString(string key, string value)
        {
            this.addOrUpdateSettingValue(key, Encoding.UTF8.GetBytes(value));
        }

        protected void addOrUpdateSettingValue(string key, byte[] value)
        {
            if (value is null)
                throw new Exception("Giá trị cài đặt không được null");
            mem[key] = this.encrypt(value);
        }

        protected virtual void saveSettingToStream(Stream stream)
        {
            using (BinaryWriter writer = new BinaryWriter(stream))
            {
                writer.Write(new byte[] { (byte)'L', (byte)'E', (byte)'S' }); //header
                writer.Write(0x00000003); //version
                writer.Write(DateTimeOffset.Now.ToUnixTimeSeconds()); //saved time
                writer.Write(mem.Count);
                foreach (var keyValue in mem)
                {
                    string key = keyValue.Key;
                    byte[] value = keyValue.Value;
                    writer.Write(key);
                    writer.Write(value.Length);
                    writer.Write(value);
                }
            }
        }

        protected virtual void loadSettingFromStream(Stream stream)
        {
            using (BinaryReader reader = new BinaryReader(stream))
            {
                byte[] header = reader.ReadBytes(3);
                if (header[0] != 'L' || header[1] != 'E' || header[2] != 'S')
                    throw new Exception("Định dạng file không hợp lệ");
                int version = reader.ReadInt32();
                if (version < 0x0000003)
                    throw new Exception("Phiên bản cài đặt này quá cũ");
                DateTimeOffset exportedTime = DateTimeOffset.FromUnixTimeSeconds(reader.ReadInt64());
                int memCount = reader.ReadInt32();
                mem.Clear();
                while (memCount-- > 0)
                {
                    string key = reader.ReadString();
                    if (mem.ContainsKey(key))
                        throw new Exception($"Lỗi file\nĐã tồn tại key {key}");
                    int valueLength = reader.ReadInt32();
                    byte[] value = reader.ReadBytes(valueLength);
                    this.addOrUpdateSettingValue(key, this.decrypt(value));
                }
            }
        }
    }
}
