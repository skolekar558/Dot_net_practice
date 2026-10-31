using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public interface ICustomer
    {
        string Print();
    }
    public interface IOrder {
        string Print();
    }
    public class Transaction : ICustomer, IOrder
    {
        //it is default public
        string ICustomer.Print()
        {
            return "Customer details:";
        }

        string IOrder.Print()
        {
            return "Order details:";
        }
    }
}
