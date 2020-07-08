namespace RentalVideos
{
    partial class Tabs
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
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnRentalMovies = new System.Windows.Forms.Button();
            this.btnMovies = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustomers
            // 
            this.btnCustomers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnCustomers.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.Location = new System.Drawing.Point(475, 84);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(315, 121);
            this.btnCustomers.TabIndex = 0;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnRentalMovies
            // 
            this.btnRentalMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentalMovies.Location = new System.Drawing.Point(475, 346);
            this.btnRentalMovies.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnRentalMovies.Name = "btnRentalMovies";
            this.btnRentalMovies.Size = new System.Drawing.Size(315, 121);
            this.btnRentalMovies.TabIndex = 1;
            this.btnRentalMovies.Text = "Rental Movies";
            this.btnRentalMovies.UseVisualStyleBackColor = true;
            this.btnRentalMovies.Click += new System.EventHandler(this.btnRentalMovies_Click);
            // 
            // btnMovies
            // 
            this.btnMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovies.Location = new System.Drawing.Point(475, 215);
            this.btnMovies.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnMovies.Name = "btnMovies";
            this.btnMovies.Size = new System.Drawing.Size(315, 121);
            this.btnMovies.TabIndex = 2;
            this.btnMovies.Text = "Movies";
            this.btnMovies.UseVisualStyleBackColor = true;
            this.btnMovies.Click += new System.EventHandler(this.btnMovies_Click);
            // 
            // Tabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1333, 727);
            this.Controls.Add(this.btnMovies);
            this.Controls.Add(this.btnRentalMovies);
            this.Controls.Add(this.btnCustomers);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Tabs";
            this.Text = "Tabs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnRentalMovies;
        private System.Windows.Forms.Button btnMovies;
    }
}