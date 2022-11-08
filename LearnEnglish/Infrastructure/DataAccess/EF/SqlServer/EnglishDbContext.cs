
using LearnEnglish.Domain.Aggregate.TopicTrees;
using LearnEnglish.Domain.Aggregate.Vocabs;
using LearnEnglish.Infrastructure.Setting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEnglish.Infrastructure.DataAccess.EF.SqlServer
{
    public class EnglishDbContext : DbContext
    {
        public DbSet<Vocab> Vocabs { get; set; }
        public DbSet<TopicTree> TopicTrees { get; set; }
        public DbSet<LearningVocabStatus> LearningVocabStatuses { get; set; }

        public EnglishDbContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(ESetting.Setting.SqliteConnectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
