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
    public partial class Customers : Form
    {
        Biz biz = new Biz();
        public Customers()
        {
            InitializeComponent();
            CustomerList();
        }

        /// <summary>
        ///  This is used to show customer list
        /// </summary>
        private void CustomerList()
        {
            DataTable dt = new DataTable();
            dt = biz.getDataTableWithoutParamter("GetCustomerList");
            dGWCustomerList.DataSource = dt;

        }
        /// <summary>
        ///  go to back page 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tabs _tabs = new Tabs();
            _tabs.ShowDialog();
        }
        /// <summary>
        /// This method is to add customer details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parameter = new SqlParameter[4];
            parameter[0] = new SqlParameter("@FirstName", txtBoxFirstName.Text);
            parameter[1] = new SqlParameter("@LastName", txtBoxLastName.Text);
            parameter[2] = new SqlParameter("@Address", txtBoxAddress.Text);
            parameter[3] = new SqlParameter("@Phone", txtBoxPhoneNumber.Text);
            dt = biz.geDataTableWithParamter("InsertUpdateCustomer", parameter);
            CustomerList();
            MessageBox.Show("Customer updated successfully");
        }
        /// <summary>
        /// This method is to update customer details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpdateCustomer_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parameter = new SqlParameter[5];
            parameter[0] = new SqlParameter("@FirstName", txtBoxFirstName.Text);
            parameter[1] = new SqlParameter("@LastName", txtBoxLastName.Text);
            parameter[2] = new SqlParameter("@Address", txtBoxAddress.Text);
            parameter[3] = new SqlParameter("@Phone", txtBoxPhoneNumber.Text);
            parameter[4] = new SqlParameter("@CustID", txtBoxCustID.Text);
            biz.geDataTableWithParamter("InsertUpdateCustomer", parameter);
            txtBoxFirstName.Text = "";
            txtBoxLastName.Text = "";
            txtBoxAddress.Text = "";
            txtBoxPhoneNumber.Text = "";
            txtBoxCustID.Text = "";
            CustomerList();
            MessageBox.Show("Customer updated successfully");
        }
        /// <summary>
        /// This is method is to delete customer details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@customerID", txtBoxCustID.Text);
            biz.geDataTableWithParamter("DeleteCustomers", parameter);
            CustomerList();
            MessageBox.Show("Customer deleted successfully");
        }
        /// <summary>
        /// This method is to Populate txtbox with data to update custoer or delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dGWCustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dGWCustomerList.Rows[e.RowIndex];
                txtBoxCustID.Text = row.Cells[0].Value.ToString();
                txtBoxFirstName.Text = row.Cells[1].Value.ToString();
                txtBoxLastName.Text = row.Cells[2].Value.ToString();
                txtBoxAddress.Text = row.Cells[3].Value.ToString();
                txtBoxPhoneNumber.Text = row.Cells[4].Value.ToString();
            }

        }
    }
}
