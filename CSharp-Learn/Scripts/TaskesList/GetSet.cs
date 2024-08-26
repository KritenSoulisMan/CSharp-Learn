using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Learn.Scripts.TaskesList
{
    class GetSet
    {
        private int x;

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                if (1 < value)
                {
                    x = 1;
                    return;
                }
                if (value > 5)
                {
                    x = 5;
                    return;
                }

                x = value;
            }
        }



        private int y;

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                if (1 < value)
                {
                    y = 1;
                    return;
                }
                if (value > 5)
                {
                    y = 5;
                    return;
                }

                y = value;
            }
        }

        public int Z { get; set; }
    }

    class Program2
    {
        // С помощью ctor можно быстро сделать начальный конструктор!
        public Program2() { }

        public void SetPoint()
        {
            var point = new GetSet();

            point.X = 10; // SetX Получит введённое число
            int x = point.X; // х = полученому числу от метода GetX

            point.Y = 10;
            int y = point.Y;
        }
    }
}
