using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assignment_1_2025_77742.Models
{
    public interface NoBorrowable
    {
        void Borrow();
        void ReturnTool();
        bool CheckBorrowed();
    }

}
