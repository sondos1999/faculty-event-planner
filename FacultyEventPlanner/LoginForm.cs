using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace FacultyEventPlanner
{
    public partial class LoginForm : Form
    {
        private static int SUCCESS=1;
        private static int WRONG_PASS=0;
        private static int WRONG_USERNAME=-1;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            OracleCommand checkPass = new OracleCommand();
            checkPass.Connection = OracleHelper.getConnection();
            checkPass.CommandType = CommandType.StoredProcedure;
            checkPass.CommandText = "Check_Password";
            checkPass.Parameters.Add("usr", userNameText.Text);
            checkPass.Parameters.Add("p", passwordTxt.Text);
            checkPass.Parameters.Add("ret", OracleDbType.Int32, ParameterDirection.Output);
            checkPass.ExecuteNonQuery();
            int ret = int.Parse(checkPass.Parameters["ret"].Value.ToString());
            if (ret == LoginForm.WRONG_PASS)
            {
                MessageBox.Show("Wrong Password!", "Warning");
                passwordTxt.Clear();
            }else if (ret == LoginForm.WRONG_USERNAME)
            {
                MessageBox.Show("Username not found!", "Warning");
                passwordTxt.Clear();
                userNameText.Clear();
            }else if (ret == LoginForm.SUCCESS)
            {
                MessageBox.Show("Login successfull!", "Message");
                OracleHelper.LoggedIn.user_name = userNameText.Text;
                this.Hide();
                UserHome uh = new UserHome();
                uh.Closed += (s, args) => this.Close();
                uh.Show();
            }
        }
    }
}
