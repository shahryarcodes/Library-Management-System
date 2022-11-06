using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db_operation dbo = new db_operation("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True");
            dataGridView1.DataSource = dbo.GetData(textBox1.Text);
            dataGridView1.DataSource = dbo.display();
            Form5 obj = new Form5();
            obj.Show();
            this.Hide();
        }
    }
}
