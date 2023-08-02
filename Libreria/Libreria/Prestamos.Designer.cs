namespace Libreria {
    partial class Prestamos {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            btnSeguir = new Button();
            txtCarnet = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnMenu = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(168, 30);
            label1.Name = "label1";
            label1.Size = new Size(102, 28);
            label1.TabIndex = 0;
            label1.Text = "Prestamos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(53, 86);
            label2.Name = "label2";
            label2.Size = new Size(53, 19);
            label2.TabIndex = 1;
            label2.Text = "Carnet:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(53, 116);
            label3.Name = "label3";
            label3.Size = new Size(76, 19);
            label3.TabIndex = 2;
            label3.Text = "Prestamos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(53, 143);
            label4.Name = "label4";
            label4.Size = new Size(68, 19);
            label4.TabIndex = 3;
            label4.Text = "Solvencia:";
            // 
            // button1
            // 
            button1.Location = new Point(335, 85);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnSeguir
            // 
            btnSeguir.Location = new Point(335, 114);
            btnSeguir.Name = "btnSeguir";
            btnSeguir.Size = new Size(75, 23);
            btnSeguir.TabIndex = 5;
            btnSeguir.Text = "Seguir";
            btnSeguir.UseVisualStyleBackColor = true;
            btnSeguir.Click += button2_Click;
            // 
            // txtCarnet
            // 
            txtCarnet.Location = new Point(142, 85);
            txtCarnet.Name = "txtCarnet";
            txtCarnet.Size = new Size(100, 23);
            txtCarnet.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(57, 19);
            label6.TabIndex = 8;
            label6.Text = "nombre";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(138, 118);
            label7.Name = "label7";
            label7.Size = new Size(108, 19);
            label7.TabIndex = 9;
            label7.Text = "estadoprestamo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(138, 143);
            label8.Name = "label8";
            label8.Size = new Size(105, 19);
            label8.TabIndex = 10;
            label8.Text = "estadosolvencia";
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(335, 143);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(75, 23);
            btnMenu.TabIndex = 11;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += txtMenu_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(335, 172);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += txtSalir_Click;
            // 
            // Prestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 234);
            Controls.Add(btnSalir);
            Controls.Add(btnMenu);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtCarnet);
            Controls.Add(btnSeguir);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Prestamos";
            Text = "Prestamos";
            Load += Prestamos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button btnSeguir;
        private TextBox txtCarnet;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnMenu;
        private Button btnSalir;
    }
}