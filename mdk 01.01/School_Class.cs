using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdk_01._01
{
    internal class School_Class
    {
        private string _number; //номер кабинета
        private string _wall_color; //цвет обоев
        private int _kolvo_part; //количество парт
        public string Number
        {
            get { return _number; }
        }
        public string WallColor
        {
            get { return _wall_color; }
        }
        public int KolvoPart
        {
            get { return _kolvo_part; }
        }
        public School_Class(string number, string wall_color, int kolvo_part)
        {
            _number = number;
            _wall_color = wall_color;
            _kolvo_part = kolvo_part;
        }
    }
}
