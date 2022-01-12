using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demopod
{
    public partial class MainmenuForm : Form
    {
        TicketDataSet.EventLocationOgrDataTable eventLocationOgrRows;

        public MainmenuForm()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            eventLocationOgrRows = eventLocationOgrTableAdapter1.GetData();
            dataGridView1.DataSource = eventLocationOgrRows;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminPanel_Click(object sender, EventArgs e)
        {

        }
    }
}
