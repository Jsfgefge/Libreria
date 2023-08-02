using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Libreria {
    internal class Datos {
        public int Carnet;
        public string Contra;
        public string Nombre;
        public string Apellido;
        public string Prestamo;
        public int Rango;
        public string Solvencia;
        

        //clase para obtener los datos de la persona que inicio sesion
        //esto para tener en todo momento informacion de ingreso y verificar que en todo momento
        //solo los respectivos rangos de usuario tienen acceso a solo determinadas partes del
        //programa
        public Datos(int aCarnet, string aContra, SqlConnection conn) {
            try {
                string querry = "SELECT * FROM Usuarios WHERE Carnet = " + aCarnet + " AND Contraseña = '" + aContra + "'";
                SqlDataAdapter dsa = new SqlDataAdapter(querry, conn);

                DataTable dt = new DataTable();
                dsa.Fill(dt);

                if (dt.Rows.Count > 0) {
                    foreach (DataRow dr in dt.Rows) {
                        Carnet = Convert.ToInt32(dr["Carnet"]);
                        Contra = dr["Contraseña"].ToString();
                        Nombre = dr["Nombre"].ToString();
                        Apellido = dr["Apellido"].ToString();
                        Prestamo = dr["Prestamo"].ToString();
                        Rango = Convert.ToInt32(dr["Rango"]);
                        Solvencia = dr["Solvencia"].ToString();
                    }
                }
                else {
                    MessageBox.Show(aContra+"Con Car "+aCarnet, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
