using System;

namespace ClasesGenericasCurso
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Books<Book>();
            //var bookn = book.Book;
            book.Add(new Book
            {
                Id = 1,
                Title = "A new Book"
            });
            book.Add(new Book
            {
                Id = 2,
                Title = "A new Book2"
            });
            /*bookn = new Book
            {
                Id = 1,
                Title = "A new Book"
            };*/
            Console.WriteLine(book.getBook(1).Id + " " + book.getBook(1).Title);
           // Console.WriteLine(bookn.Title +" "+ bookn.Id);
            Console.ReadLine();
        }
    }
}
