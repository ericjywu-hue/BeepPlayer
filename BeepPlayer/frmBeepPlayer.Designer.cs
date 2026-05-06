namespace BeepPlayer
{
    partial class frmBeepPlayer
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlVisualizer = new System.Windows.Forms.Panel();
            this.palMain = new System.Windows.Forms.Panel();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.palMain.SuspendLayout();
            this.SuspendLayout();

            // pnlVisualizer
            this.pnlVisualizer.Location = new System.Drawing.Point(12, 12);
            this.pnlVisualizer.Name = "pnlVisualizer";
            this.pnlVisualizer.Size = new System.Drawing.Size(580, 90);
            this.pnlVisualizer.TabIndex = 9;
            this.pnlVisualizer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlVisualizer_Paint);

            // palMain
            this.palMain.BackColor = System.Drawing.Color.FromArgb(30, 30, 45);
            this.palMain.Controls.Add(this.btn1);
            this.palMain.Controls.Add(this.btn2);
            this.palMain.Controls.Add(this.btn3);
            this.palMain.Controls.Add(this.btn4);
            this.palMain.Controls.Add(this.btn5);
            this.palMain.Controls.Add(this.btn6);
            this.palMain.Controls.Add(this.btn7);
            this.palMain.Controls.Add(this.btn8);
            this.palMain.Location = new System.Drawing.Point(12, 112);
            this.palMain.Name = "palMain";
            this.palMain.Size = new System.Drawing.Size(580, 110);
            this.palMain.TabIndex = 8;

            // btn1 - Do
            this.btn1.BackColor = System.Drawing.Color.FromArgb(255, 99, 99);
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(6, 5);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(68, 100);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Do\n(A)";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);

            // btn2 - Re
            this.btn2.BackColor = System.Drawing.Color.FromArgb(255, 165, 50);
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(78, 5);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(68, 100);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Re\n(S)";
            this.btn2.UseVisualStyleBackColor = false;

            // btn3 - Mi
            this.btn3.BackColor = System.Drawing.Color.FromArgb(240, 210, 50);
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(150, 5);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(68, 100);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "Mi\n(D)";
            this.btn3.UseVisualStyleBackColor = false;

            // btn4 - Fa
            this.btn4.BackColor = System.Drawing.Color.FromArgb(100, 200, 100);
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.Location = new System.Drawing.Point(222, 5);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(68, 100);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "Fa\n(F)";
            this.btn4.UseVisualStyleBackColor = false;

            // btn5 - Sol
            this.btn5.BackColor = System.Drawing.Color.FromArgb(80, 160, 240);
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.Location = new System.Drawing.Point(294, 5);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(68, 100);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "Sol\n(G)";
            this.btn5.UseVisualStyleBackColor = false;

            // btn6 - La
            this.btn6.BackColor = System.Drawing.Color.FromArgb(100, 100, 240);
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.Location = new System.Drawing.Point(366, 5);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(68, 100);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "La\n(H)";
            this.btn6.UseVisualStyleBackColor = false;

            // btn7 - Si
            this.btn7.BackColor = System.Drawing.Color.FromArgb(160, 80, 220);
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.Location = new System.Drawing.Point(438, 5);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(68, 100);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "Si\n(J)";
            this.btn7.UseVisualStyleBackColor = false;

            // btn8 - Do'
            this.btn8.BackColor = System.Drawing.Color.FromArgb(255, 80, 120);
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.Location = new System.Drawing.Point(510, 5);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(68, 100);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "Do'\n(K)";
            this.btn8.UseVisualStyleBackColor = false;

            // lblStatus
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(20, 20, 32);
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(160, 220, 160);
            this.lblStatus.Location = new System.Drawing.Point(12, 232);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(580, 24);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // frmBeepPlayer
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(22, 22, 35);
            this.ClientSize = new System.Drawing.Size(604, 268);
            this.Controls.Add(this.pnlVisualizer);
            this.Controls.Add(this.palMain);
            this.Controls.Add(this.lblStatus);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "frmBeepPlayer";
            this.Text = "Beep Player";

            this.palMain.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlVisualizer;
        private System.Windows.Forms.Panel palMain;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Label lblStatus;
    }
}