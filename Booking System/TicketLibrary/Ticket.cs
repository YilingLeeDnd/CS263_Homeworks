using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketLibrary
{
    public class Ticket
    {
        public double TicketKind { get; set; }
        public double Price { get; set; }
        public double Qty { get; set; }
        public double Discount { get; set; }

        public double NormalTicket
        {
            get { return 320; }
        }

        private double totalPrice;

        public double TotalPrice
        {
            get
            {
                return this.totalPrice;
            }
            set
            {
                this.totalPrice = this.Price * this.Qty;
            }
        }

        public Ticket()
        {
        }

        public Ticket(double ticketKind, double qty, double discount)
        {
            this.TicketKind = ticketKind;
            this.Qty = qty;
            this.Discount = discount;
            this.Price = this.NormalTicket * Discount;
            this.TotalPrice = this.Price * Qty;
        }

        public override string ToString()
        {
            string result = string.Empty;
            result += string.Format("票券類型:{0}\n", this.TicketKind);
            result += string.Format("張數:{0},單價:{1}\n", this.Qty, this.Price);
            result += string.Format("小計:{0}", this.TotalPrice);
            return result;
        }
    }
}