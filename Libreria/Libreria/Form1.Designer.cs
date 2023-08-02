namespace Libreria {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            label2 = new Label();
            txtCarnet = new TextBox();
            txtPass = new TextBox();
            txtEnter = new Button();
            txtClear = new Button();
            txtExit = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(73, 86);
            label1.Name = "label1";
            label1.Size = new Size(53, 19);
            label1.TabIndex = 0;
            label1.Text = "Carnet:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(73, 124);
            label2.Name = "label2";
            label2.Size = new Size(82, 19);
            label2.TabIndex = 1;
            label2.Text = "Contraseña:";
            // 
            // txtCarnet
            // 
            txtCarnet.Location = new Point(159, 85);
            txtCarnet.Name = "txtCarnet";
            txtCarnet.Size = new Size(100, 23);
            txtCarnet.TabIndex = 2;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(158, 124);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(100, 23);
            txtPass.TabIndex = 3;
            // 
            // txtEnter
            // 
            txtEnter.Location = new Point(51, 176);
            txtEnter.Name = "txtEnter";
            txtEnter.Size = new Size(75, 23);
            txtEnter.TabIndex = 4;
            txtEnter.Text = "Ingresar";
            txtEnter.UseVisualStyleBackColor = true;
            txtEnter.Click += txtEnter_Click;
            // 
            // txtClear
            // 
            txtClear.Location = new Point(132, 176);
            txtClear.Name = "txtClear";
            txtClear.Size = new Size(75, 23);
            txtClear.TabIndex = 5;
            txtClear.Text = "Limpiar";
            txtClear.UseVisualStyleBackColor = true;
            txtClear.Click += txtClear_Click;
            // 
            // txtExit
            // 
            txtExit.Location = new Point(213, 176);
            txtExit.Name = "txtExit";
            txtExit.Size = new Size(75, 23);
            txtExit.TabIndex = 6;
            txtExit.Text = "Salir";
            txtExit.UseVisualStyleBackColor = true;
            txtExit.Click += txtExit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(118, 24);
            label3.Name = "label3";
            label3.Size = new Size(115, 28);
            label3.TabIndex = 7;
            label3.Text = "Bienvenido!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 269);
            Controls.Add(label3);
            Controls.Add(txtExit);
            Controls.Add(txtClear);
            Controls.Add(txtEnter);
            Controls.Add(txtPass);
            Controls.Add(txtCarnet);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Ingreso";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCarnet;
        private TextBox txtPass;
        private Button txtEnter;
        private Button txtClear;
        private Button txtExit;
        private Label label3;
    }
}