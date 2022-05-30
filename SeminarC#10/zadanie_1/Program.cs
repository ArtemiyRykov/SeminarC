// Задача 71: В некотором машинном алфавите имеются 4е буквы "а", "и", "с" и "в".
// Пакажите все слова, состоящие и n букв, которые можно построить из букв этого алфавита.
// n = 2-> аа, ии, сс, вв, аи, иа, ис, си, ас, са, ав, ва, ви, ив, св, вс

string charWords = "аисв";

int n = int.Parse(Console.ReadLine());
PrintAllWorlds(charWords, n, " ");

void PrintAllWorlds(string alphabet, int lenght, string prefix) // в переменную записали алфавит(lphabet), длину(lenght), разделитель(prefix)
{
    if (lenght == 0)
        Console.Write(prefix);
    else
    {
        foreach (var symbol in alphabet)
        {
            PrintAllWorlds(alphabet, lenght - 1, prefix + symbol);
        }
    }    
}

