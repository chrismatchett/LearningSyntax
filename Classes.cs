using System;
public class Classes
{
  public static void output()
  {
        //Console.WriteLine("Classes");
        Car myObj = new Car();
        Console.WriteLine(myObj.color);
  }
}

public class Car 
{
    public string color = "red";

}