namespace VideoRentalCopy
{
    partial class Movie
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
            this.title = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.rating = new System.Windows.Forms.TextBox();
            this.AddMovie = new System.Windows.Forms.Button();
            this.gridview = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.copies = new System.Windows.Forms.TextBox();
            this.rentalcost = new System.Windows.Forms.TextBox();
            this.plot = new System.Windows.Forms.TextBox();
            this.genre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.movieid = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.upid = new System.Windows.Forms.TextBox();
            this.upyear = new System.Windows.Forms.TextBox();
            this.uptitle = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.rid = new System.Windows.Forms.TextBox();
            this.iid = new System.Windows.Forms.TextBox();
            this.rcid = new System.Windows.Forms.TextBox();
            this.icid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(197, 261);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(91, 20);
            this.title.TabIndex = 14;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(294, 261);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(83, 20);
            this.year.TabIndex = 13;
            this.year.TextChanged += new System.EventHandler(this.year_TextChanged);
            // 
            // rating
            // 
            this.rating.Location = new System.Drawing.Point(102, 261);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(89, 20);
            this.rating.TabIndex = 12;
            // 
            // AddMovie
            // 
            this.AddMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMovie.Location = new System.Drawing.Point(21, 258);
            this.AddMovie.Name = "AddMovie";
            this.AddMovie.Size = new System.Drawing.Size(75, 23);
            this.AddMovie.TabIndex = 10;
            this.AddMovie.Text = "Add Movie";
            this.AddMovie.UseVisualStyleBackColor = true;
            this.AddMovie.Click += new System.EventHandler(this.AddMovie_Click);
            // 
            // gridview
            // 
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview.Location = new System.Drawing.Point(12, 36);
            this.gridview.Name = "gridview";
            this.gridview.Size = new System.Drawing.Size(776, 216);
            this.gridview.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(567, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Show";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Home
            // 
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.Location = new System.Drawing.Point(697, 7);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(75, 23);
            this.Home.TabIndex = 17;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // copies
            // 
            this.copies.Location = new System.Drawing.Point(471, 261);
            this.copies.Name = "copies";
            this.copies.Size = new System.Drawing.Size(89, 20);
            this.copies.TabIndex = 18;
            // 
            // rentalcost
            // 
            this.rentalcost.Location = new System.Drawing.Point(383, 260);
            this.rentalcost.Name = "rentalcost";
            this.rentalcost.Size = new System.Drawing.Size(82, 20);
            this.rentalcost.TabIndex = 19;
            // 
            // plot
            // 
            this.plot.Location = new System.Drawing.Point(567, 261);
            this.plot.Name = "plot";
            this.plot.Size = new System.Drawing.Size(85, 20);
            this.plot.TabIndex = 20;
            // 
            // genre
            // 
            this.genre.Location = new System.Drawing.Point(658, 261);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(85, 20);
            this.genre.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Delete Movie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // movieid
            // 
            this.movieid.Location = new System.Drawing.Point(128, 302);
            this.movieid.Name = "movieid";
            this.movieid.Size = new System.Drawing.Size(89, 20);
            this.movieid.TabIndex = 23;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(237, 300);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Update Movie";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // upid
            // 
            this.upid.Location = new System.Drawing.Point(354, 300);
            this.upid.Name = "upid";
            this.upid.Size = new System.Drawing.Size(91, 20);
            this.upid.TabIndex = 25;
            // 
            // upyear
            // 
            this.upyear.Location = new System.Drawing.Point(551, 300);
            this.upyear.Name = "upyear";
            this.upyear.Size = new System.Drawing.Size(91, 20);
            this.upyear.TabIndex = 26;
            // 
            // uptitle
            // 
            this.uptitle.Location = new System.Drawing.Point(451, 300);
            this.uptitle.Name = "uptitle";
            this.uptitle.Size = new System.Drawing.Size(91, 20);
            this.uptitle.TabIndex = 27;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(353, 348);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 23);
            this.button4.TabIndex = 28;
            this.button4.Text = "Issue Movie";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(21, 345);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 23);
            this.button5.TabIndex = 29;
            this.button5.Text = "Return Movie";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // rid
            // 
            this.rid.Location = new System.Drawing.Point(128, 348);
            this.rid.Name = "rid";
            this.rid.Size = new System.Drawing.Size(91, 20);
            this.rid.TabIndex = 30;
            // 
            // iid
            // 
            this.iid.Location = new System.Drawing.Point(451, 348);
            this.iid.Name = "iid";
            this.iid.Size = new System.Drawing.Size(91, 20);
            this.iid.TabIndex = 31;
            // 
            // rcid
            // 
            this.rcid.Location = new System.Drawing.Point(237, 348);
            this.rcid.Name = "rcid";
            this.rcid.Size = new System.Drawing.Size(89, 20);
            this.rcid.TabIndex = 32;
            // 
            // icid
            // 
            this.icid.Location = new System.Drawing.Point(551, 347);
            this.icid.Name = "icid";
            this.icid.Size = new System.Drawing.Size(91, 20);
            this.icid.TabIndex = 33;
            // 
            // Movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.icid);
            this.Controls.Add(this.rcid);
            this.Controls.Add(this.iid);
            this.Controls.Add(this.rid);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.uptitle);
            this.Controls.Add(this.upyear);
            this.Controls.Add(this.upid);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.movieid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.plot);
            this.Controls.Add(this.rentalcost);
            this.Controls.Add(this.copies);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gridview);
            this.Controls.Add(this.title);
            this.Controls.Add(this.year);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.AddMovie);
            this.Name = "Movie";
            this.Text = "Movie";
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.TextBox rating;
        private System.Windows.Forms.Button AddMovie;
        private System.Windows.Forms.DataGridView gridview;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.TextBox copies;
        private System.Windows.Forms.TextBox rentalcost;
        private System.Windows.Forms.TextBox plot;
        private System.Windows.Forms.TextBox genre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox movieid;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox upid;
        private System.Windows.Forms.TextBox upyear;
        private System.Windows.Forms.TextBox uptitle;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox rid;
        private System.Windows.Forms.TextBox iid;
        private System.Windows.Forms.TextBox rcid;
        private System.Windows.Forms.TextBox icid;
    }
}