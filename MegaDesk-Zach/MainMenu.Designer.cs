namespace MegaDesk_Zach
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addQuote = new Button();
            viewAllQuotes = new Button();
            searchQuote = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // addQuote
            // 
            addQuote.BackColor = SystemColors.GrayText;
            addQuote.Font = new Font("Segoe UI", 15F);
            addQuote.ForeColor = SystemColors.ButtonHighlight;
            addQuote.Location = new Point(52, 42);
            addQuote.Name = "addQuote";
            addQuote.Size = new Size(254, 82);
            addQuote.TabIndex = 0;
            addQuote.Text = "Add Quote";
            addQuote.UseVisualStyleBackColor = false;
            addQuote.Click += button1_Click;
            // 
            // viewAllQuotes
            // 
            viewAllQuotes.BackColor = SystemColors.GrayText;
            viewAllQuotes.Font = new Font("Segoe UI", 15F);
            viewAllQuotes.ForeColor = SystemColors.ButtonHighlight;
            viewAllQuotes.Location = new Point(52, 180);
            viewAllQuotes.Name = "viewAllQuotes";
            viewAllQuotes.Size = new Size(254, 82);
            viewAllQuotes.TabIndex = 1;
            viewAllQuotes.Text = "View All Quotes";
            viewAllQuotes.UseVisualStyleBackColor = false;
            viewAllQuotes.Click += button1_Click_1;
            // 
            // searchQuote
            // 
            searchQuote.BackColor = SystemColors.GrayText;
            searchQuote.Font = new Font("Segoe UI", 15F);
            searchQuote.ForeColor = SystemColors.ButtonHighlight;
            searchQuote.Location = new Point(52, 316);
            searchQuote.Name = "searchQuote";
            searchQuote.Size = new Size(254, 82);
            searchQuote.TabIndex = 2;
            searchQuote.Text = "Search Quote";
            searchQuote.UseVisualStyleBackColor = false;
            searchQuote.Click += button2_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.GrayText;
            btnExit.Font = new Font("Segoe UI", 15F);
            btnExit.ForeColor = SystemColors.ButtonHighlight;
            btnExit.Location = new Point(631, 316);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(118, 82);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += button3_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(searchQuote);
            Controls.Add(viewAllQuotes);
            Controls.Add(addQuote);
            Name = "MainMenu";
            Text = "MainMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button addQuote;
        private Button viewAllQuotes;
        private Button searchQuote;
        private Button btnExit;
    }
}
