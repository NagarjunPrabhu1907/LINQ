using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

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
        //end



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
       //end


        Func<int, int> square = x => x * x;
        Console.WriteLine(square(5));

        List <string > files = new List<string>()
        {
            "report1.pdf" , "report2.pdf", "data.pdf" ,"letter2.pdf","maths.txt","Social.txt","read.doc","earth.doc"

        };
         

        //using normal method
        //List<string> docfiles = new List<string>();  
        //foreach (var file  in files)
        //{
        //    if (file.EndsWith(".doc")) 
        //        docfiles.Add(file);
        //}

        //using linq 
        var docfiles = from f in files
                       where f.EndsWith(".doc")
                       select f; 
        Console.WriteLine("doc files are");
        foreach (var docfile in docfiles) 
        {
            Console.WriteLine(docfile);
        }
        //end




        List<Customer> customers = new List<Customer>
        {
            new Customer{FirstName = "arun", LastName = "kumar" , age = 22},
            new Customer{FirstName = "varun", LastName = "singh" , age = 23},
            new Customer{FirstName = "ram", LastName = "kumar" , age = 20},
            new Customer{FirstName = "raj", LastName = "kanth" , age =32 },
            new Customer{FirstName = "viru", LastName = "nand" , age =24 },
            new Customer{FirstName = "anand", LastName = "chawla" , age =34 }
        };
        var youngCustomers = from c in customers
                             where c.age <25
                             select c;
        foreach (var yc in youngCustomers)
        {
            Console.WriteLine(yc.Display());
        }


    }
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int age { get; set; }

        public string Display()
        {
            return String.Format("{0},{1},{2}",FirstName,LastName,age);
        }
    }

}



