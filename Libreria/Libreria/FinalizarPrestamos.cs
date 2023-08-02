using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Libreria {
    public partial class FinalizarPrestamos : Form {
        public int carnet;
        public string password;
        public int carnetprestamo;
        public string passwordprestamo;
        public SqlConnection conn;
        public FinalizarPrestamos(int acarnet, string apassword, int acarnetprestamo, string apasswordprestamo, SqlConnection aconn) {
            carnet = acarnet;
            password = apassword;
            carnetprestamo = acarnetprestamo;
            passwordprestamo = apasswordprestamo;
            conn = aconn;
            Datos Usuario = new Datos(carnetprestamo, passwordprestamo, conn);
            InitializeComponent();
            txtCarnet.Enabled = false;
            txtCarnet.Text = Usuario.Carnet.ToString();
            labelYesNo.Text = "";
            btnPrestar.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e) {
            //revisa si el libro correspondiente a id esta disponible o no, en caso de estar disponible nos permite
            //finalizar el prestamo del libro
            if (txtLibro.Text != "") {
                try {
                    conn.Open();
                    string querry = "SELECT * FROM Catalogo WHERE id_libro = " + Convert.ToInt32(txtLibro.Text);
                    SqlDataAdapter dsa = new SqlDataAdapter(querry, conn);

                    DataTable dt = new DataTable();
                    dsa.Fill(dt);

                    if (dt.Rows.Count > 0) {
                        foreach (DataRow dr in dt.Rows) {
                            int Disponible = Convert.ToInt32(dr["Disponible"]);
                            if (Disponible == 1) {
                                btnPrestar.Enabled = true;
                                labelYesNo.Text = "Si";
                            }
                            else {
                                btnPrestar.Enabled = false;
                                labelYesNo.Text = "No";
                            }
                        }
                    }

                    conn.Close();

                }
                catch (Exception ex) {
                    MessageBox.Show("Error buscar" + ex);
                }
                finally {
                    conn.Close();
                }
            }
            else {
                MessageBox.Show("Llene almenos un campo");
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            Prestamos prestamo = new Prestamos(carnet, password, conn);
            prestamo.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e) {
            Environment.Exit(1);
        }

        private void button2_Click(object sender, EventArgs e) {
            //en caso que el libro este disponible vamos a poder terminar el prestamo,
            //en tal caso, vamos a insertar ese registro en la tabla prestamos para mantener un historial
            //y vamos a actualizar la tabla Catalogo para indicar que el libro ya no esta disponible
            string querry = "INSERT Prestamos (Carnet, Id_libro)" +
                "VALUES ('" + carnetprestamo + "', " + Convert.ToInt32(txtLibro.Text) + ")";
            string querry2 = "UPDATE Catalogo SET Disponible = 0 WHERE Id_libro =" + Convert.ToInt32(txtLibro.Text);
            string querry3 = "UPDATE Usuario SET Prestamo = 'si' WHERE Carnet =" + carnetprestamo;
            try {
                conn.Open();
                //para ejecutar el comando de historial de prestamos
                SqlCommand sqlcomm = new SqlCommand(querry);
                sqlcomm.CommandType = CommandType.Text;
                sqlcomm.Connection = conn;
                sqlcomm.ExecuteNonQuery();
                //para ejecutar el comando de actualizacion de estatus de la disponibilidad del libro
                SqlCommand sqlcomm2 = new SqlCommand(querry2);
                sqlcomm2.CommandType = CommandType.Text;
                sqlcomm2.Connection = conn;
                sqlcomm2.ExecuteNonQuery();
                //para ejecutar el comando de actualizacion de estados de si el usuario a prestado un
                //libro o no
                SqlCommand sqlcomm3 = new SqlCommand(querry3);
                sqlcomm3.CommandType = CommandType.Text;
                sqlcomm3.Connection = conn;
                sqlcomm3.ExecuteNonQuery();

                labelYesNo.Text = "No";
                btnPrestar.Enabled = false;
                DialogResult dialogResult = MessageBox.Show("Prestamo Exitoso\nDesea agregar otro?", "Exito!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.No) {
                    Prestamos prestamo = new Prestamos(carnet, password, conn);
                    prestamo.Show();
                    this.Hide();
                    conn.Close();
                }
                conn.Close();
            }
            catch (Exception ex) {
                MessageBox.Show("Error, este libro ya se encuentra prestado");
            }
            finally {
                conn.Close();
            }
        }
    }
}
