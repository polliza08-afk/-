namespace домашня_робота
{
    partial class MainForm
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
            btnMinus = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            TxtBox1 = new RichTextBox();
            TxtBox2 = new RichTextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Segoe UI", 14F);
            btnMinus.Location = new Point(320, 150);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(41, 34);
            btnMinus.TabIndex = 0;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Segoe UI", 14F);
            btnMultiply.Location = new Point(320, 190);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(41, 34);
            btnMultiply.TabIndex = 0;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Segoe UI", 14F);
            btnDivide.Location = new Point(320, 230);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(41, 34);
            btnDivide.TabIndex = 0;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // TxtBox1
            // 
            TxtBox1.Location = new Point(74, 160);
            TxtBox1.Name = "TxtBox1";
            TxtBox1.Size = new Size(144, 34);
            TxtBox1.TabIndex = 1;
            TxtBox1.Text = "";
            // 
            // TxtBox2
            // 
            TxtBox2.Location = new Point(74, 214);
            TxtBox2.Name = "TxtBox2";
            TxtBox2.Size = new Size(144, 34);
            TxtBox2.TabIndex = 1;
            TxtBox2.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(74, 351);
            label1.Name = "label1";
            label1.Size = new Size(32, 25);
            label1.TabIndex = 3;
            label1.Text = "    ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 450);
            Controls.Add(label1);
            Controls.Add(TxtBox2);
            Controls.Add(TxtBox1);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnMinus);
            Name = "MainForm";
            Text = "Калькулятор";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMinus;
        private Button btnMultiply;
        private Button btnDivide;
        private RichTextBox TxtBox1;
        private RichTextBox TxtBox2;
        private Label label1;
    }
}
