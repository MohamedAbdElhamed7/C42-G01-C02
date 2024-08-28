
namespace Assigment_C_02
{
        class Point
    {
        public int x; 
        public int y;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //1.Write a program that allows the user to enter a number then print it.

            //Console.WriteLine("Enter The Number ");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine($" The Number is :{number} ");
            // Q1 Done 
            #endregion

            #region Q2
            //Q2.Write C# program that Assigning one value type variable to another
            //and modifying the value of one variable and mention what will happen

            //int x = 5;
            //int y = 8;

            //x = y;
            //so x will be equals to 8

            //y = 3;
            // so y will be equal 3 but x will still equals to 8
            // becouse x = y thats mean that x equals to the  value of y (8) not equal to the y
            // so x will not change from 8 to 3 

            //Console.WriteLine($"The value of x is : {x}");
            //Console.WriteLine($"The value of y is : {y}");


            #endregion

            #region Q3
            //Q3.Write C# program that Assigning one reference type variable to another
            //and modifying the object through one variable and mention what will happen


            Point P1;
            // Declare for reference from point , refer null 
            //Allocate 4 bytes at stack
            P1 = new Point();
            // allocate require bytes at heap , 8bytes 
            P1.x = 1;
            P1.y = 2;

            Point P2 = new Point(); // unreachable object 
            P2 = P1;
            
            //if there is change at value of p2 p1 will have same change also if p1 have changes
            //p2 will have  the same because p1 and p2 refere for same location at heap  



            #endregion
        }


    }
}
