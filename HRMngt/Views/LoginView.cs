using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using HRMngt.View;


namespace HRMngt.Views
{
    public partial class LoginView : Form, ILoginView 
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public LoginView()
        {
            InitializeComponent();
            RunEvent;
        }

        public string UserName
        { 
            get
            {
                return txtusername.Text;
            }

            set => throw new NotImplementedException(); 
        }
        public string Password { 
            get
            {
                return txtpassword.Text;
            }
            set => throw new NotImplementedException();
        }
        public event EventHandler Login;
        public event EventHandler LoginEvent;

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text != string.Empty || txtusername.Text != string.Empty)
            {

                cmd = new SqlCommand("select * from users where username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    Template home = new Template();
                    home.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=INSPIRON_14;Initial Catalog=hris;Integrated Security=True");
            cn.Open();
        }
    }
}
