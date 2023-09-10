// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;

Console.WriteLine("----------------------------- Section one ------------------------------------");
Console.WriteLine("");

// common date types in C#

int integer = 10;
double floatValue = 345.76657;  //! int & double are default date types
float floatValue2 = 35.45f;
long longValue = 435345;
bool boolValue = true;
char charValue = 'G';
string stringValue = "say hi";
decimal decimalValue = 34543543.455647457m;

//? There are more date types in C# visit : https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types

//! using special characters to modify string 

// ' $ ' used for string interpolation
// ' @ ' for Verbatim text
// ' """ string """ ' for raw string

Console.WriteLine(@$"This is an integer: {integer}. This is double: {floatValue}. This is float: {floatValue2}.
This is long: {longValue}. This is bool: {boolValue}. This is char: {charValue}. This is string: {stringValue}. This is decimal: {decimalValue}");

// if else and for loop and while loop is same as java
//! C# not have do while loop

Console.WriteLine("----------------------------- Section Two ------------------------------------");
Console.WriteLine("");

//! functions
/* C# has four modifiers: 
public 
private
protected
internal 
*/

messageFun();

void messageFun(){
    Console.WriteLine("This is a function called\n");
}



