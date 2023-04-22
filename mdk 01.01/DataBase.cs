using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdk_01._01
{
    internal class DataBase
    {
        internal List<School_Class> classes { get; private set; }
        public void InInitialize()
        {
            classes = new List<School_Class>
            {
                new School_Class("б101", "зеленый", 14),
                new School_Class("а228", "белый", 20),
                new School_Class("в304", "серый", 10)

            };

        }
    }
}
