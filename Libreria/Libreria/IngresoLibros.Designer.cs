namespace Libreria {
    partial class IngresoLibros {
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
            txtTitulo = new TextBox();
            txtAutor = new TextBox();
            txtDamage = new TextBox();
            label7 = new Label();
            txtIdioma = new TextBox();
            btnRegresar = new Button();
            btnSalir = new Button();
            btnIngresar = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(135, 37);
            label1.Name = "label1";
            label1.Size = new Size(96, 28);
            label1.TabIndex = 0;
            label1.Text = "Consultas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(58, 98);
            label2.Name = "label2";
            label2.Size = new Size(46, 19);
            label2.TabIndex = 1;
            label2.Text = "Titulo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(58, 127);
            label3.Name = "label3";
            label3.Size = new Size(47, 19);
            label3.TabIndex = 2;
            label3.Text = "Autor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(58, 156);
            label4.Name = "label4";
            label4.Size = new Size(54, 19);
            label4.TabIndex = 3;
            label4.Text = "Idioma:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(115, 97);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(100, 23);
            txtTitulo.TabIndex = 4;
            txtTitulo.TextChanged += txtTitulo_TextChanged;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(115, 126);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(100, 23);
            txtAutor.TabIndex = 5;
            // 
            // txtDamage
            // 
            txtDamage.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDamage.Location = new Point(86, 34);
            txtDamage.Name = "txtDamage";
            txtDamage.Size = new Size(100, 25);
            txtDamage.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(57, 19);
            label7.TabIndex = 9;
            label7.Text = "nombre";
            label7.TextAlign = ContentAlignment.TopRight;
            // 
            // txtIdioma
            // 
            txtIdioma.Location = new Point(115, 155);
            txtIdioma.Name = "txtIdioma";
            txtIdioma.Size = new Size(100, 23);
            txtIdioma.TabIndex = 10;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(283, 136);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 35);
            btnRegresar.TabIndex = 11;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(283, 177);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 35);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(283, 95);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 35);
            btnIngresar.TabIndex = 13;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(30, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(37, 23);
            radioButton1.TabIndex = 14;
            radioButton1.TabStop = true;
            radioButton1.Text = "Si";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(30, 47);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(45, 23);
            radioButton2.TabIndex = 15;
            radioButton2.TabStop = true;
            radioButton2.Text = "No";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(txtDamage);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(58, 184);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 84);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dañado";
            // 
            // IngresoLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 300);
            Controls.Add(groupBox1);
            Controls.Add(btnIngresar);
            Controls.Add(btnSalir);
            Controls.Add(btnRegresar);
            Controls.Add(txtIdioma);
            Controls.Add(label7);
            Controls.Add(txtAutor);
            Controls.Add(txtTitulo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "IngresoLibros";
            Text = "IngresoLibros";
            Load += IngresoLibros_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitulo;
        private TextBox txtAutor;
        private TextBox txtIdioma;
        private TextBox txtDamage;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label7;
        private Button btnRegresar;
        private Button btnSalir;
        private Button btnIngresar;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
    }
}