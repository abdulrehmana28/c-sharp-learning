// See https://aka.ms/new-console-template for more information

Console.WriteLine("----------------------------- Section one ------------------------------------");

// common date types in C#

int integer = 10;
double floatValue = 345.76657;  //! int & double are default date types
float floatValue2 = 35.45f;
long longValue = 435345;
bool boolValue = true;
char charValue = 'G';
string stringValue = "say hi";

//? There are more date types in C# visit : https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types

//! using special characters to modify string 

// ' $ ' used for string interpolation
// ' @ ' for Verbatim text
// ' """ string """ ' for raw string

Console.WriteLine(@$"This is an integer: {integer}. This is double: {floatValue}. This is float: {floatValue2}.
This is long: {longValue}. This is bool: {boolValue}. This is char: {charValue}. This is string: {stringValue}");




