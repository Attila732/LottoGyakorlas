namespace WinFormsApp
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
            panel = new Panel();
            btnSorsol = new Button();
            btnBezar = new Button();
            lblEredmenyek = new Label();
            SuspendLayout();
            // 
            // panel
            // 
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Size = new Size(521, 258);
            panel.TabIndex = 0;
            // 
            // btnSorsol
            // 
            btnSorsol.Location = new Point(527, 12);
            btnSorsol.Name = "btnSorsol";
            btnSorsol.Size = new Size(75, 23);
            btnSorsol.TabIndex = 0;
            btnSorsol.Text = "Sorsolás";
            btnSorsol.UseVisualStyleBackColor = true;
            btnSorsol.Click += btnSorsol_Click;
            // 
            // btnBezar
            // 
            btnBezar.Location = new Point(527, 52);
            btnBezar.Name = "btnBezar";
            btnBezar.Size = new Size(75, 23);
            btnBezar.TabIndex = 1;
            btnBezar.Text = "Bezár";
            btnBezar.UseVisualStyleBackColor = true;
            btnBezar.Click += button2_Click;
            // 
            // lblEredmenyek
            // 
            lblEredmenyek.AutoSize = true;
            lblEredmenyek.Location = new Point(527, 93);
            lblEredmenyek.Name = "lblEredmenyek";
            lblEredmenyek.Size = new Size(38, 15);
            lblEredmenyek.TabIndex = 2;
            lblEredmenyek.Text = "label1";
            lblEredmenyek.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 269);
            Controls.Add(lblEredmenyek);
            Controls.Add(btnBezar);
            Controls.Add(btnSorsol);
            Controls.Add(panel);
            Name = "Form1";
            Text = "Lottó Szimuláció";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel;
        private Button btnSorsol;
        private Button btnBezar;
        private Label lblEredmenyek;
    }
}
