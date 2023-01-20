using System;

namespace CSharp
{
  class Program
  {
    static void Main(string[] args)
    {
      string fname,lname;
      Console.WriteLine("Enter Your First Name");
      fname = Console.ReadLine();
      Console.WriteLine("Enter Your Last Name");
      lname = Console.ReadLine();
      Console.WriteLine("Your Full Name is"+fname+""+lname);
    }
  }
}