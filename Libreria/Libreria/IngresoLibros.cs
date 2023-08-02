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

namespace Libreria {
    public partial class IngresoLibros : Form {
        public int carnet;
        public string password;
        public SqlConnection conn;
        public IngresoLibros(int acarnet, string apassword, SqlConnection aconn) {
            carnet = acarnet;
            password = apassword;
            conn = aconn;
            Datos Usuario = new Datos(carnet, password, conn);
            InitializeComponent();
            label7.Text = Usuario.Nombre + " " + Usuario.Apellido;
            txtDamage.Enabled = false;
            radioButton2.Checked = true;
        }

        private void IngresoLibros_Load(object sender, EventArgs e) {

        }

        private void btnSalir_Click(object sender, EventArgs e) {
            Environment.Exit(1);
        }

        private void btnRegresar_Click(object sender, EventArgs e) {
            Menu menu = new Menu(carnet, password, conn);
            menu.Show();
            this.Hide();
        }

        private void btnIngresar_Click(object sender, EventArgs e) {
            //Nos permite ingresar libros al catalogo, solo el Administrador puede hacer esto
            //Si no esta dañanado no es necesario ingresar informacion acerca del estado, 
            //si esta dañado solo nos dejara ingresar el libro si y solo si damos informacion acerca
            //de su estado
            string titulo = txtTitulo.Text;
            string autor = txtAutor.Text;
            string idioma = txtIdioma.Text;
            if (idioma == "") {
                idioma = "español";
            }
            string damage = txtDamage.Text;
            if (damage == "") {
                damage = null;
            }
            string querry = "INSERT Catalogo (Titulo, Autor, Idioma, Disponible, DAÑADO)" +
                "VALUES ('" + titulo + "', '" + autor + "', '" + idioma + "', 1, '" + damage + "')";

            if (titulo == "" || autor == "" || (radioButton1.Checked == true && damage == null)) {
                MessageBox.Show("Por favor ingrese los campos faltantes", "Error");
                radioButton1.Checked = false;
                radioButton2.Checked = true;
            }
            else {
                try {
                    SqlCommand sqlcomm = new SqlCommand(querry);
                    sqlcomm.CommandType = CommandType.Text;
                    conn.Open();
                    sqlcomm.Connection = conn;
                    sqlcomm.ExecuteNonQuery();
                    conn.Close();
                    DialogResult dialogResult = MessageBox.Show("Registro Exitoso\nDesea agregar otro?", "Exito!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dialogResult == DialogResult.No) {
                        Menu menu = new Menu(carnet, password, conn);
                        menu.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show("Error " + ex);
                }
                finally {
                    conn.Close();
                }
            }


        }

        private void txtTitulo_TextChanged(object sender, EventArgs e) {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            txtDamage.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {
            txtDamage.Enabled = false;
        }
    }
}
