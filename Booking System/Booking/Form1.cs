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
        public double totalPrice;

        public Form1()
        {
            InitializeComponent();
            tickets = new List<Ticket>();
            UpdateTicketsInfo();
        }

        private void UpdateTicketsInfo()
        {
            infoRichTextBox.Text = string.Empty;
            qtyTextBox.Text = string.Empty;
            price = ticket.normalTicket;
            discount = 1;
            ticketComboBox.SelectedIndex = 0;
            priceTextBox.Text = string.Format("{0}", ticket.normalTicket);
        }

        private void ticketComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkValue();
            priceTextBox.Text = string.Format("{0}", price);
        }

        private void checkValue()
        {
            switch (ticketComboBox.SelectedIndex)
            {
                case 0:
                    discount = 1;
                    price = ticket.Discount;
                    break;

                case 1:
                    discount = student.Discount;
                    price = ticket.Discount;
                    break;

                case 2:
                    discount = kids.Discount;
                    price = ticket.Discount;
                    break;

                case 3:
                    discount = littleKids.Discount;
                    price = ticket.Discount;
                    break;

                case 4:
                    discount = visa.Discount;
                    price = ticket.Discount;
                    break;

                default:
                    discount = 1;
                    price = ticket.Discount;
                    break;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            checkValue();
            ticket = new Ticket(ticketComboBox.SelectedIndex, qtyTextBox.Text, priceTextBox.Text);
            tickets.Add(ticket);
            foreach (Ticket ticket in tickets)
            {
                infoRichTextBox.Text += string.Format("{0}\n", ticket) + infoRichTextBox.Text;
            }
            UpdateTicketsInfo();
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            totalPrice = 0;
            foreach (Ticket ticket in tickets)
            {
                totalPrice += ticket.SumPrice;
            }
            infoRichTextBox.Text = string.Format("總金額為:{0}\r\n", totalPrice) + infoRichTextBox.Text;
        }
    }
}