using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_4
{
    public class Joint
    {
        public static double[] joint_values(double epsilon1, double epsilon2, double rho) 
        {
            double[] return_value = new double[2];
            return_value[0]= epsilon1;
            return_value[1]= rho*epsilon1+ System.Math.Sqrt(1-rho*rho)*epsilon2;
            Console.WriteLine("The generated pairs of joint normally distributed random values are: " + return_value[0] + "," +return_value[1]);
            return return_value;
        }


    }

}
