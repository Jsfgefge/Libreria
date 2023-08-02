using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Libreria {
    public partial class Prestamos : Form {
        public int carnet;
        public string password;
        public SqlConnection conn;
        public int carnetPrestamo;
        public string passwordPrestamo;
        public Prestamos(int acarnet, string apassword, SqlConnection aconn) {
            carnet = acarnet;
            password = apassword;
            conn = aconn;
            Datos Usuario = new Datos(carnet, password, conn);
            InitializeComponent();
            label6.Text = Usuario.Nombre + " " + Usuario.Apellido;
            label7.Text = "";
            label8.Text = "";
            btnSeguir.Enabled = false;
        }

        private void Prestamos_Load(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            //abre la ventana para finalizar el prestamo del libro
            //solo esta disponible si el usuario esta solvente y no ha prestado libros
            FinalizarPrestamos finalizarPrestamos = new FinalizarPrestamos(carnet, password, carnetPrestamo, passwordPrestamo, conn);
            finalizarPrestamos.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e) {
            //vamos a buscar la informacion de la persona que quiere prestar un libro
            //si no esta solvente o ya ha prestado un libro no va a poder prestar un libro
            //solo el bibliotecario y el admin tienen acceso a esta opcion
            int CarnetPrestamo = Convert.ToInt32(txtCarnet.Text);
            string prestamo;
            string mora;
            try {
                string querry = "SELECT * FROM Usuarios WHERE Carnet = " + CarnetPrestamo;
                SqlDataAdapter dsa = new SqlDataAdapter(querry, conn);

                DataTable dt = new DataTable();
                dsa.Fill(dt);

                if (dt.Rows.Count > 0) {
                    foreach (DataRow dr in dt.Rows) {
                        carnetPrestamo = Convert.ToInt32(dr["Carnet"]);
                        passwordPrestamo = dr["Contraseña"].ToString();
                        prestamo = dr["Prestamo"].ToString();
                        mora = dr["Solvencia"].ToString();
                        label7.Text = prestamo.ToString();
                        label8.Text = mora.ToString();
                        if (prestamo == "No" && mora == "Si") {
                            btnSeguir.Enabled = true;
                        }
                        else if (prestamo == "Si" || mora == "No") {
                            btnSeguir.Enabled = false;
                            MessageBox.Show("No puede prestar libros\nPague su mora o devuelva el libro", "Error");
                        }
                    }

                }
                else {
                    MessageBox.Show("Datos no validos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception E) {
                MessageBox.Show("Error" + E);
            }
            finally {
                conn.Close();
            }
        }

        private void txtMenu_Click(object sender, EventArgs e) {
            Menu menu = new Menu(carnet, password, conn);
            menu.Show();
            this.Hide();
        }

        private void txtSalir_Click(object sender, EventArgs e) {
            Environment.Exit(0);
        }
    }
}
