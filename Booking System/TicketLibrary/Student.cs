using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketLibrary
{
    public class Student : Ticket
    {
        //public Student(string ticketKind, int numberOfPeople, double price)

        //    : base(ticketKind, numberOfPeople, price)
        //{
        //}

        //public Student(string ticketKind, string numberOfPeople, string price)

        //    : this(ticketKind, int.Parse(numberOfPeople), double.Parse(price))
        //{
        //}

        public override double Discount
        {
            get { return this.Discount; }
            set
            {
                this.Discount = base.normalTicket * 0.8;
            }
        }

        //public override string ToString()
        //{
        //    string result = string.Empty;
        //    result += string.Format("學生票(需憑學生證8折優惠) 張數:{0} 金額:{1}\n", this.NumberOfPeople, this.Price);
        //    return result;
        //}
    }
}