using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalVideos
{
    public partial class Form1 : Form
    {
        Biz businessLogic = new Biz();
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This method is to validate login id and password to enter into the system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parameter = new SqlParameter[2];
            parameter[0] = new SqlParameter("@userid", txtUserName.Text);

            parameter[1] = new SqlParameter("@pwd", txtPassword.Text);
            dt = businessLogic.geDataTableWithParamter("userLogin", parameter);
            if (dt != null && dt.Rows.Count > 0)
            {
                if (Convert.ToInt32(dt.Rows[0][0]) > 0)
                {

                    this.Hide();
                    Tabs _tabs = new Tabs();
                    _tabs.ShowDialog();

                }

            }
            else
            {
                txtUserName.Text = "";
                txtPassword.Text = "";
                MessageBox.Show("Login ID and Password is incorrect.");
            }
        }
    }
}
