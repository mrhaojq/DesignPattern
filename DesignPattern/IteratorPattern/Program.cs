using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * Aggregate 集合接口 对应 Iterator 迭代器接口 
             * BookShelf 实现了Aggregate的具体集合 对应  BookShelfIterator实现了Iterator的具体迭代器
             * BookShelfIterator是知道BookShelf的具体实现的
             * 
             * 使用时是面向接口变成 Aggregate 和 Iterator
             * Iterator it=bookShelf.iterator();
             * while (it.HasNext())
             *{
             *   Book book = (Book)it.Next();
             *   Console.WriteLine(book.GetName());
             *}
             */

            BookShelf bookShelf = new BookShelf(4);

            bookShelf.AppendBook(new Book("Around the World in 80 Days"));
            bookShelf.AppendBook(new Book("Bible"));
            bookShelf.AppendBook(new Book("Cinderella"));
            bookShelf.AppendBook(new Book("Daddy-Long-Legs"));

            Iterator it = bookShelf.iterator();

            while (it.HasNext())
            {
                Book book = (Book)it.Next();
                Console.WriteLine(book.GetName());
            }
            
            NewBookShelf newBookShelf = new NewBookShelf();
            newBookShelf.AppendBook(new Book("Around the World in 80 Days"));
            newBookShelf.AppendBook(new Book("Bible"));
            newBookShelf.AppendBook(new Book("Cinderella"));

            Iterator newIt = newBookShelf.iterator();

            //当BookShelf与BookShelfIterator代码发生变化时，便利的代码并没有发生变化
            while (newIt.HasNext())
            {
                Book book = (Book)newIt.Next();
                Console.WriteLine($"New {book.GetName()}");
            }

            //
            List<Book> list = new List<Book>();
            list.Add(new Book("Around the World in 80 Days"));
            list.Add(new Book("Bible"));
            list.Add(new Book("Cinderella"));

            foreach (var bk in list)
            {
                Console.WriteLine($"List {bk.GetName()}");
            }

            Console.ReadKey();
        }
    }
}
