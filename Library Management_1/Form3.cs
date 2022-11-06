using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_Management_1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bdetails b1 = new Bdetails();
            b1.Print(int.Parse(textBox1.Text), textBox2.Text);
            b1.Method(textBox3.Text, (int.Parse(textBox4.Text)));
            MessageBox.Show(b1.bookid + "\n" + b1.booktitl + "\n" + b1.bookauthr + "\n" + b1.Bookprc + "\n");
            SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"insert into b_details (bid,booktitle,bookauthor,bookprice)
            values(@bookid,@booktitl,@bookauthr,@bookprc)", con);
            cmd.Parameters.AddWithValue("@bookid", textBox1.Text);
            cmd.Parameters.AddWithValue("@booktitl", textBox2.Text);
            cmd.Parameters.AddWithValue("@bookauthr", textBox3.Text);
            cmd.Parameters.AddWithValue("@bookprc", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Added", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form4 obj = new Form4();
            obj.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           


        }
    }
}
