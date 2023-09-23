//! Array in C#
// sane as java 
int[] arr = {10, 12, 13, 6};

for(int i = 0; i < arr.Length; i++){
    Console.WriteLine(i);
}

// ----------------------------------------------------------------
 Console.WriteLine("================================");


 int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };


string[] names = new string[3];

names[0] = "ali ";
names[1] = "ben ";
names[2] = "stones ";

for(int i = 0; i < names.Length; i++){
    Console.WriteLine(names[i]);
}
//! for each loop in c#
foreach (string name in names)
{
    Console.WriteLine(name);
}
