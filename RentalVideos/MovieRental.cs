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
    public partial class MovieRental : Form
    {
        Biz bal = new Biz();
        public MovieRental()
        {
            InitializeComponent();
            CustomerList();
            MovieList();
            RentalList();
        }
        /// <summary>
        ///  This is used to show customer list
        /// </summary>
        private void CustomerList()
        {
            DataTable dt = new DataTable();
            dt = bal.getDataTableWithoutParamter("GetCustomerList");
            dGWCustomerList.DataSource = dt;

        }
        /// <summary>
        /// this is used to show Movies List
        /// </summary>
        private void MovieList()
        {
            DataTable dt = new DataTable();
            dt = bal.getDataTableWithoutParamter("GetMovieList");
            dGWMovieList.DataSource = dt;

        }
        /// <summary>
        /// This is used to show rental movies list
        /// </summary>
        private void RentalList()
        {
            DataTable dt = new DataTable();
            dt = bal.getDataTableWithoutParamter("GetRentalList");
            dgWMovieRentalList.DataSource = dt;

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tabs _tabs = new Tabs();
            _tabs.ShowDialog();
        }
        /// <summary>
        /// This is used to issue movie to customer accoring to demand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            SqlParameter[] parameter = new SqlParameter[2];
            parameter[0] = new SqlParameter("@customerID", txtCustID.Text);
            parameter[1] = new SqlParameter("@movieID", txtBoxMovieID.Text);
            bal.geDataTableWithParamter("InsertRentalIssueMovie", parameter);
            RentalList();
            MessageBox.Show("Movie rented to the customer");
        }
        /// <summary>
        /// This is used to maintain returned date of movie in list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@rentalID", txtBoxRentalID.Text);
            bal.geDataTableWithParamter("UpdateRentalReturnMovie", parameter);
            RentalList();
            MessageBox.Show("Movie returned by the customer");
        }
        /// <summary>
        /// This is used to populate rental movie record in txtbox to issue or return
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgWMovieRentalList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dgWMovieRentalList.Rows[e.RowIndex];
                //populate the txtbox from specific value of the coordinates of column and row.
                txtBoxRentalID.Text = row.Cells[0].Value.ToString();
                txtBoxFName.Text = row.Cells[1].Value.ToString();
                txtBoxLName.Text = row.Cells[2].Value.ToString();
                txtBoxRentalCost.Text = row.Cells[5].Value.ToString();
            }
        }
        /// <summary>
        /// This is used to populate customer details to whom movie is issued
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dGWCustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dGWCustomerList.Rows[e.RowIndex];
            txtCustID.Text = row.Cells[0].Value.ToString();
            txtBoxFName.Text = row.Cells[1].Value.ToString();
            txtBoxLName.Text = row.Cells[2].Value.ToString();
        }
        /// <summary>
        /// This is used to populate movie details which is to be issued to customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dGWMovieList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dGWMovieList.Rows[e.RowIndex];
            txtBoxMovieID.Text = row.Cells[0].Value.ToString();
            txtBoxTitle.Text = row.Cells[1].Value.ToString();
            txtBoxGenre.Text = row.Cells[2].Value.ToString();
            txtBoxRentalCost.Text = row.Cells[3].Value.ToString();
            txtBoxPlot.Text = row.Cells[4].Value.ToString();
        }
        /// <summary>
        /// This is used to show all rented List in groupbox radio button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonAllRented_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@rentalType", "A");
            dt = bal.geDataTableWithParamter("GetMoviesRentalList", sp);
            dgWMovieRentalList.DataSource = dt;
        }
        /// <summary>
        /// This is used to show out rented List in groupbox radio button click which is not returned yet bu customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonOutRented_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@rentalType", "O");
            dt = bal.geDataTableWithParamter("GetMoviesRentalList", sp);
            dgWMovieRentalList.DataSource = dt;
        }
    }
}
