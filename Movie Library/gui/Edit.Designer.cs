namespace Movie_Library.gui
{
    partial class Edit
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnImg = new System.Windows.Forms.Button();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listCast = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddCast = new System.Windows.Forms.Button();
            this.textCast = new System.Windows.Forms.TextBox();
            this.btnEditCast = new System.Windows.Forms.Button();
            this.btnRemoveCast = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Movie Genre:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Director:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Country:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnImg);
            this.groupBox2.Controls.Add(this.txtYear);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtTime);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtCountry);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDirector);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtGenre);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTitle);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 263);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Movie Information";
            // 
            // btnImg
            // 
            this.btnImg.Image = global::Movie_Library.Properties.Resources.Movie;
            this.btnImg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImg.Location = new System.Drawing.Point(6, 205);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(236, 32);
            this.btnImg.TabIndex = 7;
            this.btnImg.Text = "Select Movie Image";
            this.btnImg.UseVisualStyleBackColor = true;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(95, 166);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(147, 20);
            this.txtYear.TabIndex = 23;
            this.txtYear.Tag = "Movie Year";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(95, 141);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(147, 20);
            this.txtTime.TabIndex = 22;
            this.txtTime.Tag = "Movie Running Time";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(95, 116);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(147, 20);
            this.txtCountry.TabIndex = 21;
            this.txtCountry.Tag = "Movie Country";
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(95, 91);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(147, 20);
            this.txtDirector.TabIndex = 20;
            this.txtDirector.Tag = "Movie Director";
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(95, 66);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(147, 20);
            this.txtGenre.TabIndex = 19;
            this.txtGenre.Tag = "Movie Genre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Running Time:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(95, 41);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(147, 20);
            this.txtTitle.TabIndex = 18;
            this.txtTitle.Tag = "Movie Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Release Year:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listCast
            // 
            this.listCast.FormattingEnabled = true;
            this.listCast.Location = new System.Drawing.Point(126, 11);
            this.listCast.Name = "listCast";
            this.listCast.Size = new System.Drawing.Size(341, 173);
            this.listCast.TabIndex = 15;
            this.listCast.Tag = "List of the casting members";
            this.listCast.SelectedIndexChanged += new System.EventHandler(this.listCast_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listCast);
            this.groupBox1.Controls.Add(this.btnAddCast);
            this.groupBox1.Controls.Add(this.textCast);
            this.groupBox1.Controls.Add(this.btnEditCast);
            this.groupBox1.Controls.Add(this.btnRemoveCast);
            this.groupBox1.Location = new System.Drawing.Point(12, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 191);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Casting Member";
            // 
            // btnAddCast
            // 
            this.btnAddCast.Image = global::Movie_Library.Properties.Resources.AddUser;
            this.btnAddCast.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCast.Location = new System.Drawing.Point(4, 58);
            this.btnAddCast.Name = "btnAddCast";
            this.btnAddCast.Size = new System.Drawing.Size(116, 35);
            this.btnAddCast.TabIndex = 12;
            this.btnAddCast.Text = "Add";
            this.btnAddCast.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCast.UseVisualStyleBackColor = true;
            this.btnAddCast.Click += new System.EventHandler(this.btnAddCast_Click);
            // 
            // textCast
            // 
            this.textCast.Location = new System.Drawing.Point(4, 32);
            this.textCast.Name = "textCast";
            this.textCast.Size = new System.Drawing.Size(116, 20);
            this.textCast.TabIndex = 10;
            // 
            // btnEditCast
            // 
            this.btnEditCast.Image = global::Movie_Library.Properties.Resources.EditUser;
            this.btnEditCast.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditCast.Location = new System.Drawing.Point(4, 140);
            this.btnEditCast.Name = "btnEditCast";
            this.btnEditCast.Size = new System.Drawing.Size(116, 35);
            this.btnEditCast.TabIndex = 14;
            this.btnEditCast.Text = "Edit";
            this.btnEditCast.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditCast.UseVisualStyleBackColor = true;
            this.btnEditCast.Click += new System.EventHandler(this.btnEditCast_Click);
            // 
            // btnRemoveCast
            // 
            this.btnRemoveCast.Image = global::Movie_Library.Properties.Resources.RemoveUser;
            this.btnRemoveCast.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveCast.Location = new System.Drawing.Point(4, 99);
            this.btnRemoveCast.Name = "btnRemoveCast";
            this.btnRemoveCast.Size = new System.Drawing.Size(116, 35);
            this.btnRemoveCast.TabIndex = 13;
            this.btnRemoveCast.Text = "Remove";
            this.btnRemoveCast.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveCast.UseVisualStyleBackColor = true;
            this.btnRemoveCast.Click += new System.EventHandler(this.btnRemoveCast_Click);
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(274, 12);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(213, 263);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 25;
            this.picBox.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::Movie_Library.Properties.Resources.Cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(399, 478);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 35);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Movie_Library.Properties.Resources.AddMovie;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(305, 478);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 35);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 519);
            this.ControlBox = false;
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Edit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddCast;
        private System.Windows.Forms.Button btnEditCast;
        private System.Windows.Forms.Button btnRemoveCast;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listCast;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textCast;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}