using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01OOp
{
    public class BorrowedBook : LibraryItem
    {
        public Book BookDetails {  get; set; }
        
        public string BorrowerName {  get; set; }

        public DateTime BorrowedDate { get; set; }

        public BorrowedBook(int itemId, Book book, string borrowerName, DateTime borrowedDate)
        {
            ItemId = itemId;
            BookDetails = book;
            BorrowerName = borrowerName;
            BorrowedDate = borrowedDate;
        }

        public int CalculateBorrowDuration()
        {
            return (DateTime.Now - BorrowedDate).Days;
        }

    }
}
