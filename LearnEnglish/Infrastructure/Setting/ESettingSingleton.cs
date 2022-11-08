using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEnglish.Infrastructure.Setting
{
    public class ESettingSingleton
    {
        private readonly static ESetting _instance = new ESetting("setting.dat");
        public static ESetting Setting => _instance;
    }
}
