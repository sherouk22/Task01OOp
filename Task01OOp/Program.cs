namespace Task01OOp
{
    internal class Program
    {//Task01OOp
        static void Main(string[] args)
        {
            Book book = new Book("welcome with OOP","Ahmed Khaled","123456");

            BorrowedBook borrowedBook = new BorrowedBook(1,book,"Sherouk", new DateTime(2025, 1, 10));


            Console.WriteLine(borrowedBook.ToString());

            borrowedBook.CheckOut();

            Console.WriteLine(borrowedBook);

            borrowedBook.ReturnItem();

            Console.WriteLine(borrowedBook);






        }
    }
}
