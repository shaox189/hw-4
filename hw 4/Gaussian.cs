using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_4
{
    public class Gaussian
    {
        private static Random random = new Random();

        public static double[] polar_rejection()
        {
            Console.WriteLine("Running Polar Rejection method.");
            double[] return_value = new double[2];
            double x1, x2, w, c;
            do
            {
                x1 = random.NextDouble();  //generate two uniform random values on the unit interval
                x2 = random.NextDouble();
                w = x1 * x1 + x2 * x2;
            }
            while (w > 1.0);

            c = System.Math.Sqrt((-2.0 * System.Math.Log(w)) / w);
            return_value[0] = x1 * c;
            return_value[1] = x2 * c;
            Console.WriteLine("z1 = " + return_value[0] + ", z2 = " + return_value[1]);
            return return_value;
        }

        public static double[] boxMuller()
        {
            Console.WriteLine("Running Box Muller method.");
            double[] return_value = new double[2];
            double x1, x2, w, c;
            {
                x1 = random.NextDouble();  //generate uniform (0,1] random values
                x2 = random.NextDouble();
            }
            return_value[0] = System.Math.Sqrt(-2 * Math.Log(x1)) * Math.Cos(2.0 * Math.PI * x2);
            return_value[1] = System.Math.Sqrt(-2 * Math.Log(x1)) * Math.Sin(2.0 * Math.PI * x2);
            Console.WriteLine("z1 = " + return_value[0] + ", z2 = " + return_value[1]);
            return return_value;
        }
        public static double sumtwelve()
        {
            Console.WriteLine("Running Sum Twelve method.");
            double sum = 0;

            for (int i = 0; i < 12; i++)
            {
                double x = random.NextDouble();
                sum = sum + x;
            }
            sum = sum - 6;
            Console.WriteLine(sum);
            return sum;
        }
    }

}
