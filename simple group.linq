<Query Kind="Statements" />

var books =new List<book>()
			{
				new book(){
					title = "He Body Keeps the Score",
					library_id = 100
				},
				new book(){
					title = "How I Saved the World",
					library_id = 100
				},
				new book(){
					title = "How I Saved the World",
					library_id = 101
				},
				new book(){
					title = "The 48 Laws of Power",
					library_id = 101
				}
			};
			
var result = from book in books group book by book.title into book_titles select new {Key = book_titles.Key, Count = book_titles.Count()};
result.Dump();


public class book
{
	public string title {get;set;}
	public int library_id {get;set;}
}