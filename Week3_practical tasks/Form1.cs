using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week3_practical_tasks.Classes;

namespace Week3_practical_tasks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string s_Username = "";
            string s_Password = "";

            s_Username = txtUsername.Text;
            s_Password = txtPassword.Text;

            if (s_Username == cls_user.Username && s_Password == cls_user.Password)
            {
                cls_user.Username = s_Username;

                this.Hide();
                frm_menu Form = new frm_menu();
                Form.Show();
            }
            else
            {
                lblError.Text = "Error Incorrect Details!";
                lblError.Visible = true;
                lblError.ForeColor = Color.Red;
            }

        }
    }
}
