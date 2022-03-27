using hw_4;

double st1 = Gaussian.sumtwelve();
double st2 = Gaussian.sumtwelve();
Console.WriteLine("Please enter an input correlation value between -1 and 1: ");
string inputstring = Console.ReadLine();
double correlation_value = Convert.ToDouble(inputstring);
Joint.joint_values(st1, st2, correlation_value);


double[] pr = Gaussian.polar_rejection();
Console.WriteLine("Please enter an input correlation value between -1 and 1: ");
string inputstring1 = Console.ReadLine();
double correlation_value1 = Convert.ToDouble(inputstring1);
Joint.joint_values(pr[0], pr[1], correlation_value1);


double[] bx = Gaussian.boxMuller();
Console.WriteLine("Please enter an input correlation value between -1 and 1: ");
string inputstring2 = Console.ReadLine();
double correlation_value2 = Convert.ToDouble(inputstring2);
Joint.joint_values(bx[0], bx[1], correlation_value2);



