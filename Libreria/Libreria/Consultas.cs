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
    public partial class Consultas : Form {
        public int carnet;
        public string password;
        public SqlConnection conn;
        public Consultas(int acarnet, string apassword, SqlConnection aconn) {
            carnet = acarnet;
            password = apassword;
            conn = aconn;
            Datos Usuario = new Datos(carnet, password, conn);
            InitializeComponent();
            label6.Text = Usuario.Nombre + " " + Usuario.Apellido;
        }

        private void Consultas_Load(object sender, EventArgs e) {

        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            //busca el libro en base a palabras que pueden estar contenidas en los campos de titulo,
            //autor e Idioma
            if (txtTitulo.Text != "" || txtAutor.Text != "" || txtIdioma.Text != "") {
                try {
                    conn.Open();
                    string querry = "SELECT * FROM Catalogo WHERE " +
                    "Titulo LIKE '%" + txtTitulo.Text + "%' OR " +
                    "Autor LIKE '%" + txtAutor.Text + "%' OR " +
                    "Idioma LIKE '%" + txtIdioma.Text + "%'";
                    SqlCommand cmd = new SqlCommand(querry, conn);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);

                    dataGridView1.ReadOnly = true;
                    dataGridView1.DataSource = dataSet.Tables[0];

                    conn.Close();

                }
                catch (Exception ex) {
                    MessageBox.Show("Error " + ex);
                }
                finally {
                    conn.Close();
                }
            }
            else {
                MessageBox.Show("Llene almenos un campo");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e) {
            //Muestran todos los libros en el catalogo
            try {
                conn.Open();
                string querry = "SELECT * FROM Catalogo";
                SqlCommand cmd = new SqlCommand(querry, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = dataSet.Tables[0];

                conn.Close();

            }
            catch (Exception ex) {
                MessageBox.Show("Error " + ex);
            }
            finally { 
                conn.Close(); 
            }
        }

        private void btnMenu_Click(object sender, EventArgs e) {
            Menu menu = new Menu(carnet, password, conn);
            menu.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e) {
            Environment.Exit(1);
        }
    }
}
