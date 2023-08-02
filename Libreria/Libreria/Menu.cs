using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Libreria {
    public partial class Menu : Form {
        public int carnet;
        public string password;
        public SqlConnection conn;
        public Menu(int acarnet, string apassword, SqlConnection aconn) {

            carnet = acarnet;
            password = apassword;
            conn = aconn;
            Datos Usuario = new Datos(carnet, password, conn);
            InitializeComponent();
            label2.Text = Usuario.Nombre + " " + Usuario.Apellido;
            if (Usuario.Rango == 1) {
                //si es administrador puede hacer consultas, ingresar nuevos libros
                //y realizar prestamos de libros
                btnConsultas.Enabled = true;
                btnIngresar.Enabled = true;
                btnPrestamos.Enabled = true;
            }
            else if (Usuario.Rango == 2) {
                //si es bibliotecario puede hacer consultas, realizar prestamos de libros
                //pero no puede ingresar nuevos libros
                btnConsultas.Enabled = true;
                btnIngresar.Enabled = false;
                btnPrestamos.Enabled = true;
            }
            else if (Usuario.Rango == 3) {
                //si es profesor solo puede realizar consultas
                btnConsultas.Enabled = true;
                btnIngresar.Enabled = false;
                btnPrestamos.Enabled = false;
            }
            else if (Usuario.Rango == 4) {
                //si es alumno solo puede realizar consultas
                btnConsultas.Enabled = true;
                btnIngresar.Enabled = false;
                btnPrestamos.Enabled = false;
            }
            //la diferencia entre profesor y alumno es que los profesores no tiene mora por
            //vencimiento de fecha de devolucion
            //**Al final ya no se implemento esto por cuestiones de tiempo 
        }

        private void Menu_Load(object sender, EventArgs e) {

        }

        private void txtSalir_Click(object sender, EventArgs e) {
            Environment.Exit(1);
        }

        private void btnIngresar_Click(object sender, EventArgs e) {
            IngresoLibros ingresolib = new IngresoLibros(carnet, password, conn);
            ingresolib.Show();
            this.Hide();
        }

        private void btnConsultas_Click(object sender, EventArgs e) {
            Consultas consultas = new Consultas(carnet, password, conn);
            consultas.Show();
            this.Hide();
        }

        private void btnPrestamos_Click(object sender, EventArgs e) {
            Prestamos prestamos = new Prestamos(carnet, password, conn);
            prestamos.Show();
            this.Hide();
        }
    }
}
