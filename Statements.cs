using System;
public class Statements
{
  public static void output()
  {
          // If Statements


/*           int testFalsey = 0;
          if(testFalsey){
            Console.WriteLine(testFalsey);
          } */

          
          bool testTrue = true;
          
          if(testTrue){
            //Console.WriteLine(testTrue);
          } else {
            //Console.WriteLine("false");
          }

          //Switch Statements

          /*
          int day = 4;
          switch(day) 
          {
            case 1:
              Console.WriteLine("Monday");
              break;
            case 2:
              Console.WriteLine("Tuesday");
              break;
            case 3:
              Console.WriteLine("Wednesday");
              break;
            case 4:
              Console.WriteLine("Thursday");
              break;
            case 5:
              Console.WriteLine("Friday");
              break;
            case 6:
              Console.WriteLine("Saturday");
              break;
            case 7:
              Console.WriteLine("Sunday");
              break;
          }
          */

          // Outer loop
          for(int i = 0; i <= 2; ++i) 
          {
            //Console.WriteLine("Outer: " + i);  // Executes 2 times

            // Inner loop
            for (int j = 1; j <= 3; j++) 
            {
              //Console.WriteLine(" Inner: " + j); // Executes 6 times (2 * 3)
            }
          }

          // Understanding ++i and i++

          /* 
          int a = 10;
          int b = 5;
          int c = a++ + b++;
          Console.WriteLine("A = " + a + ", B = " + b + ", C = " + c);
          a = 10;
          b = 5;
          c = ++a + ++b;
          Console.WriteLine("A = " + a + ", B = " + b + ", C = " + c); 

          // Prefix Increment Operator        
          int k = 3;
          Console.WriteLine(k);   // output: 3        
          Console.WriteLine(k++); // output: 3        
          Console.WriteLine(k);   // output: 4        
          
          // Postfix Increment Operator        
          double a = 1.5;
          Console.WriteLine(a);   // output: 1.5        
          Console.WriteLine(++a); // output: 2.5        
          Console.WriteLine(a);   // output: 2.5
          */

  }
}