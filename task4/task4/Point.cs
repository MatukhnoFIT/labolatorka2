using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    public class Point
    {
        private int I, K;
        public string Name;


        public int i { get { return I; } }
        public int k { get { return K; } }
        public string name { get { return Name; } }

        public Point(int i, int k, string name)
        {
            this.I = i;
            this.K = k;
            this.Name = name;
        }
    }
}
