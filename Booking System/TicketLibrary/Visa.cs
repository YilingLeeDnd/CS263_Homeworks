using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketLibrary
{
    public class Visa : Ticket
    {
        public Visa(string ticketKind, int numberOfPeople, double price)
            : base(ticketKind, numberOfPeople, price)
        {
        }

        public Visa(string ticketKind, string numberOfPeople, string price)

            : this(ticketKind, int.Parse(numberOfPeople), double.Parse(price))
        {
        }

        public override double Price
        {
            get { return this.Price; }
            set
            {
                this.Price = base.normalTicket * base.NumberOfPeople * 0.3;
            }
        }

        public override string ToString()
        {
            string result = string.Empty;
            result += string.Format("持花旗卡購票(5折優惠) 張數:{0} 金額:{1}\n", this.NumberOfPeople, this.Price);
            return result;
        }
    }
}