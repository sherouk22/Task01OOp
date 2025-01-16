using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01OOp
{
    public class BorrowedBook : LibraryItem
    {
        public Book BookDetails { get; set; }

        public string BorrowerName { get; set; }

        public DateTime BorrowedDate { get; set; }

        public BorrowedBook(int itemId, Book _book, string borrowerName, DateTime borrowedDate)
        {
            ItemId = itemId;
            BookDetails = _book;
            BorrowerName = borrowerName;
            BorrowedDate = borrowedDate;
        }

        public int CalculateBorrowDuration()
        {
            return (DateTime.Now - BorrowedDate).Days;
        }


        public override string ToString()
        {
            return $"Borrower: {BorrowerName}, Borrowed Date: {BorrowedDate.ToShortDateString()}, " +
                   $"Book Details: {BookDetails}, Is Available: {IsAvailable}";
        }
    }
}