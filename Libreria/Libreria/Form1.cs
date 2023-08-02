using System.Data.SqlClient;
using System.Data;

namespace Libreria {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        public int carnet;
        public string password;
        public SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-FVRTN89\SQLEXPRESS;Initial Catalog=Librearia;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void txtEnter_Click(object sender, EventArgs e) {

            carnet = Convert.ToInt32(txtCarnet.Text);
            password = txtPass.Text;

            try {
                string querry = "SELECT * FROM Usuarios WHERE Carnet = " + carnet + " AND Contraseña = '" + password + "'";
                SqlDataAdapter dsa = new SqlDataAdapter(querry, conn);

                DataTable dt = new DataTable();
                dsa.Fill(dt);

                if (dt.Rows.Count > 0) {
                    Menu menuform = new Menu(carnet, password, conn);
                    menuform.Show();
                    this.Hide();
                }
                else {
                    MessageBox.Show("Datos no validos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCarnet.Clear();
                    txtPass.Clear();
                    txtCarnet.Focus();
                }
            }
            catch (Exception E) {
                MessageBox.Show("Error" + E);
            }
            finally {
                conn.Close();
            }
        }

        private void txtExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void txtClear_Click(object sender, EventArgs e) {
            txtCarnet.Clear();
            txtPass.Clear();
        }
    }
}