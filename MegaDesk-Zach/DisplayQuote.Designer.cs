namespace MegaDesk_Zach
{
    partial class DisplayQuote
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
            label1 = new Label();
            nameLbl = new Label();
            label3 = new Label();
            totalLbl = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(139, 162);
            label1.Name = "label1";
            label1.Size = new Size(104, 41);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Font = new Font("Segoe UI", 15F);
            nameLbl.ForeColor = SystemColors.HighlightText;
            nameLbl.Location = new Point(373, 162);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(144, 41);
            nameLbl.TabIndex = 1;
            nameLbl.Text = "John Doe";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = SystemColors.HighlightText;
            label3.Location = new Point(139, 218);
            label3.Name = "label3";
            label3.Size = new Size(188, 41);
            label3.TabIndex = 2;
            label3.Text = "Quote Total: ";
            // 
            // totalLbl
            // 
            totalLbl.AutoSize = true;
            totalLbl.Font = new Font("Segoe UI", 15F);
            totalLbl.ForeColor = SystemColors.HighlightText;
            totalLbl.Location = new Point(373, 218);
            totalLbl.Name = "totalLbl";
            totalLbl.Size = new Size(55, 41);
            totalLbl.TabIndex = 3;
            totalLbl.Text = "$...";
            // 
            // DisplayQuote
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(800, 450);
            Controls.Add(totalLbl);
            Controls.Add(label3);
            Controls.Add(nameLbl);
            Controls.Add(label1);
            Name = "DisplayQuote";
            Text = "DisplayQuote";
            Load += DisplayQuote_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label nameLbl;
        private Label label3;
        private Label totalLbl;
    }
}