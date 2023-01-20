using System;

namespace myProject-1
{
  class Program
  {
    static void Main(string[] args)
    {
                                            //        ===== VARIABLE ======           //

// Syntax
// type,variableName = value;

                                        // === Type String ====// stored Multiple Character

// string name = "Ali";
// Console.WriteLine(name);

                                        // // === Type Integers ====// stored Numbers

// int myNum = 15;
// Console.WriteLine(myNum);

// int myNum2; // That is Declaration
// myNum2 = 15; // That is Assigning or initiallizing
// Console.WriteLine(myNum2);

// int myNum3 = 15;
// myNum3 = 20; // change value myNum3 is now 20
// Console.WriteLine(myNum3);


                                        // // === Type Double ====// stored Decimal Number

// double myDoubleNum = 5.99D;
// Console.WriteLine(myDoubleNum);


                                        /* === Type Char ==== */ // stored single Character

// char myLetter = 'D';
// Console.WriteLine(myLetter);


                                        /*  === Type Boolean ==== */ // stored Only True Or False

// bool myBool = true;
// Console.WriteLine(myBool);

// int num1 = 10;
// int num2 = 20;

// bool c = num1 > num2;
// System.Console.WriteLine(c); // false


                                        /* ===== Float ======   */  // Floating point number

// float Num = 56.7587F;
// Console.WriteLine(Num); // 7 digits se ziada numbers honge to error show hoga 


                                                // /* ===== Double ======   */ 

// double myNum = 19.99D;
// Console.WriteLine(myNum);

// /* ===== Decimal ======   */ 

// double num5 = 19.99;
// Console.WriteLine(num5);

//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                                                /* ==== Data Type Conversion */

// 1) Implicit Conversion is done by the Compiler is own 

// int x = 30;
// float y = x;
// System.Console.WriteLine(y);


// // 2) Explicit Conversion  ham khud krtey hain
// // (int),(string) etc
// // Convert.To
// //.parse

// float m = 30.866f;
// int n = (int)m; //First Way
// // int n = Convert.ToInt32 (m); //2nd Way
// System.Console.WriteLine(n);


// int myInt = 10;
// double myDouble = 5.25;
// bool myBool = true;

// Console.WriteLine(Convert.ToString(myInt));    // convert int to string
// Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
// Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
// Console.WriteLine(Convert.ToString(myBool));   // convert bool to string


// string h = "50";
// string g = "50";
// int i = int.Parse(h) + int.Parse(g);
// System.Console.WriteLine(i);

// string l = "60.756";
// string v = "80.45678";
// float q = float.Parse(l) + float.Parse(v);
// System.Console.WriteLine(q);

//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                                /*      Operators        */

                                        //Aithematic


// Operator	     Name	                     Description	                                  Example	T
//  +	       Addition	            Adds together two values	                   x + y	
//  -	       Subtraction	        Subtracts one value from another               x - y	
//  *	       Multiplication	    Multiplies two values	                       x * y	
//  /	       Division	            Divides one value by another	               x / y	
//  %	       Modulus	            Returns the division remainder	               x % y	
//  ++	       Increment          	Increases the value of a variable by 1	        x++	
//  --	       Decrement	        ecreases the value of a variable by 1      	    x--	


// int x = 5;
// int y = 3;
// Console.WriteLine(x + y);  // 8
// Console.WriteLine(x - y);  // 
// Console.WriteLine(x * y);  // 15
// Console.WriteLine(x / y);  //
// Console.WriteLine(x % y);  // 1
//  x++;
//  y--;
// Console.WriteLine(x);  // 6
// Console.WriteLine(y);  // 4 

//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                                        //Assignment


// Operator	            Example	                 Same As	
//     =	             x = 5	                x = 5	
//     +=	             x += 3	                x = x + 3	
//     -=	             x -= 3	                x = x - 3	
//     *=	             x *= 3	                x = x * 3	
//     /=	             x /= 3	                x = x / 3	
//     %=             	 x %= 3             	x = x % 3	
//     &=	             x &= 3	                x = x & 3	
//     |=	             x |= 3	                x = x | 3	
//     ^=	             x ^= 3	                x = x ^ 3	
//     >>=	             x >>= 3	            x = x >> 3	
//     <<=            	 x <<= 3	            x = x << 3	

//  int x = 5;
//  x += 3;
//  Console.WriteLine(x); //8

//  x -= 3;
// Console.WriteLine(x); //2

//  x *= 3;
// Console.WriteLine(x); //15

// // double x = 5;
//  x /= 3;
// Console.WriteLine(x); //1.6666666666666667

//  x %= 3;
//  Console.WriteLine(x); //2

//  x &= 3;
//  Console.WriteLine(x); //1

//  x |= 3;
//  Console.WriteLine(x); //7

//   x ^= 3;
//  Console.WriteLine(x); //7

//   x >>= 3;
//  Console.WriteLine(x); //0

//   x <<= 3;
//  Console.WriteLine(x); //40

//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                                    // Comparision Operator

// Operator	                Example	                             Same As	
    // ==	                Equal to	                     x == y	
    // !=	                Not equal	                     x != y	
    // >	                Greater than	                 x > y	
    // <	                Less than	                     x < y	
    // >=	                Greater than or equal to	     x >= y	
    // <=	                Less than or equal to	         x <= y	


//  int x = 5;
//  int y = 3;
//  Console.WriteLine(x == y);  // returns False because 5 is not equal to 3
//  Console.WriteLine(x != y);  // returns True because 5 is not equal to 3
//  Console.WriteLine(x > y); // returns True because 5 is greater than 3
//  Console.WriteLine(x < y); // returns False because 5 is not less than 3
//  Console.WriteLine(x >= y); // returns True because 5 is greater, or equal, to 3
//  Console.WriteLine(x <= y); // returns False because 5 is neither less than or equal to 3

 //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    
                                        //Logical Operators

// Operator	                Example	                                                                Same As	

//    && 	             Logical and  Returns True if both statements are true	                   x < 5 &&  x < 10	
//    || 	             Logical or	Returns True if one of the statements is true	               x < 5 || x < 4	
//    !	             Logical not	Reverse the result, returns False if the result is true	    !(x < 5 && x < 10)	


// int x = 5;
// Console.WriteLine(x > 3 && x < 10); // returns True because 5 is greater than 3 AND 5 is less than 10
// Console.WriteLine(x > 3 || x < 4); // returns True because one of the conditions are True (5 is greater than 3, but 5 is not less than 4)
// Console.WriteLine(!(x > 3 && x < 10)); // returns False because ! (not) is used to reverse the result
     
//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


                                        /*          Strings           */

                                                // String.Length

//the length of a string can be found with the Length property:

//  string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
//  Console.WriteLine("The length of the txt string is: " + txt.Length); //The length of the txt string is: 26
//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                                                // ToUpper() and ToLower()

// ToUpper() and ToLower(), which returns a copy of the string converted to uppercase or lowercase:


string txt = "Enter your message";
Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
Console.WriteLine(txt.ToLower());   // Outputs "hello world"


//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                                                // String Concatenation
//The + operator can be used between strings to combine them. This is called concatenation:
//we have added a space after "Ali " to create a space between firstName and lastName on print
//+ operator for both addition and concatenation.Numbers are added. Strings are concatenated.

string firstName = "Ali ";
string lastName = "Ahmed";
string name = firstName + lastName; // 1st Method 

// You can also use the string.Concat() method to concatenate two strings:

// string name = string.Concat(firstName, lastName); // 2nd Method
Console.WriteLine(name);// Ali Ahmed


// use the dollar sign ($) when using the string interpolation method.

// string name = $"My full name is: {firstName} {lastName}";
Console.WriteLine(name);
  
 int x = 10;
 int y = 20;
 int z = x + y;
 Console.WriteLine(z); //z will be 30 (an integer/number)

 int a = 10;
 int b = 20;
 int c = a + b;
 Console.WriteLine(c); // // z will be 1020 (a string)


//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                                                // Acces String
// we can access the characters in a string by referring to its index number inside square brackets []  index start with 0.

string myString = "Hello";
Console.WriteLine(myString[0]);  // Outputs "H"
Console.WriteLine(myString[1]);  // Outputs "e"

//IndexOf:  we can also find the index position of a specific character in a string, by using the IndexOf() method:
Console.WriteLine(myString.IndexOf("o"));  // Outputs "4"

//.Substring() extracts the characters from a string, starting from the specified character position/index, and returns a new string.

// Full name
string fname = "John Doe";

// Location of the letter D
int charPos = fname.IndexOf("D");

// Get last name
string lName = fname.Substring(charPos);

// Print the result
Console.WriteLine(lName);


//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                                        //Special Characters & Escape Characters

// Escape character             	Result	         Description
//      \'	                          '	            Single quote
//      \"	                           "	         Double quote
//      \\	                           \	          Backslash


// Code	                               Result	        
//  \n                                New Line	
//  \t	                                Tab	
//  \b	                              Backspace	


//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




    }
  }
}
