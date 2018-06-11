namespace Server_aleph_2
{
    partial class window_server
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(window_server));
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonKlient = new System.Windows.Forms.Button();
            this.clearLog = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.loadBooks = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.setAleph = new System.Windows.Forms.TabPage();
            this.newBook = new System.Windows.Forms.Button();
            this.setLibrary = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameBookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whoWroteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.setAleph.SuspendLayout();
            this.setLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(194, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(54, 31);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            655535,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            777,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PORT:";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 153);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(312, 238);
            this.listBox1.TabIndex = 4;
            // 
            // buttonKlient
            // 
            this.buttonKlient.Enabled = false;
            this.buttonKlient.Location = new System.Drawing.Point(194, 89);
            this.buttonKlient.Name = "buttonKlient";
            this.buttonKlient.Size = new System.Drawing.Size(75, 23);
            this.buttonKlient.TabIndex = 5;
            this.buttonKlient.Text = "KLIENCI";
            this.buttonKlient.UseVisualStyleBackColor = true;
            this.buttonKlient.Click += new System.EventHandler(this.buttonKlient_Click);
            // 
            // clearLog
            // 
            this.clearLog.Location = new System.Drawing.Point(194, 118);
            this.clearLog.Name = "clearLog";
            this.clearLog.Size = new System.Drawing.Size(75, 23);
            this.clearLog.TabIndex = 6;
            this.clearLog.Text = "Wyczyść";
            this.clearLog.UseVisualStyleBackColor = true;
            this.clearLog.Click += new System.EventHandler(this.clearLog_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(194, 60);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 7;
            this.buttonStop.Text = "STOP";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // loadBooks
            // 
            this.loadBooks.Location = new System.Drawing.Point(86, 79);
            this.loadBooks.Name = "loadBooks";
            this.loadBooks.Size = new System.Drawing.Size(88, 62);
            this.loadBooks.TabIndex = 8;
            this.loadBooks.Text = "Wczytaj\r\nBiblioteke";
            this.loadBooks.UseVisualStyleBackColor = true;
            this.loadBooks.Click += new System.EventHandler(this.LoadLibrary);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.setAleph);
            this.tabControl1.Controls.Add(this.setLibrary);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(326, 420);
            this.tabControl1.TabIndex = 9;
            // 
            // setAleph
            // 
            this.setAleph.Controls.Add(this.newBook);
            this.setAleph.Controls.Add(this.listBox1);
            this.setAleph.Controls.Add(this.clearLog);
            this.setAleph.Controls.Add(this.loadBooks);
            this.setAleph.Controls.Add(this.buttonKlient);
            this.setAleph.Controls.Add(this.label1);
            this.setAleph.Controls.Add(this.buttonStop);
            this.setAleph.Controls.Add(this.numericUpDown1);
            this.setAleph.Controls.Add(this.button1);
            this.setAleph.Location = new System.Drawing.Point(4, 22);
            this.setAleph.Name = "setAleph";
            this.setAleph.Padding = new System.Windows.Forms.Padding(3);
            this.setAleph.Size = new System.Drawing.Size(318, 394);
            this.setAleph.TabIndex = 0;
            this.setAleph.Text = "Ustawienia_aleph";
            this.setAleph.UseVisualStyleBackColor = true;
            // 
            // newBook
            // 
            this.newBook.Enabled = false;
            this.newBook.Location = new System.Drawing.Point(3, 79);
            this.newBook.Name = "newBook";
            this.newBook.Size = new System.Drawing.Size(75, 62);
            this.newBook.TabIndex = 9;
            this.newBook.Text = "Edytuj\r\nBiblioteke";
            this.newBook.UseVisualStyleBackColor = true;
            this.newBook.Click += new System.EventHandler(this.newBook_Click);
            // 
            // setLibrary
            // 
            this.setLibrary.Controls.Add(this.dataGridView1);
            this.setLibrary.Location = new System.Drawing.Point(4, 22);
            this.setLibrary.Name = "setLibrary";
            this.setLibrary.Padding = new System.Windows.Forms.Padding(3);
            this.setLibrary.Size = new System.Drawing.Size(318, 394);
            this.setLibrary.TabIndex = 1;
            this.setLibrary.Text = "Biblioteka";
            this.setLibrary.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameBookDataGridViewTextBoxColumn,
            this.whoWroteDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.borrowDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(312, 388);
            this.dataGridView1.TabIndex = 1;
            // 
            // nameBookDataGridViewTextBoxColumn
            // 
            this.nameBookDataGridViewTextBoxColumn.DataPropertyName = "NameBook";
            this.nameBookDataGridViewTextBoxColumn.HeaderText = "NameBook";
            this.nameBookDataGridViewTextBoxColumn.Name = "nameBookDataGridViewTextBoxColumn";
            this.nameBookDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // whoWroteDataGridViewTextBoxColumn
            // 
            this.whoWroteDataGridViewTextBoxColumn.DataPropertyName = "WhoWrote";
            this.whoWroteDataGridViewTextBoxColumn.HeaderText = "WhoWrote";
            this.whoWroteDataGridViewTextBoxColumn.Name = "whoWroteDataGridViewTextBoxColumn";
            this.whoWroteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // borrowDataGridViewTextBoxColumn
            // 
            this.borrowDataGridViewTextBoxColumn.DataPropertyName = "Borrow";
            this.borrowDataGridViewTextBoxColumn.HeaderText = "Borrow";
            this.borrowDataGridViewTextBoxColumn.Name = "borrowDataGridViewTextBoxColumn";
            this.borrowDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(Server_aleph_2.Book);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // window_server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(326, 420);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximizeBox = false;
            this.Name = "window_server";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Window_server_ultra_aleph_2.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.window_server_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.setAleph.ResumeLayout(false);
            this.setAleph.PerformLayout();
            this.setLibrary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonKlient;
        private System.Windows.Forms.Button clearLog;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button loadBooks;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage setAleph;
        private System.Windows.Forms.TabPage setLibrary;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameBookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn whoWroteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button newBook;
        public System.Windows.Forms.BindingSource bookBindingSource;
    }
}

