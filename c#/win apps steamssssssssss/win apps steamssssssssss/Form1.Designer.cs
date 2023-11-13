namespace win_apps_steamssssssssss
{
    partial class Form7
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
            btn7 = new Button();
            label13 = new Label();
            textBox37 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.MenuHighlight;
            btn7.FlatStyle = FlatStyle.Popup;
            btn7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn7.Location = new Point(12, 80);
            btn7.Name = "btn7";
            btn7.Size = new Size(26, 317);
            btn7.TabIndex = 0;
            btn7.Text = "Don't click me";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // label13
            // 
            label13.BorderStyle = BorderStyle.FixedSingle;
            label13.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(12, 413);
            label13.Name = "label13";
            label13.Size = new Size(782, 28);
            label13.TabIndex = 1;
            // 
            // textBox37
            // 
            textBox37.Location = new Point(44, 247);
            textBox37.Name = "textBox37";
            textBox37.Size = new Size(714, 23);
            textBox37.TabIndex = 2;
            textBox37.TextChanged += textBox37_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(764, 80);
            button1.Name = "button1";
            button1.Size = new Size(30, 317);
            button1.TabIndex = 3;
            button1.Text = "to lower";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(782, 67);
            button2.TabIndex = 4;
            button2.Text = "TO UPPER";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Location = new Point(331, 142);
            label6.Name = "label6";
            label6.Size = new Size(125, 38);
            label6.TabIndex = 5;
            label6.Click += label1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(697, 85);
            button3.Name = "button3";
            button3.Size = new Size(61, 21);
            button3.TabIndex = 6;
            button3.Text = "exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(807, 451);
            ControlBox = false;
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox37);
            Controls.Add(label13);
            Controls.Add(btn7);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form7";
            Text = "My main is Master Cheif";
            FormClosing += Form7_FormClosing;
            Load += Form7_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn7;
        private Label label13;
        private TextBox textBox37;
        private Button button1;
        private Button button2;
        private Label label6;
        private Button button3;
    }
}