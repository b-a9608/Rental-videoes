namespace RentalVideos
{
    partial class Movies
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxGenre = new System.Windows.Forms.TextBox();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.txtBoxMovieID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxRentalCost = new System.Windows.Forms.TextBox();
            this.txtBoxPlot = new System.Windows.Forms.TextBox();
            this.buttonAddMovie = new System.Windows.Forms.Button();
            this.buttonUpdateMovie = new System.Windows.Forms.Button();
            this.buttonDeleteMovie = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dGWMoviesList = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGWMoviesList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxGenre
            // 
            this.txtBoxGenre.Location = new System.Drawing.Point(553, 11);
            this.txtBoxGenre.Name = "txtBoxGenre";
            this.txtBoxGenre.Size = new System.Drawing.Size(185, 35);
            this.txtBoxGenre.TabIndex = 0;
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Location = new System.Drawing.Point(225, 11);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(185, 35);
            this.txtBoxTitle.TabIndex = 1;
            // 
            // txtBoxMovieID
            // 
            this.txtBoxMovieID.Location = new System.Drawing.Point(13, 11);
            this.txtBoxMovieID.Name = "txtBoxMovieID";
            this.txtBoxMovieID.Size = new System.Drawing.Size(61, 35);
            this.txtBoxMovieID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rental Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Plot";
            // 
            // txtBoxRentalCost
            // 
            this.txtBoxRentalCost.Location = new System.Drawing.Point(225, 59);
            this.txtBoxRentalCost.Name = "txtBoxRentalCost";
            this.txtBoxRentalCost.Size = new System.Drawing.Size(185, 35);
            this.txtBoxRentalCost.TabIndex = 9;
            // 
            // txtBoxPlot
            // 
            this.txtBoxPlot.Location = new System.Drawing.Point(553, 59);
            this.txtBoxPlot.Name = "txtBoxPlot";
            this.txtBoxPlot.Size = new System.Drawing.Size(185, 35);
            this.txtBoxPlot.TabIndex = 10;
            // 
            // buttonAddMovie
            // 
            this.buttonAddMovie.Location = new System.Drawing.Point(798, 8);
            this.buttonAddMovie.Name = "buttonAddMovie";
            this.buttonAddMovie.Size = new System.Drawing.Size(191, 38);
            this.buttonAddMovie.TabIndex = 11;
            this.buttonAddMovie.Text = "Add Movie";
            this.buttonAddMovie.UseVisualStyleBackColor = true;
            this.buttonAddMovie.Click += new System.EventHandler(this.buttonAddMovie_Click);
            // 
            // buttonUpdateMovie
            // 
            this.buttonUpdateMovie.Location = new System.Drawing.Point(798, 59);
            this.buttonUpdateMovie.Name = "buttonUpdateMovie";
            this.buttonUpdateMovie.Size = new System.Drawing.Size(191, 38);
            this.buttonUpdateMovie.TabIndex = 12;
            this.buttonUpdateMovie.Text = "Update Movie";
            this.buttonUpdateMovie.UseVisualStyleBackColor = true;
            this.buttonUpdateMovie.Click += new System.EventHandler(this.buttonUpdateMovie_Click);
            // 
            // buttonDeleteMovie
            // 
            this.buttonDeleteMovie.Location = new System.Drawing.Point(1010, 11);
            this.buttonDeleteMovie.Name = "buttonDeleteMovie";
            this.buttonDeleteMovie.Size = new System.Drawing.Size(192, 38);
            this.buttonDeleteMovie.TabIndex = 13;
            this.buttonDeleteMovie.Text = "Delete Movie";
            this.buttonDeleteMovie.UseVisualStyleBackColor = true;
            this.buttonDeleteMovie.Click += new System.EventHandler(this.buttonDeleteMovie_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 27);
            this.label5.TabIndex = 14;
            this.label5.Text = "Movies List";
            // 
            // dGWMoviesList
            // 
            this.dGWMoviesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWMoviesList.Location = new System.Drawing.Point(22, 155);
            this.dGWMoviesList.Name = "dGWMoviesList";
            this.dGWMoviesList.Size = new System.Drawing.Size(1180, 320);
            this.dGWMoviesList.TabIndex = 15;
            this.dGWMoviesList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGWMoviesList_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1121, 122);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(81, 27);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(454, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 27);
            this.label6.TabIndex = 17;
            this.label6.Text = "Genre";
            // 
            // Movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1214, 487);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dGWMoviesList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonDeleteMovie);
            this.Controls.Add(this.buttonUpdateMovie);
            this.Controls.Add(this.buttonAddMovie);
            this.Controls.Add(this.txtBoxPlot);
            this.Controls.Add(this.txtBoxRentalCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxMovieID);
            this.Controls.Add(this.txtBoxTitle);
            this.Controls.Add(this.txtBoxGenre);
            this.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Movies";
            this.Text = "Movies";
            ((System.ComponentModel.ISupportInitialize)(this.dGWMoviesList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxGenre;
        private System.Windows.Forms.TextBox txtBoxTitle;
        private System.Windows.Forms.TextBox txtBoxMovieID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxRentalCost;
        private System.Windows.Forms.TextBox txtBoxPlot;
        private System.Windows.Forms.Button buttonAddMovie;
        private System.Windows.Forms.Button buttonUpdateMovie;
        private System.Windows.Forms.Button buttonDeleteMovie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dGWMoviesList;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label6;
    }
}