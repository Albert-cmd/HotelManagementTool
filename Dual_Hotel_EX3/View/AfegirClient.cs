using Dual_Hotel_EX3.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dual_Hotel_EX3.View
{
    public partial class AfegirClient : Form
    {

        Client c = new Client();

        public AfegirClient()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void AfegirClientB_Click(object sender, EventArgs e)
        {

            c.Nom = nomInput.Text.ToString();

            Console.WriteLine(c.Nom);

            c = ClientsRepository.InsertClient(c);

            if (c != null) {
                this.Hide();
                this.Close();
            }

        }
    }
}
