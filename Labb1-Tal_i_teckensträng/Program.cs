// 29535123p48723487597645723645

using System.Data.Common;

Console.WriteLine("Skriv in en sträng: ");
string input = Console.ReadLine();
string substringNumber = "";
long sum = 0;                                      

for (int i = 0; i < input.Length; i++)
{
    if (char.IsDigit(input[i]))                   
    {
        for (int j = i + 1; j < input.Length; j++)
        {
            if (!char.IsDigit(input[j]))         
                break;

            if (input[i] == input[j])              
            {
                Console.WriteLine();
                int subStrLength = j - i + 1;
                Console.Write(input.Substring(0,i));
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(input.Substring(i,subStrLength));
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(input.Substring(j + 1));

                substringNumber = input.Substring(i, subStrLength);
                long.TryParse(substringNumber, out long numberSum);
                sum += numberSum;
                break;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("\nTotal = " + sum);