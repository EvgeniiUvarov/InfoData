// Задача 71:** В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из n 
// букв, которые можно построить из букв этого алфавита.
// n = 2 -> аа, ии, сс, вв, аи, иа, ис, си, ас, са,
// ав, ва, ви, ив, св, вс

using static System.Console;

Write("Введите число: ");
int numN = int.Parse(ReadLine());
string str = "аисв";

RecursMethod(numN,str,"");

void RecursMethod(int numN, string str, string alf)
{
   if(numN == 0) Write($"{alf} ");
   else 
   foreach (char it in str)
   {
      RecursMethod(numN-1, str, alf+it);
   }
}


