<Query Kind="Statements" />



List<Book> Toledo_books = new List<Book>(){
			new Book(){title = "Ulysses", author = "James Joyce", number_books = 4},
			new Book(){title = "The Great Gatsby", author = "F. Scott Fitzgerald", number_books = 12},
			new Book(){title = "Madame Bovary", author = "Gustave Flaubert", number_books = 7}
};

List<Book> Akron_books= new List<Book>(){
			new Book(){title = "The Great Gatsby", author = "F. Scott Fitzgerald", number_books = 3},
			new Book(){title = "One Hundred Years of Solitude", author = "Gabriel Garcia Marquez", number_books = 9}
};


var results = from book in Toledo_books.Concat(Akron_books) 
			  group book by book.title into books
			  select new {Key = books.Key,Number_of_Books = (from e in books select e.number_books).Sum()};
results.Dump();


public class Book
{
	public string title {get;set;}
	public string author {get;set;}
	public int number_books {get;set;}

}