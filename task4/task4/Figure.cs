using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Figure
    {

        private Point Q, W, E, R, T;


        public string figurename;

        public Figure(Point Q, Point W, Point E)
        {
            this.Q = Q;
            this.W = W;
            this.E = E;
            this.figurename = "Triangle";
        }
        public Figure(Point Q, Point W, Point E, Point R)
        {
            this.Q = Q;
            this.W = W;
            this.E = E;
            this.R = R;
            this.figurename = "Quadrilateral";
        }
        public Figure(Point Q, Point W, Point E, Point R, Point T)
        {
            this.Q = Q;
            this.W = W;
            this.E = E;
            this.R = R;
            this.T = T;
            this.figurename = "Pentagon";
        }

        public double LengthSide(Point Q, Point W)
        {
            return Math.Sqrt(Math.Pow((Q.i - W.i), 2) + Math.Pow(Q.k - W.k, 2));
        }

        public void PerimeterCalculator()
        {
            if (T != null)
            {
                Console.WriteLine($"Perimetr: {(LengthSide(Q, W) + LengthSide(W, E) + LengthSide(E, R) + LengthSide(R, T) + LengthSide(T, Q))}");
            }
            else if (R != null)
            {
                Console.WriteLine($"Perimetr: {(LengthSide(Q, W) + LengthSide(W, E) + LengthSide(E, R) + LengthSide(R, Q))}");
            }
            else
            {
                Console.WriteLine($"Perimetr: {(LengthSide(Q, W) + LengthSide(W, E) + LengthSide(E, Q))}");
            }

        }
    }

}
