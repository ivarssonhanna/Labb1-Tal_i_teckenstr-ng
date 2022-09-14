// 29535123p48723487597645723645

using System.Data.Common;

Console.WriteLine("Skriv in en sträng: ");
string input = Console.ReadLine();

string substringTal = "";
long sum = 0;                                       // deklarerar en variabel att spara summan i till senare

for (int i = 0; i < input.Length; i++)
{
    if (char.IsDigit(input[i]))                     // kontrollerar att i är en siffra
    {
        for (int j = i + 1; j < input.Length; j++)
        {
            if (!char.IsDigit(input[j]))            // OM tecknet inte är en siffra går den ur loopen 
                break;

            if (input[i] == input[j])               // OM input[i] och input[j] har samma värde blir det en match
            {
                Console.WriteLine();
                int delSträngLängd = j - i + 1;
                Console.Write(input.Substring(0,i));
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(input.Substring(i,delSträngLängd));
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(input.Substring(j + 1));

                substringTal = input.Substring(i, j - i + 1);
                long resultat;
                long.TryParse(substringTal, out resultat);
                sum += resultat;
                break;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("\nTotal = " + sum);
