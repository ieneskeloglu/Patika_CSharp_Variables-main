using System;

namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {
           //Define variables and print them to the terminal
           byte a = 8; // Byte data type has a minimum value of -128 and a maximum value of 127.
           Console.WriteLine(a);
           sbyte b = 12; // Sbyte data type has a minimum value of -128 and a maximum value of 127.
           Console.WriteLine(b);
           short c = 400; // Short data type has a minimum value of -32.768 and a maximum value of 32.767.
           Console.WriteLine(c);
           ushort d = 10142; //Ushort data type has a minimum value of 0 and a maximum value of 65.535.
           Console.WriteLine(d);
           int e = 788; //Integer data type has a minimum value of -2.147.483.648 and a maximum value of 2.147.483.647.
           Console.WriteLine(e);
           long f = 96542; // Long data type has a minimum value of -2.147.483.648 and a maximum value of 2.147.483.647.
           Console.WriteLine(f);
           float g = 45.8554f; //Float data type has a minimum value of 1.175494351 E - 38 and a maximum value of 3.402823466 E + 38.
           Console.WriteLine(g);
           double h = 9.548785; //Float data type has a minimum value of 1.7E - 308 and a maximum value of 1.7E + 308.
           Console.WriteLine(h);
           string name_surname = "Gülfide Çalışkan";
           Console.WriteLine(name_surname);

           //Boolean Expressions
           bool ı1 = 10 > 5;
           Console.WriteLine(ı1);
           bool ı2 = 5 > 12;
           Console.WriteLine(ı2);

           //Using DateTime
           DateTime dt = DateTime.Now;
           Console.WriteLine("Date of the present: " +dt); 

           string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
           Console.WriteLine("Date: " +dateTime);

            //Hour
            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine("Hour: "+hour);

           //Object 
           object i5 = 19;
           Console.WriteLine(i5);
           object i6 = "gulfidecaliskan";
           Console.WriteLine(i6);
           object i7 = 45.89654;
           Console.WriteLine(i7);

           //String ifadeler
           string str2 = string.Empty;
           str2 = "Gülfide";
           Console.WriteLine(str2);

           //Integer ifadeler
           int num1 = 6;
           int num2 = 8;
           //Addition
           Console.WriteLine(num1 + num2);
           //Substraction
           Console.WriteLine(num1-num2);
           //Multiplication
           Console.WriteLine(num1 * num2);
           // Division
           Console.WriteLine(num1 / num2);

            //Variable Conversions
            string num3 = "442";
            int num4 = 316;
            string newString = num3 + num4.ToString();
            Console.WriteLine("string->new number= " + newString);
            int newInt = Convert.ToInt32(num3) + num4;
            Console.WriteLine("int->new number= "+newInt);





        }
    }
}
