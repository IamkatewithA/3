using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba3
{
    internal class Class1
    {
        public double F1(double x)
        {
            double f;
            if (x == 0)
            {
                f = double.NaN;
                //MessageBox.Show("Нельзя делить на 0");
            }
            else
            {
                f = Math.Tan(1 / (x * x));
            }
            return f;
        }
        public double F2(double x)
        {
            double f;
            if (x <= 2)
            {
                f = Math.Sqrt(2 - x) / x;
            }
            else
            {
                f = double.NaN;
                //MessageBox.Show("Нельзя делить на 0");
            }
            return f;
        }
        public double F3(double x)
        {
            double f;
            if (x < 0)
            {
                f = Math.Log10(x * x);
            }
            else
            {
                if (x >= 1)
                {
                    f = double.NaN;
                    //MessageBox.Show("Arcsin существует в пределах от -1 до 1");
                }
                else
                {
                    f = Math.Asin(x + 1);
                }
                    
            }
            return f;
        }
        public double F4(double x)
        {
            double f = 0;

            for (int j = 0; j < 1000000; j++)
            {
                if (x + Math.Sqrt(j) == 0)
                {
                    f = double.NaN;
                    //MessageBox.Show("Нельзя делить на 0");
                }
                else
                {
                    f += (1 / (x + Math.Sqrt(j)));
                }

            }
            return f;
        }
        public Array F(double x, double y, double z)
        {
            double f;
            int counter = 0;
            double i = (y - x) / z;
            List<double> list = new List<double>();
            do
            {
                x += counter * i;
                f = F1(x) + F2(x) + F3(x) + F4(x);
                counter++;
                list.Add(f);

            }while(counter < z);
            return list.ToArray();
        }
    }
}


