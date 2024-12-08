using System.Globalization;

namespace Assignment_No._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question 01 Write a program that allows the user to enter a number then print it
            //int num;
            //num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(num);
            #endregion

            #region Question 02 Write C# program that converts a string to an integer, but the string contains non-numeric characters.
            //string x = "ahmed";
            //Convert.ToInt32(x);
            //Console.WriteLine(x);
            //there will be a runtime error because it cant change string of characters to integer
            #endregion

            #region Question 03 Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            //float x = 5.5f;
            //float y = 45.8f;
            //Console.WriteLine(x + y);
            //the code will work normally
            #endregion

            #region Question 04 Write C# program that Extract a substring from a given string.
            //string name = "Yousef";
            //Console.WriteLine(name.Substring(2, 2));
            #endregion

            #region Question 05 write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            //int x = 10;
            //int y = x;
            //x = 20;
            //Console.WriteLine($"the value of x:{x}");
            //Console.WriteLine($"the value of y:{y}");
            //the value of x will be assigned  in y and when the value of x change it will not change the value of y with it*/
            #endregion

            #region Question 06 Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            //Data persona = new Data();
            //persona.name = "Ahmed";
            //Console.WriteLine("Before");
            //Console.WriteLine(persona.name);
            //Data persona2=new Data();
            //persona2 = persona;
            //persona2.name = "Mohamed";
            //Console.WriteLine("After");
            //Console.WriteLine(persona.name);
            //Console.WriteLine(persona2.name);
            //when i assigned the name throw persona and assigned persona2=persona i was able to change the value from persona2
            #endregion


            #region Question 07 Write C# program that take two string variables and print them as one variable
            //string first = Console.ReadLine();
            //string second = Console.ReadLine();
            //string result = first + second;
            //Console.WriteLine(result);
            #endregion

            #region Question 08 
            //8 - Which of the following statements is correct about the C#.NET code snippet given below?

            //int d;
            //d = Convert.ToInt32(!(30 < 20));

            //A value 1 will be assigned to d
            #endregion

            #region Question 09 
            //9 - Which of the following is the correct output for the C# code given below?

            //Console.WriteLine(13 / 2 + " " + 13 % 2);

            //6 1
            #endregion

            #region Question 10 
            //10 - What will be the output of the C# code given below?

            //int num = 1, z = 5;

            //if (!(num <= 0))
            //    Console.WriteLine(++num + z++ + " " + ++z);
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);
            //7 7
            #endregion
        }
    }
}
