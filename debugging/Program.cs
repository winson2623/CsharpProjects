/*
string[] students = new string[] {"Sophia", "Nicolas", "Zahirah", "Jeong"};

int studentCount = students.Length;

Console.WriteLine("The final name is: " + students[studentCount]);
*/

string[] students = new string[] {"Sophia", "Nicolas", "Zahirah", "Jeong"};

int studentCount = students.Length;

//arrays count from zero, fixed [studentCount - 1] to debug
Console.WriteLine("The final name is: " + students[studentCount - 1]);