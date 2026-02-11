using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AM.ApplicationCore
{
    public static class CoreExtensions
    {
        public static void ShowList<T>(
            this IEnumerable<T> list,
            string title,
            ShowLine showLine)
        {
            showLine("========== " + title + " ==========");

            foreach (var item in list)
                showLine(item.ToString());
        }
    }
}
