namespace Laskin
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
            LukuYksiTB = new TextBox();
            LaskutoimitusCB = new ComboBox();
            LukuKaksiTB = new TextBox();
            label1 = new Label();
            VastausLB = new Label();
            VastausBT = new Button();
            SuspendLayout();
            // 
            // LukuYksiTB
            // 
            LukuYksiTB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LukuYksiTB.Location = new Point(33, 48);
            LukuYksiTB.Name = "LukuYksiTB";
            LukuYksiTB.Size = new Size(125, 43);
            LukuYksiTB.TabIndex = 0;
            // 
            // LaskutoimitusCB
            // 
            LaskutoimitusCB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LaskutoimitusCB.FormattingEnabled = true;
            LaskutoimitusCB.Items.AddRange(new object[] { "+", "-", "*", "/" });
            LaskutoimitusCB.Location = new Point(164, 47);
            LaskutoimitusCB.Name = "LaskutoimitusCB";
            LaskutoimitusCB.Size = new Size(62, 45);
            LaskutoimitusCB.TabIndex = 1;
            // 
            // LukuKaksiTB
            // 
            LukuKaksiTB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LukuKaksiTB.Location = new Point(232, 48);
            LukuKaksiTB.Name = "LukuKaksiTB";
            LukuKaksiTB.Size = new Size(125, 43);
            LukuKaksiTB.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(363, 50);
            label1.Name = "label1";
            label1.Size = new Size(35, 37);
            label1.TabIndex = 3;
            label1.Text = "=";
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            VastausLB.Location = new Point(404, 51);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(33, 37);
            VastausLB.TabIndex = 4;
            VastausLB.Text = "X";
            // 
            // VastausBT
            // 
            VastausBT.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            VastausBT.Location = new Point(444, 47);
            VastausBT.Name = "VastausBT";
            VastausBT.Size = new Size(111, 45);
            VastausBT.TabIndex = 5;
            VastausBT.Text = "Laske";
            VastausBT.UseVisualStyleBackColor = true;
            VastausBT.Click += VastausBT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 136);
            Controls.Add(VastausBT);
            Controls.Add(VastausLB);
            Controls.Add(label1);
            Controls.Add(LukuKaksiTB);
            Controls.Add(LaskutoimitusCB);
            Controls.Add(LukuYksiTB);
            Name = "Form1";
            Text = "yksinkertainen nelilaskin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LukuYksiTB;
        private ComboBox LaskutoimitusCB;
        private TextBox LukuKaksiTB;
        private Label label1;
        private Label VastausLB;
        private Button VastausBT;
    }
}