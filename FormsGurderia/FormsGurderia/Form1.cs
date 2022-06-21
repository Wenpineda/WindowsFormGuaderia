using System.Data;
using System.Data.SqlClient;

namespace FormsGurderia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-GCJF4AE;Initial Catalog=BDDguarderia;Integrated Security=true");

        private void Form1_Load(object sender, EventArgs e)
        {
            String Select = "Select * from niños";
            SqlDataAdapter adapter = new SqlDataAdapter(Select, conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO niños (id,nombre, apellido, edad, sexo) VALUES (@id,@nombre, @apellido, @edad, @sexo)";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@id", textBoxID);
            comando.Parameters.AddWithValue("@nombre", textBoxnombre.Text);
            comando.Parameters.AddWithValue("@apellido", textBoxgenero.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro Exitoso");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM niños WHERE idniños=" + textBoxID + "";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@id", textBoxID);
            comando.ExecuteNonQuery();
            MessageBox.Show("Se elimino correctamente");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Cliente (id,nombre, apellido, edad, sexo, ) VALUES (@id,@nombre, @apellido, @edad, @sexo,)";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@id", textBoxID);
            comando.Parameters.AddWithValue("@nombre", textBoxnombre.Text);
            comando.Parameters.AddWithValue("@apellido", textBoxapellido.Text);
            comando.Parameters.AddWithValue("@edad", textBoxedad.Text);
            comando.Parameters.AddWithValue("@sexo", textBoxgenero.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Se ha actualizado Corectamente");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}