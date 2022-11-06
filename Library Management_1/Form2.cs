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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sdetails s1 = new Sdetails(textBox1.Text, textBox2.Text, textBox3.Text, (int.Parse(textBox4.Text)));
            
            MessageBox.Show(s1.firstname + "\n" + s1.lastname + "\n" + s1.departname + "\n" + s1.Sid + "\n");
            SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"insert into s_details (firstname,lastname,department,sid)
            values(@firstname,@lastname,@departname,@sid)", con);
            cmd.Parameters.AddWithValue("@firstname", textBox1.Text);
            cmd.Parameters.AddWithValue("@lastname", textBox2.Text);
            cmd.Parameters.AddWithValue("@departname", textBox3.Text);
            cmd.Parameters.AddWithValue("@sid", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Submitted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form3 obj = new Form3();
            obj.Show();
            this.Hide();

           
        }
    }
}
