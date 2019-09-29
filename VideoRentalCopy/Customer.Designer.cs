namespace VideoRentalCopy
{
    partial class Customer
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
            this.button1 = new System.Windows.Forms.Button();
            this.gridview = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.address = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.TextBox();
            this.AddMovie = new System.Windows.Forms.Button();
            this.ufname = new System.Windows.Forms.TextBox();
            this.ualname = new System.Windows.Forms.TextBox();
            this.ucid = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.custid = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(700, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridview
            // 
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview.Location = new System.Drawing.Point(12, 30);
            this.gridview.Name = "gridview";
            this.gridview.Size = new System.Drawing.Size(791, 200);
            this.gridview.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(605, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Show";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(311, 252);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(82, 20);
            this.address.TabIndex = 27;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(399, 252);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(89, 20);
            this.phone.TabIndex = 26;
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(125, 251);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(91, 20);
            this.fname.TabIndex = 25;
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(222, 252);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(83, 20);
            this.lname.TabIndex = 24;
            // 
            // AddMovie
            // 
            this.AddMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMovie.Location = new System.Drawing.Point(12, 249);
            this.AddMovie.Name = "AddMovie";
            this.AddMovie.Size = new System.Drawing.Size(98, 23);
            this.AddMovie.TabIndex = 22;
            this.AddMovie.Text = "Add Customer";
            this.AddMovie.UseVisualStyleBackColor = true;
            this.AddMovie.Click += new System.EventHandler(this.AddMovie_Click);
            // 
            // ufname
            // 
            this.ufname.Location = new System.Drawing.Point(386, 291);
            this.ufname.Name = "ufname";
            this.ufname.Size = new System.Drawing.Size(91, 20);
            this.ufname.TabIndex = 33;
            // 
            // ualname
            // 
            this.ualname.Location = new System.Drawing.Point(483, 291);
            this.ualname.Name = "ualname";
            this.ualname.Size = new System.Drawing.Size(91, 20);
            this.ualname.TabIndex = 32;
            // 
            // ucid
            // 
            this.ucid.Location = new System.Drawing.Point(332, 291);
            this.ucid.Name = "ucid";
            this.ucid.Size = new System.Drawing.Size(37, 20);
            this.ucid.TabIndex = 31;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(201, 288);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 23);
            this.button3.TabIndex = 30;
            this.button3.Text = "Update Customer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // custid
            // 
            this.custid.Location = new System.Drawing.Point(136, 290);
            this.custid.Name = "custid";
            this.custid.Size = new System.Drawing.Size(38, 20);
            this.custid.TabIndex = 29;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(18, 288);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 23);
            this.button4.TabIndex = 28;
            this.button4.Text = "Delete Customer";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ufname);
            this.Controls.Add(this.ualname);
            this.Controls.Add(this.ucid);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.custid);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.address);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.AddMovie);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gridview);
            this.Controls.Add(this.button1);
            this.Name = "Customer";
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gridview;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.Button AddMovie;
        private System.Windows.Forms.TextBox ufname;
        private System.Windows.Forms.TextBox ualname;
        private System.Windows.Forms.TextBox ucid;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox custid;
        private System.Windows.Forms.Button button4;
    }
}