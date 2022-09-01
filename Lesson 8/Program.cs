namespace Lesson8;

class Translator
{
    private List<string> words { get; set; }
    private string[,] translations { get; set; }

    public Translator(int length)
    {
        words = new List<string>();
        translations = new string[length, 10];

        for (int i = 0; i < length; i++)
        {
            words.Add("");
        }

    }

    public string this[int index]
    {
        get => words[index];
        set => words[index] = value;
    }

    public string this[int index, int index2]
    {
        get => translations[index, index2];
        set => translations[index, index2] = value;
    }


    public override string ToString() =>
$@"-----Translator-----
{words.Count} words
--------------------";


    public void showTranslations(string word)
    {
        if (words.Contains(word))
        {
            var index = words.IndexOf(word);
            var length = translations[index, 0].Length;
            Console.WriteLine($"\n{word} -");
            for (int i = 0; i < 10; i++)
            {
                if (translations[index, i] != null)
                    Console.WriteLine($"   {translations[index, i]}");
            }
            return;
        }
        Console.WriteLine($"We don't have word {word} in our database...");
    }

    public void showTranslations(int index)
    {
        if (index > words.Count || index < 0)
        {
            Console.WriteLine("Wrong / Invalid index...");
            return;
        }
        var length = translations[index, 0].Length;
        Console.WriteLine($"\n{words[index]} -");
        for (int i = 0; i < 10; i++)
        {
            if (translations[index, i] != null)
                Console.WriteLine($"   {translations[index, i]}");
        }
    }

}


class Program
{

    static void Main(string[] args)
    {

        var luget = new Translator(5);

        luget[0] = "Hello";
        luget[0, 0] = "Salam";
        luget[0, 1] = "Alo";
        luget[0, 2] = "Dinleyirem";
        luget[0, 3] = "Qulaq asiram";

        luget[1] = "picture";
        luget[1, 0] = "şəkil";
        luget[1, 1] = "təsvir";
        luget[1, 2] = "rəsm";

        luget[2] = "write";
        luget[2, 0] = "yazmaq";
        luget[2, 1] = "qoşmaq";

        luget[3] = "right";
        luget[3, 0] = "sağ";
        luget[3, 1] = "doğru";
        luget[3, 2] = "düz";
        luget[3, 3] = "haqlı";
        luget[3, 4] = "ixtiyar";

        luget[4] = "note";
        luget[4, 0] = "qeyd";
        luget[4, 1] = "not";
        luget[4, 2] = "nota";
        luget[4, 3] = "yazı";

        while (true)
        {
            Console.WriteLine("-----Translater-----");
            Console.Write("Enter an english word : ");
            var word = Console.ReadLine();

            luget.showTranslations(word ?? ".");

            Console.WriteLine("\nPress any key to continue...\n");
            Console.ReadKey();
            Console.Clear();

        }

    }

}