namespace practicaTaTeTi
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            lblGanador = new Label();
            btnRecargar = new Button();
            lblPerdedor = new Label();
            lblEmpate = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(71, 71);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 192, 255);
            button2.Location = new Point(89, 12);
            button2.Name = "button2";
            button2.Size = new Size(71, 71);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 192, 255);
            button3.Location = new Point(166, 12);
            button3.Name = "button3";
            button3.Size = new Size(71, 71);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(192, 192, 255);
            button4.Location = new Point(12, 89);
            button4.Name = "button4";
            button4.Size = new Size(71, 71);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(192, 192, 255);
            button5.Location = new Point(89, 89);
            button5.Name = "button5";
            button5.Size = new Size(71, 71);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(192, 192, 255);
            button6.Location = new Point(166, 89);
            button6.Name = "button6";
            button6.Size = new Size(71, 71);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(192, 192, 255);
            button7.Location = new Point(166, 166);
            button7.Name = "button7";
            button7.Size = new Size(71, 71);
            button7.TabIndex = 8;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(192, 192, 255);
            button8.Location = new Point(89, 166);
            button8.Name = "button8";
            button8.Size = new Size(71, 71);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(192, 192, 255);
            button9.Location = new Point(12, 166);
            button9.Name = "button9";
            button9.Size = new Size(71, 71);
            button9.TabIndex = 6;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // lblGanador
            // 
            lblGanador.AutoSize = true;
            lblGanador.BackColor = SystemColors.AppWorkspace;
            lblGanador.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblGanador.ImageAlign = ContentAlignment.BottomCenter;
            lblGanador.Location = new Point(60, 240);
            lblGanador.Name = "lblGanador";
            lblGanador.Size = new Size(131, 21);
            lblGanador.TabIndex = 9;
            lblGanador.Text = "HAS GANADO!";
            lblGanador.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRecargar
            // 
            btnRecargar.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRecargar.Location = new Point(60, 280);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(139, 29);
            btnRecargar.TabIndex = 10;
            btnRecargar.Text = "Volver a Jugar";
            btnRecargar.UseVisualStyleBackColor = true;
            btnRecargar.Click += btnRecargar_Click;
            // 
            // lblPerdedor
            // 
            lblPerdedor.AutoSize = true;
            lblPerdedor.BackColor = SystemColors.AppWorkspace;
            lblPerdedor.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblPerdedor.ImageAlign = ContentAlignment.BottomCenter;
            lblPerdedor.Location = new Point(48, 240);
            lblPerdedor.Name = "lblPerdedor";
            lblPerdedor.Size = new Size(151, 21);
            lblPerdedor.TabIndex = 11;
            lblPerdedor.Text = "Has perdido :(";
            lblPerdedor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmpate
            // 
            lblEmpate.AutoSize = true;
            lblEmpate.BackColor = SystemColors.AppWorkspace;
            lblEmpate.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmpate.ImageAlign = ContentAlignment.BottomCenter;
            lblEmpate.Location = new Point(74, 240);
            lblEmpate.Name = "lblEmpate";
            lblEmpate.Size = new Size(104, 21);
            lblEmpate.TabIndex = 12;
            lblEmpate.Text = "Empate :O";
            lblEmpate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(248, 321);
            Controls.Add(lblEmpate);
            Controls.Add(lblPerdedor);
            Controls.Add(btnRecargar);
            Controls.Add(lblGanador);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TA TE TI";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label lblGanador;
        private Button btnRecargar;
        private Label lblPerdedor;
        private Label lblEmpate;
    }
}