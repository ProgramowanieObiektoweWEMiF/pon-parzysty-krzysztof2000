namespace Server_aleph_2
{
    partial class EditLibrary
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DescriptionBook = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BorrowBook = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AutorBook = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NameBook = new System.Windows.Forms.TextBox();
            this.AddBook = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Remove = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(268, 373);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DescriptionBook);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.BorrowBook);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.AutorBook);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.NameBook);
            this.tabPage1.Controls.Add(this.AddBook);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(260, 347);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dodaj";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DescriptionBook
            // 
            this.DescriptionBook.Location = new System.Drawing.Point(62, 96);
            this.DescriptionBook.Multiline = true;
            this.DescriptionBook.Name = "DescriptionBook";
            this.DescriptionBook.Size = new System.Drawing.Size(160, 84);
            this.DescriptionBook.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Opis: ";
            // 
            // BorrowBook
            // 
            this.BorrowBook.Location = new System.Drawing.Point(62, 70);
            this.BorrowBook.Name = "BorrowBook";
            this.BorrowBook.Size = new System.Drawing.Size(160, 20);
            this.BorrowBook.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dostęp: ";
            // 
            // AutorBook
            // 
            this.AutorBook.Location = new System.Drawing.Point(62, 44);
            this.AutorBook.Name = "AutorBook";
            this.AutorBook.Size = new System.Drawing.Size(160, 20);
            this.AutorBook.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Autor: ";
            // 
            // NameBook
            // 
            this.NameBook.Location = new System.Drawing.Point(62, 18);
            this.NameBook.Name = "NameBook";
            this.NameBook.Size = new System.Drawing.Size(160, 20);
            this.NameBook.TabIndex = 2;
            // 
            // AddBook
            // 
            this.AddBook.Location = new System.Drawing.Point(12, 316);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(75, 23);
            this.AddBook.TabIndex = 1;
            this.AddBook.Text = "Dodaj";
            this.AddBook.UseVisualStyleBackColor = true;
            this.AddBook.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddBook_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nazwa: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Remove);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(260, 347);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Usuń";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(38, 80);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove.TabIndex = 2;
            this.Remove.Text = "Skasuj";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj nazę książki";
            // 
            // EditLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(268, 373);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "EditLibrary";
            this.Text = "EditLibrary";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BorrowBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AutorBook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameBook;
        private System.Windows.Forms.TextBox DescriptionBook;
    }
}