using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task01OOp
{
    public class LibraryItem
    {
        public int ItemId { get; set; }
        public bool IsAvailable { get; set; } = true;

        public void CheckOut()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine("Item has been checked out");
            }
            else
            {
                Console.WriteLine("Item is already checked out.");
            }


        }

        public void ReturnItem()
        {
            if(!IsAvailable)
            {
                IsAvailable = true;
                Console.WriteLine("Item has been returned.");

            }
            else
            {
                Console.WriteLine("Item was not checked out.");
            }

        }



    }
}
