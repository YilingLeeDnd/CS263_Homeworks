using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketLibrary;

namespace Booking
{
    public partial class Form1 : Form
    {
        private List<Ticket> tickets;
        public Student student = new Student();
        public Kids kids = new Kids();
        public LittleKids littleKids = new LittleKids();
        public Visa visa = new Visa();
        private Ticket ticket = new Ticket();
        public double discount;
        public double price;
        public double sumPrice;

        public Form1()
        {
            InitializeComponent();
            tickets = new List<Ticket>();
            UpdateTicketInfo();
        }

        private void ticketComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkValue();
            priceTextBox.Text = string.Format("{0}", price);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            checkValue();
            ticket = new Ticket(ticketComboBox.SelectedIndex, qtyComboBox.SelectedIndex + 1, discount);
            tickets.Add(ticket);
            UpdateTicketInfo();
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            foreach (Ticket t in tickets)
            {
                sumPrice += t.TotalPrice;
            }
            infoRichTextBox.Text = string.Format("總金額為:{0}\n", sumPrice) + infoRichTextBox.Text;
        }

        private void UpdateTicketInfo()
        {
            infoRichTextBox.Text = string.Empty;
            discount = 1;
            ticketComboBox.SelectedIndex = 0;
            sumPrice = 0;
            priceTextBox.Text = string.Format("{0}", ticket.NormalTicket);
            foreach (Ticket t in tickets)
            {
                infoRichTextBox.Text = string.Format("{0}\n", t) + infoRichTextBox.Text;
            }
        }

        private void checkValue()
        {
            switch (ticketComboBox.SelectedIndex)
            {
                case 0:
                    discount = 1;
                    price = ticket.NormalTicket * discount;
                    break;

                case 1:
                    discount = student.Calculate;
                    price = ticket.NormalTicket * discount;
                    break;

                case 2:
                    discount = kids.Calculate;
                    price = ticket.NormalTicket * discount;
                    break;

                case 3:
                    discount = littleKids.Calculate;
                    price = ticket.NormalTicket * discount;
                    break;

                case 4:
                    discount = visa.Calculate;
                    price = ticket.NormalTicket * discount;
                    break;

                default:
                    discount = 1;
                    price = ticket.NormalTicket * discount;
                    break;
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            tickets = new List<Ticket>();
            UpdateTicketInfo();
        }
    }
}