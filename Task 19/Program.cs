/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/


bool IsPalindrome(string S) //универсальная функция - определяет, является ли строка произвольной длины палиндромом 
{
    int L = S.Length;

    for (int i = 0; i < L / 2; i++)
    {
        if (!(S.Substring(i, 1) == S.Substring(L - i - 1, 1))) return false;
    }
    return true;
}

System.Console.Write("Enter a 5-digit number to be identified as palindrome: ");
string numString = System.Console.ReadLine()!;
int fiveDigitNumber = 0;
bool canConvert = int.TryParse(numString, out fiveDigitNumber);
if (canConvert == true)
{
    numString = fiveDigitNumber.ToString();
    if (numString.Length == 5)
    {
        bool result = IsPalindrome(numString);
        Console.WriteLine(result);
    }
    else Console.WriteLine("A 5-digit number needed");
}
else
    Console.WriteLine("A number needed");

