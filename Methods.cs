using System;
public class Methods
{
  public static void output()
  {
      //Console.WriteLine("Methods");
      Methods.MyMethod("Chris", 51);
  }
  public static void MyMethod(string fname, int age) 
  {
    Console.WriteLine(fname + " is " + age);
  }
}