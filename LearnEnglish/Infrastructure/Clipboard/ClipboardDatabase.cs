using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEnglish.Infrastructure.Clipboard
{
    public class ClipboardDatabase
    {
        private static object _data = null;
        public static object Data
        {
            get => _data;
            set => _data = value;
        }
    }
}
