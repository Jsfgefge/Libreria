namespace Libreria {
    partial class Menu {
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
            btnIngresar = new Button();
            btnConsultas = new Button();
            btnPrestamos = new Button();
            label1 = new Label();
            label2 = new Label();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(68, 114);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 45);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar libros";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnConsultas
            // 
            btnConsultas.Location = new Point(68, 165);
            btnConsultas.Name = "btnConsultas";
            btnConsultas.Size = new Size(75, 45);
            btnConsultas.TabIndex = 1;
            btnConsultas.Text = "Consultas";
            btnConsultas.UseVisualStyleBackColor = true;
            btnConsultas.Click += btnConsultas_Click;
            // 
            // btnPrestamos
            // 
            btnPrestamos.Location = new Point(149, 114);
            btnPrestamos.Name = "btnPrestamos";
            btnPrestamos.Size = new Size(75, 45);
            btnPrestamos.TabIndex = 2;
            btnPrestamos.Text = "Prestamos";
            btnPrestamos.UseVisualStyleBackColor = true;
            btnPrestamos.Click += btnPrestamos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(114, 42);
            label1.Name = "label1";
            label1.Size = new Size(69, 28);
            label1.TabIndex = 3;
            label1.Text = "MENU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(45, 19);
            label2.TabIndex = 4;
            label2.Text = "label2";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(149, 165);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 45);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += txtSalir_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 267);
            Controls.Add(btnSalir);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnPrestamos);
            Controls.Add(btnConsultas);
            Controls.Add(btnIngresar);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private Button btnConsultas;
        private Button btnPrestamos;
        private Label label1;
        private Label label2;
        private Button btnSalir;
    }
}