using System.ComponentModel.Design;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

int[] idades = new int[4];
int contador = 0;

idades[0] = 43;
idades[1] = 13;
idades[2] = 56;
idades[3] = 22;

TestArrayInt(idades);
TestFindWord();

void TestArrayInt(int[] array)
{
    //foreach (int x in array) Console.WriteLine(x);
    for (int i = 0; i < 4; i++)
    {
        Console.WriteLine($"Index {i}: {array[i]}");
        contador += array[i];
    }

    double media = contador / array.Length;

    Console.Write($"A media do array: {media}");
}

void TestFindWord()
{
    string[] arrayWords = new string [5];

    for (int i = 0; i < arrayWords.Length; i++)
    {
        Console.Write($"Digite a {i + 1}ª palavra: ");
        arrayWords[i] = Console.ReadLine();
    }

    Console.Write("Buscar Palavra: ");
    var busca = Console.ReadLine();

    foreach (string word in arrayWords)
    {
        if (busca.Equals(word))
        {
            Console.WriteLine(word);
        } 
        else
        {
            Console.WriteLine("Word not found!");
            break;
        }
    }
}