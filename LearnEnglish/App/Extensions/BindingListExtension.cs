using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEnglish.App.Extensions
{
    public static class BindingListExtension
    {
        public static void AddRange<T>(this BindingList<T> refCtl, IEnumerable<T> data)
        {
            foreach (T item in data)
            {
                refCtl.Add(item);
            }
        }
    }
}
