using LearnEnglish.Domain.Aggregate.LearningStatuses;
using LearnEnglish.Domain.Aggregate.TopicTrees;
using LearnEnglish.Domain.Aggregate.Vocabs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEnglish.Infrastructure.DataAccess
{
    public class EnglishDbContext : DbContext
    {
        public DbSet<Vocab> Vocabs { get; set; }
        public DbSet<TopicTree> TopicTrees { get; set; }
        public DbSet<LearningVocabStatus> LearningVocabStatuses { get; set; }

        public EnglishDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=HocTiengAnh_05;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
