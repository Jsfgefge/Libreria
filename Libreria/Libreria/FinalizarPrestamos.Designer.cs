namespace Libreria {
    partial class FinalizarPrestamos {
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
            btnBuscar = new Button();
            btnPrestar = new Button();
            label3 = new Label();
            txtCarnet = new TextBox();
            txtLibro = new TextBox();
            label4 = new Label();
            labelYesNo = new Label();
            btnCancelar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(181, 9);
            label1.Name = "label1";
            label1.Size = new Size(228, 28);
            label1.TabIndex = 0;
            label1.Text = "Finalizacion de Prestamo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(113, 125);
            label2.Name = "label2";
            label2.Size = new Size(55, 19);
            label2.TabIndex = 1;
            label2.Text = "Id libro:";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(344, 67);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 37);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += button1_Click;
            // 
            // btnPrestar
            // 
            btnPrestar.Location = new Point(344, 116);
            btnPrestar.Name = "btnPrestar";
            btnPrestar.Size = new Size(75, 37);
            btnPrestar.TabIndex = 3;
            btnPrestar.Text = "Prestar";
            btnPrestar.UseVisualStyleBackColor = true;
            btnPrestar.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(113, 76);
            label3.Name = "label3";
            label3.Size = new Size(53, 19);
            label3.TabIndex = 4;
            label3.Text = "Carnet:";
            // 
            // txtCarnet
            // 
            txtCarnet.Location = new Point(181, 75);
            txtCarnet.Name = "txtCarnet";
            txtCarnet.Size = new Size(127, 23);
            txtCarnet.TabIndex = 5;
            // 
            // txtLibro
            // 
            txtLibro.Location = new Point(181, 124);
            txtLibro.Name = "txtLibro";
            txtLibro.Size = new Size(127, 23);
            txtLibro.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(113, 189);
            label4.Name = "label4";
            label4.Size = new Size(110, 28);
            label4.TabIndex = 7;
            label4.Text = "Disponible:";
            // 
            // labelYesNo
            // 
            labelYesNo.AutoSize = true;
            labelYesNo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelYesNo.Location = new Point(219, 189);
            labelYesNo.Name = "labelYesNo";
            labelYesNo.Size = new Size(71, 28);
            labelYesNo.TabIndex = 8;
            labelYesNo.Text = "estado";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(425, 68);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 37);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += button3_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(425, 116);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 37);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += button4_Click;
            // 
            // FinalizarPrestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 277);
            Controls.Add(btnSalir);
            Controls.Add(btnCancelar);
            Controls.Add(labelYesNo);
            Controls.Add(label4);
            Controls.Add(txtLibro);
            Controls.Add(txtCarnet);
            Controls.Add(label3);
            Controls.Add(btnPrestar);
            Controls.Add(btnBuscar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FinalizarPrestamos";
            Text = "FinalizarPrestamos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnBuscar;
        private Button btnPrestar;
        private Label label3;
        private TextBox txtCarnet;
        private TextBox txtLibro;
        private Label label4;
        private Label labelYesNo;
        private Button btnCancelar;
        private Button btnSalir;
    }
}