using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var evenNumbers = from num in numbers
                          where num % 2 == 0
                          select num;

        Console.WriteLine("Even Numbers:");
        foreach (var evenNumber in evenNumbers)
        {
            Console.WriteLine(evenNumber);
        }



        string paragraph = "susie           works in a shoeshine shop. Where she shines she sits, And where she sits she shines";

        //IEnumerable<string> splitted = paragraph.Split(' ').AsEnumerable();

        IEnumerable<string> splitted = paragraph.Split(' ', StringSplitOptions.RemoveEmptyEntries).AsEnumerable();
        Console.WriteLine(splitted);

        var test = splitted.Where(a => a.StartsWith("a", StringComparison.OrdinalIgnoreCase));

        foreach (var item in splitted)
        {
            //if (item.StartsWith("a", StringComparison.OrdinalIgnoreCase))
               Console.WriteLine($"{item}");

        }




        var wordsStartingWithS = from word in paragraph.Split(new[] { ' ', '.', ',', '!' }, StringSplitOptions.RemoveEmptyEntries)
                                 where word.Length > 0 && word[0] == 's' || word[0] == 'S'
                                 select word;
        int wordCount = paragraph.Split(new[] { ' ', '.', ',', '!' }, StringSplitOptions.RemoveEmptyEntries).Length;

        //int wordCount = paragraph.Split(new[] { "", ".", ",", "," }).Length;


        Console.WriteLine("Words starting with 's':");
        foreach (var word in wordsStartingWithS)
        {
            Console.Write(word + " ");
        }

        Console.WriteLine("\n\nTotal number of words in the paragraph: " + wordCount);


        Func<int, int> square = x => x * x;
        Console.WriteLine(square(5));



    }
}



