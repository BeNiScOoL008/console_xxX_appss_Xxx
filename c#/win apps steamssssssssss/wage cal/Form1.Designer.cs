namespace wage_cal
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            cal = new Button();
            can = new Button();
            how = new Label();
            pa = new Label();
            paen = new TextBox();
            hoen = new TextBox();
            tax = new Label();
            textBox67 = new TextBox();
            SuspendLayout();
            // 
            // cal
            // 
            cal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cal.Location = new Point(67, 152);
            cal.Name = "cal";
            cal.Size = new Size(80, 43);
            cal.TabIndex = 0;
            cal.Text = "Calculate net pay";
            cal.UseVisualStyleBackColor = true;
            cal.Click += cal_Click;
            // 
            // can
            // 
            can.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            can.Location = new Point(187, 152);
            can.Name = "can";
            can.Size = new Size(80, 43);
            can.TabIndex = 1;
            can.Text = "Exit";
            can.UseVisualStyleBackColor = true;
            can.Click += can_Click;
            // 
            // how
            // 
            how.AutoSize = true;
            how.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            how.Location = new Point(36, 9);
            how.Name = "how";
            how.Size = new Size(111, 28);
            how.TabIndex = 2;
            how.Text = "Enter hours";
            // 
            // pa
            // 
            pa.AutoSize = true;
            pa.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            pa.Location = new Point(36, 57);
            pa.Name = "pa";
            pa.Size = new Size(94, 28);
            pa.TabIndex = 3;
            pa.Text = "Enter pay";
            // 
            // paen
            // 
            paen.Location = new Point(167, 65);
            paen.Name = "paen";
            paen.Size = new Size(100, 23);
            paen.TabIndex = 4;
            paen.TextChanged += paen_TextChanged;
            // 
            // hoen
            // 
            hoen.Location = new Point(167, 17);
            hoen.Name = "hoen";
            hoen.Size = new Size(100, 23);
            hoen.TabIndex = 5;
            hoen.TextChanged += hoen_TextChanged;
            // 
            // tax
            // 
            tax.AutoSize = true;
            tax.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tax.Location = new Point(36, 104);
            tax.Name = "tax";
            tax.Size = new Size(88, 28);
            tax.TabIndex = 6;
            tax.Text = "Enter tax";
            // 
            // textBox67
            // 
            textBox67.Location = new Point(167, 112);
            textBox67.Name = "textBox67";
            textBox67.Size = new Size(100, 23);
            textBox67.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 207);
            Controls.Add(textBox67);
            Controls.Add(tax);
            Controls.Add(hoen);
            Controls.Add(paen);
            Controls.Add(pa);
            Controls.Add(how);
            Controls.Add(can);
            Controls.Add(cal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Wage Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cal;
        private Button can;
        private Label how;
        private Label pa;
        private TextBox paen;
        private TextBox hoen;
        private Label tax;
        private TextBox textBox67;
    }
}