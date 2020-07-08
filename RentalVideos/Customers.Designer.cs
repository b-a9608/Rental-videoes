namespace RentalVideos
{
    partial class Customers
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.txtBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.txtBoxCustID = new System.Windows.Forms.TextBox();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.dGWCustomerList = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonUpdateCustomer = new System.Windows.Forms.Button();
            this.buttonDeleteCustomer = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGWCustomerList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(76, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(391, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(683, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(954, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone";
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(200, 6);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(168, 35);
            this.txtBoxFirstName.TabIndex = 4;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(527, 3);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(146, 35);
            this.txtBoxLastName.TabIndex = 5;
            // 
            // txtBoxPhoneNumber
            // 
            this.txtBoxPhoneNumber.Location = new System.Drawing.Point(1047, 6);
            this.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            this.txtBoxPhoneNumber.Size = new System.Drawing.Size(159, 35);
            this.txtBoxPhoneNumber.TabIndex = 6;
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Location = new System.Drawing.Point(781, 3);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(163, 35);
            this.txtBoxAddress.TabIndex = 7;
            // 
            // txtBoxCustID
            // 
            this.txtBoxCustID.Location = new System.Drawing.Point(13, 6);
            this.txtBoxCustID.Name = "txtBoxCustID";
            this.txtBoxCustID.Size = new System.Drawing.Size(53, 35);
            this.txtBoxCustID.TabIndex = 8;
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAddCustomer.Location = new System.Drawing.Point(12, 53);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(193, 68);
            this.buttonAddCustomer.TabIndex = 9;
            this.buttonAddCustomer.Text = "Add Customer";
            this.buttonAddCustomer.UseVisualStyleBackColor = true;
            this.buttonAddCustomer.Click += new System.EventHandler(this.buttonAddCustomer_Click);
            // 
            // dGWCustomerList
            // 
            this.dGWCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWCustomerList.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dGWCustomerList.Location = new System.Drawing.Point(13, 192);
            this.dGWCustomerList.Name = "dGWCustomerList";
            this.dGWCustomerList.Size = new System.Drawing.Size(1193, 284);
            this.dGWCustomerList.TabIndex = 10;
            this.dGWCustomerList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGWCustomerList_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(8, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 27);
            this.label5.TabIndex = 11;
            this.label5.Text = "Customers List";
            // 
            // buttonUpdateCustomer
            // 
            this.buttonUpdateCustomer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonUpdateCustomer.Location = new System.Drawing.Point(220, 53);
            this.buttonUpdateCustomer.Name = "buttonUpdateCustomer";
            this.buttonUpdateCustomer.Size = new System.Drawing.Size(329, 68);
            this.buttonUpdateCustomer.TabIndex = 12;
            this.buttonUpdateCustomer.Text = "Update Customer";
            this.buttonUpdateCustomer.UseVisualStyleBackColor = true;
            this.buttonUpdateCustomer.Click += new System.EventHandler(this.buttonUpdateCustomer_Click);
            // 
            // buttonDeleteCustomer
            // 
            this.buttonDeleteCustomer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDeleteCustomer.Location = new System.Drawing.Point(576, 53);
            this.buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            this.buttonDeleteCustomer.Size = new System.Drawing.Size(368, 68);
            this.buttonDeleteCustomer.TabIndex = 13;
            this.buttonDeleteCustomer.Text = "Delete Customer";
            this.buttonDeleteCustomer.UseVisualStyleBackColor = true;
            this.buttonDeleteCustomer.Click += new System.EventHandler(this.buttonDeleteCustomer_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Location = new System.Drawing.Point(1125, 138);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(81, 21);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1343, 479);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.buttonDeleteCustomer);
            this.Controls.Add(this.buttonUpdateCustomer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dGWCustomerList);
            this.Controls.Add(this.buttonAddCustomer);
            this.Controls.Add(this.txtBoxCustID);
            this.Controls.Add(this.txtBoxAddress);
            this.Controls.Add(this.txtBoxPhoneNumber);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.txtBoxFirstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Customers";
            this.Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)(this.dGWCustomerList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.TextBox txtBoxPhoneNumber;
        private System.Windows.Forms.TextBox txtBoxAddress;
        private System.Windows.Forms.TextBox txtBoxCustID;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.DataGridView dGWCustomerList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonUpdateCustomer;
        private System.Windows.Forms.Button buttonDeleteCustomer;
        private System.Windows.Forms.Button btnBack;
    }
}