namespace WindowsFormsApplication1
{
    partial class DataMinerForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphPanel = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dispalyLabel = new System.Windows.Forms.Label();
            this.totalItemSoldcheckBox = new System.Windows.Forms.CheckBox();
            this.totalValueCheckBox = new System.Windows.Forms.CheckBox();
            this.uniqueCustomerCheckBox = new System.Windows.Forms.CheckBox();
            this.avgOfItemsCheckBox = new System.Windows.Forms.CheckBox();
            this.invoiceGeneratedCheckBox = new System.Windows.Forms.CheckBox();
            this.avgSpendCheckBox = new System.Windows.Forms.CheckBox();
            this.avgSpndInvoiceCheckBox = new System.Windows.Forms.CheckBox();
            this.GraphDataDisplaytextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inspectButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.searchDataButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.graphPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(918, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.recentToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // recentToolStripMenuItem
            // 
            this.recentToolStripMenuItem.Name = "recentToolStripMenuItem";
            this.recentToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.recentToolStripMenuItem.Text = "Recent";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveAsToolStripMenuItem.Text = "&Save As";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // graphPanel
            // 
            this.graphPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graphPanel.Controls.Add(this.listBox1);
            this.graphPanel.Location = new System.Drawing.Point(410, 82);
            this.graphPanel.Name = "graphPanel";
            this.graphPanel.Size = new System.Drawing.Size(496, 384);
            this.graphPanel.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(32, 137);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(308, 225);
            this.listBox1.TabIndex = 0;
            // 
            // dispalyLabel
            // 
            this.dispalyLabel.AutoSize = true;
            this.dispalyLabel.Location = new System.Drawing.Point(353, 28);
            this.dispalyLabel.Name = "dispalyLabel";
            this.dispalyLabel.Size = new System.Drawing.Size(200, 13);
            this.dispalyLabel.TabIndex = 2;
            this.dispalyLabel.Text = "All Data Shown Is In Per Calender Month";
            // 
            // totalItemSoldcheckBox
            // 
            this.totalItemSoldcheckBox.AutoSize = true;
            this.totalItemSoldcheckBox.Location = new System.Drawing.Point(19, 50);
            this.totalItemSoldcheckBox.Name = "totalItemSoldcheckBox";
            this.totalItemSoldcheckBox.Size = new System.Drawing.Size(97, 17);
            this.totalItemSoldcheckBox.TabIndex = 3;
            this.totalItemSoldcheckBox.Text = "Total Item Sold";
            this.totalItemSoldcheckBox.UseVisualStyleBackColor = true;
            // 
            // totalValueCheckBox
            // 
            this.totalValueCheckBox.AutoSize = true;
            this.totalValueCheckBox.Location = new System.Drawing.Point(127, 50);
            this.totalValueCheckBox.Name = "totalValueCheckBox";
            this.totalValueCheckBox.Size = new System.Drawing.Size(80, 17);
            this.totalValueCheckBox.TabIndex = 4;
            this.totalValueCheckBox.Text = "Total Value";
            this.totalValueCheckBox.UseVisualStyleBackColor = true;
            // 
            // uniqueCustomerCheckBox
            // 
            this.uniqueCustomerCheckBox.AutoSize = true;
            this.uniqueCustomerCheckBox.Location = new System.Drawing.Point(215, 50);
            this.uniqueCustomerCheckBox.Name = "uniqueCustomerCheckBox";
            this.uniqueCustomerCheckBox.Size = new System.Drawing.Size(95, 17);
            this.uniqueCustomerCheckBox.TabIndex = 5;
            this.uniqueCustomerCheckBox.Text = "New Customer";
            this.uniqueCustomerCheckBox.UseVisualStyleBackColor = true;
            // 
            // avgOfItemsCheckBox
            // 
            this.avgOfItemsCheckBox.AutoSize = true;
            this.avgOfItemsCheckBox.Location = new System.Drawing.Point(471, 50);
            this.avgOfItemsCheckBox.Name = "avgOfItemsCheckBox";
            this.avgOfItemsCheckBox.Size = new System.Drawing.Size(164, 17);
            this.avgOfItemsCheckBox.TabIndex = 6;
            this.avgOfItemsCheckBox.Text = "Avg No. Of Items Per Invoice";
            this.avgOfItemsCheckBox.UseVisualStyleBackColor = true;
            // 
            // invoiceGeneratedCheckBox
            // 
            this.invoiceGeneratedCheckBox.AutoSize = true;
            this.invoiceGeneratedCheckBox.Location = new System.Drawing.Point(322, 50);
            this.invoiceGeneratedCheckBox.Name = "invoiceGeneratedCheckBox";
            this.invoiceGeneratedCheckBox.Size = new System.Drawing.Size(146, 17);
            this.invoiceGeneratedCheckBox.TabIndex = 7;
            this.invoiceGeneratedCheckBox.Text = "Total Invoices Generated";
            this.invoiceGeneratedCheckBox.UseVisualStyleBackColor = true;
            this.invoiceGeneratedCheckBox.CheckedChanged += new System.EventHandler(this.invoiceGeneratedCheckBox_CheckedChanged);
            // 
            // avgSpendCheckBox
            // 
            this.avgSpendCheckBox.AutoSize = true;
            this.avgSpendCheckBox.Location = new System.Drawing.Point(634, 50);
            this.avgSpendCheckBox.Name = "avgSpendCheckBox";
            this.avgSpendCheckBox.Size = new System.Drawing.Size(145, 17);
            this.avgSpendCheckBox.TabIndex = 8;
            this.avgSpendCheckBox.Text = "Avg Spend Per Customer";
            this.avgSpendCheckBox.UseVisualStyleBackColor = true;
            // 
            // avgSpndInvoiceCheckBox
            // 
            this.avgSpndInvoiceCheckBox.AutoSize = true;
            this.avgSpndInvoiceCheckBox.Location = new System.Drawing.Point(780, 50);
            this.avgSpndInvoiceCheckBox.Name = "avgSpndInvoiceCheckBox";
            this.avgSpndInvoiceCheckBox.Size = new System.Drawing.Size(136, 17);
            this.avgSpndInvoiceCheckBox.TabIndex = 9;
            this.avgSpndInvoiceCheckBox.Text = "Avg Spend Per Invoice";
            this.avgSpndInvoiceCheckBox.UseVisualStyleBackColor = true;
            // 
            // GraphDataDisplaytextBox
            // 
            this.GraphDataDisplaytextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GraphDataDisplaytextBox.Location = new System.Drawing.Point(410, 472);
            this.GraphDataDisplaytextBox.Multiline = true;
            this.GraphDataDisplaytextBox.Name = "GraphDataDisplaytextBox";
            this.GraphDataDisplaytextBox.Size = new System.Drawing.Size(495, 42);
            this.GraphDataDisplaytextBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 531);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Inspect each customer or invoice";
            // 
            // inspectButton
            // 
            this.inspectButton.Location = new System.Drawing.Point(226, 531);
            this.inspectButton.Name = "inspectButton";
            this.inspectButton.Size = new System.Drawing.Size(75, 23);
            this.inspectButton.TabIndex = 13;
            this.inspectButton.Text = "Inspect";
            this.inspectButton.UseVisualStyleBackColor = true;
            this.inspectButton.Click += new System.EventHandler(this.inspectButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(442, 534);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(100, 20);
            this.SearchTextBox.TabIndex = 14;
            // 
            // searchDataButton
            // 
            this.searchDataButton.Location = new System.Drawing.Point(618, 534);
            this.searchDataButton.Name = "searchDataButton";
            this.searchDataButton.Size = new System.Drawing.Size(75, 23);
            this.searchDataButton.TabIndex = 15;
            this.searchDataButton.Text = "Search Data";
            this.searchDataButton.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(385, 432);
            this.dataGridView1.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(421, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(353, 310);
            this.textBox1.TabIndex = 17;
            // 
            // DataMinerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 562);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchDataButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.inspectButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GraphDataDisplaytextBox);
            this.Controls.Add(this.avgSpendCheckBox);
            this.Controls.Add(this.avgSpndInvoiceCheckBox);
            this.Controls.Add(this.invoiceGeneratedCheckBox);
            this.Controls.Add(this.avgOfItemsCheckBox);
            this.Controls.Add(this.uniqueCustomerCheckBox);
            this.Controls.Add(this.totalValueCheckBox);
            this.Controls.Add(this.totalItemSoldcheckBox);
            this.Controls.Add(this.dispalyLabel);
            this.Controls.Add(this.graphPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DataMinerForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DataMinerForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.graphPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel graphPanel;
        private System.Windows.Forms.Label dispalyLabel;
        private System.Windows.Forms.CheckBox totalItemSoldcheckBox;
        private System.Windows.Forms.CheckBox totalValueCheckBox;
        private System.Windows.Forms.CheckBox uniqueCustomerCheckBox;
        private System.Windows.Forms.CheckBox avgOfItemsCheckBox;
        private System.Windows.Forms.CheckBox invoiceGeneratedCheckBox;
        private System.Windows.Forms.CheckBox avgSpendCheckBox;
        private System.Windows.Forms.CheckBox avgSpndInvoiceCheckBox;
        private System.Windows.Forms.TextBox GraphDataDisplaytextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button inspectButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button searchDataButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

