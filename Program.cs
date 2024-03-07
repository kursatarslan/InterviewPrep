using System;
using System.Linq;
public record Person(string FirstName, string LastName, int doorNumber, int Amount);

public record Book {

    public string Isbn { get; set; }
     public string Title { get; set; }

    public Book() {
        Console.WriteLine("Empty constructor");   
    }
    public Book(string Isbn, string Title) : this()
    {
            Console.WriteLine("Empty constructor");  
            this.Title = Title; 
            this.Isbn = Isbn;

    }
}



public class Program
{
    static List<Person> people =
    [
        new("Kursat", "Arslan", 1, 200),
        new("John", "Nash", 2, 300),
        new("Alper", "ALp", 3, 250),
        new("John", "Bu", 4, 400),
        new("Steven", "St", 5, 500 ),
        new("Yahya", "Nash",6, 400)
    ];
    public static void Main() 
    {
        var book = new Book("1111","c# Advanced");
        var book1 = new Book() {Isbn = "1111111111111111111111111111111111" , Title= "asd"};

        foreach ( var varible in people.GroupBy(b=> b.FirstName).Select( s => new { Name = s.Key, Count = s.Count()}).OrderByDescending( o => o.Count))
        {
            Console.WriteLine($@"Name {varible.Name}  Count { varible.Count}");
        }
        
        foreach ( var varible in people.Where(s => s.Amount > 250 ).OrderByDescending(o => o.Amount))
        {
            Console.WriteLine($@"Name {varible.FirstName}  Last { varible.LastName} Amount {varible.Amount}");
        }
        
        var sumAmount =  people.Sum(s => s.Amount);
        
        Console.WriteLine($@"sumAmount {sumAmount}  ");
        
        
        int i = 0;
        Console.WriteLine(i++);
        Console.WriteLine(++i);
    }
}
