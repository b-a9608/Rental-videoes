using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalVideos
{
    public partial class Movies : Form
    {
        Biz biz = new Biz();
        public Movies()
        {
            InitializeComponent();
            MovieList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tabs _tabs = new Tabs();
            _tabs.ShowDialog();
        }
        /// <summary>
        /// This method is to get movies list
        /// </summary>
        private void MovieList()
        {
            DataTable dt = new DataTable();
            dt = biz.getDataTableWithoutParamter("GetMovieList");
            dGWMoviesList.DataSource = dt;

        }
        /// <summary>
        /// This method is to add movies in the screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddMovie_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parameter = new SqlParameter[4];
            parameter[0] = new SqlParameter("@Title", txtBoxTitle.Text);
            parameter[1] = new SqlParameter("@Rental_Cost", txtBoxRentalCost.Text);
            parameter[2] = new SqlParameter("@Genre", txtBoxGenre.Text);
            parameter[3] = new SqlParameter("@Plot", txtBoxPlot.Text);
            biz.geDataTableWithParamter("InsertUpdateMovies", parameter);
            MovieList();
            MessageBox.Show("Movie saved successfully");
        }
        /// <summary>
        /// This method is to update movie in screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpdateMovie_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parameter = new SqlParameter[5];
            parameter[0] = new SqlParameter("@Title", txtBoxTitle.Text);
            parameter[1] = new SqlParameter("@Rental_Cost", txtBoxRentalCost.Text);
            parameter[2] = new SqlParameter("@Genre", txtBoxGenre.Text);
            parameter[3] = new SqlParameter("@Plot", txtBoxPlot.Text);
            parameter[4] = new SqlParameter("@MovieID", txtBoxMovieID.Text);
            biz.geDataTableWithParamter("InsertUpdateMovies", parameter);
            MovieList();
            MessageBox.Show("Movie updated successfully");
        }
        /// <summary>
        /// This is used to delete movie in the screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteMovie_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@movieID", txtBoxMovieID.Text);
            biz.geDataTableWithParamter("DeleteMovies", parameter);
            MovieList();
            MessageBox.Show("Movie deleted successfully");
        }
        /// <summary>
        /// This method is to populate Movie data of specific id in txtbox 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dGWMoviesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dGWMoviesList.Rows[e.RowIndex];
            txtBoxMovieID.Text = row.Cells[0].Value.ToString();
            txtBoxTitle.Text = row.Cells[1].Value.ToString();
            txtBoxGenre.Text = row.Cells[2].Value.ToString();
            txtBoxRentalCost.Text = row.Cells[3].Value.ToString();
            txtBoxPlot.Text = row.Cells[4].Value.ToString();
        }
    }
}
