using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystemCSharp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Item obj = new Item();
            obj.ShowDialog();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer obj1 = new Customer();
            obj1.ShowDialog();
        }

        private void reservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reservation obj2 = new Reservation();
            obj2.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User obj3 = new User();
            obj3.ShowDialog();
        }
    }
}
