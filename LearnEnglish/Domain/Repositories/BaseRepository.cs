using LearnEnglish.Infrastructure.DataAccess.EF.SqlServer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEnglish.Domain.Repositories
{
    public abstract class BaseRepository
    {
        public BaseRepository()
        {

        }

        protected EnglishDbContext CreateContextFactory()
        {
            return new EnglishDbContext();
        }
    }
}
