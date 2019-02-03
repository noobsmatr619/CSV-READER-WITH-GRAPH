namespace WindowsFormsApplication1
{
    partial class InspectForm
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
            this.InputLCstLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputInvcLlabel = new System.Windows.Forms.Label();
            this.cstIdTextBox = new System.Windows.Forms.TextBox();
            this.invcIdtextBox = new System.Windows.Forms.TextBox();
            this.displayDataRichTextBox = new System.Windows.Forms.RichTextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.searchDataButton = new System.Windows.Forms.Button();
            this.DataSearchTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputLCstLabel
            // 
            this.InputLCstLabel.AutoSize = true;
            this.InputLCstLabel.Location = new System.Drawing.Point(14, 30);
            this.InputLCstLabel.Name = "InputLCstLabel";
            this.InputLCstLabel.Size = new System.Drawing.Size(92, 13);
            this.InputLCstLabel.TabIndex = 0;
            this.InputLCstLabel.Text = "Input Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Or";
            // 
            // InputInvcLlabel
            // 
            this.InputInvcLlabel.AutoSize = true;
            this.InputInvcLlabel.Location = new System.Drawing.Point(196, 30);
            this.InputInvcLlabel.Name = "InputInvcLlabel";
            this.InputInvcLlabel.Size = new System.Drawing.Size(56, 13);
            this.InputInvcLlabel.TabIndex = 2;
            this.InputInvcLlabel.Text = "Invoice ID";
            // 
            // cstIdTextBox
            // 
            this.cstIdTextBox.Location = new System.Drawing.Point(16, 53);
            this.cstIdTextBox.Name = "cstIdTextBox";
            this.cstIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.cstIdTextBox.TabIndex = 3;
            // 
            // invcIdtextBox
            // 
            this.invcIdtextBox.Location = new System.Drawing.Point(199, 53);
            this.invcIdtextBox.Name = "invcIdtextBox";
            this.invcIdtextBox.Size = new System.Drawing.Size(100, 20);
            this.invcIdtextBox.TabIndex = 4;
            // 
            // displayDataRichTextBox
            // 
            this.displayDataRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayDataRichTextBox.Location = new System.Drawing.Point(16, 91);
            this.displayDataRichTextBox.Name = "displayDataRichTextBox";
            this.displayDataRichTextBox.Size = new System.Drawing.Size(464, 294);
            this.displayDataRichTextBox.TabIndex = 5;
            this.displayDataRichTextBox.Text = "";
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(383, 49);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 6;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            // 
            // searchDataButton
            // 
            this.searchDataButton.Location = new System.Drawing.Point(192, 399);
            this.searchDataButton.Name = "searchDataButton";
            this.searchDataButton.Size = new System.Drawing.Size(75, 23);
            this.searchDataButton.TabIndex = 17;
            this.searchDataButton.Text = "Search Data";
            this.searchDataButton.UseVisualStyleBackColor = true;
            // 
            // DataSearchTextBox
            // 
            this.DataSearchTextBox.Location = new System.Drawing.Point(16, 399);
            this.DataSearchTextBox.Name = "DataSearchTextBox";
            this.DataSearchTextBox.Size = new System.Drawing.Size(100, 20);
            this.DataSearchTextBox.TabIndex = 16;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(521, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionToolStripMenuItem.Text = "&Option";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.exportToolStripMenuItem.Text = "&Export";
            // 
            // InspectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(521, 431);
            this.Controls.Add(this.searchDataButton);
            this.Controls.Add(this.DataSearchTextBox);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.displayDataRichTextBox);
            this.Controls.Add(this.invcIdtextBox);
            this.Controls.Add(this.cstIdTextBox);
            this.Controls.Add(this.InputInvcLlabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputLCstLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "InspectForm";
            this.Text = "InspectForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InputLCstLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label InputInvcLlabel;
        private System.Windows.Forms.TextBox cstIdTextBox;
        private System.Windows.Forms.TextBox invcIdtextBox;
        private System.Windows.Forms.RichTextBox displayDataRichTextBox;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Button searchDataButton;
        private System.Windows.Forms.TextBox DataSearchTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
    }
}