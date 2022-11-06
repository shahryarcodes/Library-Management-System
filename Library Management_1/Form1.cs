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
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show(textBox1.Text, textBox2.Text);
            MessageBox.Show(l1.email + "\n" + l1.pas + "\n");
            SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"insert into login_library (email,password)
            values(@email,@pas)", con);
            cmd.Parameters.AddWithValue("@email", textBox1.Text);
            cmd.Parameters.AddWithValue("@pas", textBox2.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Login success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
            

        }

    } 
}
    




       
    

