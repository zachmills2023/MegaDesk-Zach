namespace MegaDesk_Zach
{
    partial class AddQuote
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
            widthInput = new NumericUpDown();
            depthInput = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            drawersInput = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            nameInput = new TextBox();
            desktopInput = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            rushOrderInput = new ComboBox();
            submitInputs = new Button();
            ((System.ComponentModel.ISupportInitialize)widthInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)depthInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)drawersInput).BeginInit();
            SuspendLayout();
            // 
            // widthInput
            // 
            widthInput.Cursor = Cursors.IBeam;
            widthInput.Location = new Point(211, 79);
            widthInput.Name = "widthInput";
            widthInput.Size = new Size(180, 31);
            widthInput.TabIndex = 0;
            widthInput.Value = new decimal(new int[] { 24, 0, 0, 0 });
            widthInput.ValueChanged += widthInput_ValueChanged;
            // 
            // depthInput
            // 
            depthInput.Cursor = Cursors.IBeam;
            depthInput.Location = new Point(211, 160);
            depthInput.Name = "depthInput";
            depthInput.Size = new Size(180, 31);
            depthInput.TabIndex = 1;
            depthInput.Value = new decimal(new int[] { 12, 0, 0, 0 });
            depthInput.ValueChanged += depthInput_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(28, 79);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 2;
            label1.Text = "Width:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.HighlightText;
            label2.Location = new Point(28, 160);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 3;
            label2.Text = "Depth: ";
            // 
            // drawersInput
            // 
            drawersInput.Cursor = Cursors.IBeam;
            drawersInput.Location = new Point(211, 238);
            drawersInput.Name = "drawersInput";
            drawersInput.Size = new Size(180, 31);
            drawersInput.TabIndex = 4;
            drawersInput.ValueChanged += drawersInput_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.HighlightText;
            label3.Location = new Point(28, 244);
            label3.Name = "label3";
            label3.Size = new Size(177, 25);
            label3.TabIndex = 5;
            label3.Text = "Number of Drawers: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.HighlightText;
            label4.Location = new Point(28, 18);
            label4.Name = "label4";
            label4.Size = new Size(145, 25);
            label4.TabIndex = 6;
            label4.Text = "Customer Name:";
            // 
            // nameInput
            // 
            nameInput.Cursor = Cursors.IBeam;
            nameInput.Location = new Point(211, 12);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(180, 31);
            nameInput.TabIndex = 7;
            nameInput.Text = "-Client Name Here-";
            nameInput.TextChanged += nameInput_TextChanged;
            // 
            // desktopInput
            // 
            desktopInput.Cursor = Cursors.IBeam;
            desktopInput.FormattingEnabled = true;
            desktopInput.Items.AddRange(new object[] { "oak", "laminate", "pine", "rosewood", "veneer" });
            desktopInput.Location = new Point(211, 311);
            desktopInput.Name = "desktopInput";
            desktopInput.Size = new Size(180, 33);
            desktopInput.TabIndex = 8;
            desktopInput.SelectedIndexChanged += desktopInput_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.HighlightText;
            label5.Location = new Point(28, 319);
            label5.Name = "label5";
            label5.Size = new Size(156, 25);
            label5.TabIndex = 9;
            label5.Text = "Desktop Material: ";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.HighlightText;
            label6.Location = new Point(28, 392);
            label6.Name = "label6";
            label6.Size = new Size(115, 25);
            label6.TabIndex = 10;
            label6.Text = "Delivered by:";
            // 
            // rushOrderInput
            // 
            rushOrderInput.Cursor = Cursors.IBeam;
            rushOrderInput.FormattingEnabled = true;
            rushOrderInput.Items.AddRange(new object[] { "3 Day", "5 Day", "7 Day", "14 Day (No additional shipping rates apply)" });
            rushOrderInput.Location = new Point(211, 384);
            rushOrderInput.MaxDropDownItems = 5;
            rushOrderInput.Name = "rushOrderInput";
            rushOrderInput.Size = new Size(180, 33);
            rushOrderInput.TabIndex = 11;
            rushOrderInput.SelectedIndexChanged += rushOrderInput_SelectedIndexChanged;
            // 
            // submitInputs
            // 
            submitInputs.BackColor = SystemColors.ControlDarkDark;
            submitInputs.ForeColor = SystemColors.HighlightText;
            submitInputs.Location = new Point(641, 387);
            submitInputs.Name = "submitInputs";
            submitInputs.Size = new Size(112, 34);
            submitInputs.TabIndex = 12;
            submitInputs.Text = "SUBMIT";
            submitInputs.UseVisualStyleBackColor = false;
            submitInputs.Click += submitInputs_Click;
            // 
            // AddQuote
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(800, 450);
            Controls.Add(submitInputs);
            Controls.Add(rushOrderInput);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(desktopInput);
            Controls.Add(nameInput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(drawersInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(depthInput);
            Controls.Add(widthInput);
            Name = "AddQuote";
            Text = "Add Quote";
            Load += AddQuote_Load;
            ((System.ComponentModel.ISupportInitialize)widthInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)depthInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)drawersInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown widthInput;
        private NumericUpDown depthInput;
        private Label label1;
        private Label label2;
        private NumericUpDown drawersInput;
        private Label label3;
        private Label label4;
        private TextBox nameInput;
        private ComboBox desktopInput;
        private Label label5;
        private Label label6;
        private ComboBox rushOrderInput;
        private Button submitInputs;
    }
}