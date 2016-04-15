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

        public Form1()
        {
            InitializeComponent();
            tickets = new List<Ticket>();
            //priceTextBox.Text = string.Format("{0}", 320);
            ticketComboBox.SelectedIndex = 0;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Ticket ticket = null;
            if (ticketComboBox.SelectedIndex == 0)
            {
                ticket = new Ticket(ticketComboBox.Text, numberOfPeopleTextBox.Text, priceTextBox.Text);
            }
            else if (ticketComboBox.SelectedIndex == 1)
            {
                ticket = new Student(ticketComboBox.Text, numberOfPeopleTextBox.Text, priceTextBox.Text);
            }
            else if (ticketComboBox.SelectedIndex == 2)
            {
                ticket = new Kids(ticketComboBox.Text, numberOfPeopleTextBox.Text, priceTextBox.Text);
            }
            else if (ticketComboBox.SelectedIndex == 3)
            {
                ticket = new LittleKids(ticketComboBox.Text, numberOfPeopleTextBox.Text, priceTextBox.Text);
            }
            else
            {
                ticket = new Visa(ticketComboBox.Text, numberOfPeopleTextBox.Text, priceTextBox.Text);
            }

            tickets.Add(ticket);
            UpdateTicketsInfo();
        }

        private void UpdateTicketsInfo()
        {
            infoRichTextBox.Text = string.Empty;
            numberOfPeopleTextBox.Text = string.Empty;
            foreach (Ticket ticket in tickets)
            {
                infoRichTextBox.Text += string.Format("{0}\n", ticket);
            }
        }

        private void ticketComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //numberOfPeopleLabel.Visible = ticketComboBox.SelectedIndex == 1;
            //numberOfPeopleTextBox.Visible = ticketComboBox.SelectedIndex == 1;
            //    numberOfPeopleLabel.Visible = ticketComboBox.SelectedIndex == 2;
            //    numberOfPeopleTextBox.Visible = ticketComboBox.SelectedIndex == 2;
            //    numberOfPeopleLabel.Visible = ticketComboBox.SelectedIndex == 3;
            //    numberOfPeopleTextBox.Visible = ticketComboBox.SelectedIndex == 3;
            //    numberOfPeopleLabel.Visible = ticketComboBox.SelectedIndex == 4;
            //    numberOfPeopleTextBox.Visible = ticketComboBox.SelectedIndex == 4;
        }
    }
}