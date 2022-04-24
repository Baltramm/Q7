using System;

namespace Q7
{
	class Program
	{
		static void Main(string[] args)
		{
			int num1 = 3;
			int num2 = 58;

			Helper.Swap(ref num1,ref num2);

			Console.WriteLine(num1); //58
			Console.WriteLine(num2); //3
		}
	}
	class Helper
	{
     public static void Swap (ref int a,ref int b )
        {
			int num3 = a;
			a = b;
			b = num3;
        }
    }


}

