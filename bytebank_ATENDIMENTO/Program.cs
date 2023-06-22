using System.ComponentModel.Design;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

int[] idades = new int[4];
int contador = 0;

idades[0] = 43;
idades[1] = 13;
idades[2] = 56;
idades[3] = 22;

Array amostra = Array.CreateInstance(typeof(double), 5);
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);

//TestArrayInt(idades);
//TestFindWord();
TestMediana(amostra);

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

void TestMediana(Array array) {

    if ((array == null) || (array.Length == 0))
    {
        Console.WriteLine("Empty or null array.");
    }

    double[] ordered = (double[])array.Clone();
    Array.Sort(ordered);

    foreach (double x in ordered) Console.WriteLine(x);

    int tamanho = ordered.Length;
    int meio = tamanho / 2;
    double mediana = (tamanho % 2 != 0) 
        ? ordered[meio] 
        : (ordered[meio] + ordered[meio - 1]) / 2;

    Console.WriteLine($"Mediana: {mediana}");
}