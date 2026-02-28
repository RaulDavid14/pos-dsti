namespace pos_dsti
{
    partial class LoginForm
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
            panel1 = new Panel();
            panel2 = new Panel();
            loginMinimizar = new PictureBox();
            loginSalir = new PictureBox();
            panelTitle = new Panel();
            loginTitleLabel = new Label();
            panel3 = new Panel();
            panel6 = new Panel();
            loginButton = new Button();
            panel5 = new Panel();
            loginPassword = new TextBox();
            panel4 = new Panel();
            loginText = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loginMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loginSalir).BeginInit();
            panelTitle.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 400);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(loginMinimizar);
            panel2.Controls.Add(loginSalir);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 20);
            panel2.TabIndex = 1;
            // 
            // loginMinimizar
            // 
            loginMinimizar.Image = Properties.Resources.minimizar_ventana;
            loginMinimizar.Location = new Point(346, 0);
            loginMinimizar.Name = "loginMinimizar";
            loginMinimizar.Size = new Size(24, 20);
            loginMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            loginMinimizar.TabIndex = 2;
            loginMinimizar.TabStop = false;
            loginMinimizar.Click += loginMinimizar_Click;
            // 
            // loginSalir
            // 
            loginSalir.Image = Properties.Resources.cruz;
            loginSalir.Location = new Point(376, 0);
            loginSalir.Name = "loginSalir";
            loginSalir.Size = new Size(24, 20);
            loginSalir.SizeMode = PictureBoxSizeMode.Zoom;
            loginSalir.TabIndex = 0;
            loginSalir.TabStop = false;
            loginSalir.Click += loginSalir_Click;
            // 
            // panelTitle
            // 
            panelTitle.Controls.Add(loginTitleLabel);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(200, 20);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(400, 100);
            panelTitle.TabIndex = 2;
            // 
            // loginTitleLabel
            // 
            loginTitleLabel.AutoSize = true;
            loginTitleLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginTitleLabel.Location = new Point(125, 35);
            loginTitleLabel.Name = "loginTitleLabel";
            loginTitleLabel.Size = new Size(191, 47);
            loginTitleLabel.TabIndex = 0;
            loginTitleLabel.Text = "Bienvenido";
            loginTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(200, 120);
            panel3.Name = "panel3";
            panel3.Size = new Size(400, 280);
            panel3.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.Controls.Add(loginButton);
            panel6.Location = new Point(0, 217);
            panel6.Name = "panel6";
            panel6.Size = new Size(400, 40);
            panel6.TabIndex = 3;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(94, 0);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(222, 40);
            loginButton.TabIndex = 0;
            loginButton.Text = "Acceder";
            loginButton.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(loginPassword);
            panel5.Location = new Point(0, 123);
            panel5.Name = "panel5";
            panel5.Size = new Size(400, 20);
            panel5.TabIndex = 2;
            // 
            // loginPassword
            // 
            loginPassword.Location = new Point(94, -3);
            loginPassword.Name = "loginPassword";
            loginPassword.Size = new Size(222, 23);
            loginPassword.TabIndex = 0;
            loginPassword.Text = "Contraseña";
            // 
            // panel4
            // 
            panel4.Controls.Add(loginText);
            panel4.Location = new Point(0, 79);
            panel4.Name = "panel4";
            panel4.Size = new Size(400, 20);
            panel4.TabIndex = 1;
            // 
            // loginText
            // 
            loginText.ForeColor = Color.Gray;
            loginText.Location = new Point(94, -3);
            loginText.Name = "loginText";
            loginText.Size = new Size(222, 23);
            loginText.TabIndex = 0;
            loginText.Text = "Usuario";
            loginText.Enter += loginText_Enter;
            loginText.Leave += loginText_Leave;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 250);
            ClientSize = new Size(600, 400);
            Controls.Add(panel3);
            Controls.Add(panelTitle);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bienvenido";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)loginMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)loginSalir).EndInit();
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox loginSalir;
        private PictureBox loginMinimizar;
        private Panel panelTitle;
        private Panel panel3;
        private Panel panel4;
        private TextBox loginText;
        private Panel panel5;
        private TextBox loginPassword;
        private Panel panel6;
        private Button loginButton;
        private Label loginTitleLabel;
    }
}