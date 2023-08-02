namespace Libreria {
    partial class Consultas {
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
            txtIdioma = new TextBox();
            btnBuscar = new Button();
            btnMostrar = new Button();
            btnMenu = new Button();
            btnSalir = new Button();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(287, 27);
            label1.Name = "label1";
            label1.Size = new Size(96, 28);
            label1.TabIndex = 0;
            label1.Text = "Consultas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(49, 80);
            label2.Name = "label2";
            label2.Size = new Size(46, 19);
            label2.TabIndex = 1;
            label2.Text = "Titulo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(49, 109);
            label3.Name = "label3";
            label3.Size = new Size(47, 19);
            label3.TabIndex = 2;
            label3.Text = "Autor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(49, 138);
            label4.Name = "label4";
            label4.Size = new Size(54, 19);
            label4.TabIndex = 3;
            label4.Text = "Idioma:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(106, 79);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(277, 23);
            txtTitulo.TabIndex = 6;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(106, 108);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(277, 23);
            txtAutor.TabIndex = 7;
            // 
            // txtIdioma
            // 
            txtIdioma.Location = new Point(106, 137);
            txtIdioma.Name = "txtIdioma";
            txtIdioma.Size = new Size(277, 23);
            txtIdioma.TabIndex = 8;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(431, 75);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 38);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(431, 119);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 38);
            btnMostrar.TabIndex = 11;
            btnMostrar.Text = "Mostrar Todo";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(512, 75);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(75, 38);
            btnMenu.TabIndex = 12;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(512, 119);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 38);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 5;
            label6.Text = "nombre";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 224);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(647, 200);
            dataGridView1.TabIndex = 14;
            // 
            // Consultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnSalir);
            Controls.Add(btnMenu);
            Controls.Add(btnMostrar);
            Controls.Add(btnBuscar);
            Controls.Add(txtIdioma);
            Controls.Add(txtAutor);
            Controls.Add(txtTitulo);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Consultas";
            Text = "Consultas";
            Load += Consultas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtTitulo;
        private TextBox txtAutor;
        private TextBox txtIdioma;
        private Label labelYesNo;
        private Button btnBuscar;
        private Button btnMostrar;
        private Button btnMenu;
        private Button btnSalir;
        private Label label6;
        private DataGridView dataGridView1;
    }
}