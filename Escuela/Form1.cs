using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Escuela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Conectamos los botonos con sus eventos
            btnGuardar.Click += btnGuardar_Click;
            btnMostrar.Click += btnMostrar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            //Consultamo los alumnos al abrir la ventana
            Load += Form1_Load;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtGrupo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarAlumno();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Validamos que los datos no esten vacios
            if (string.IsNullOrWhiteSpace(txtMatricula.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtGrupo.Text) ||
                string.IsNullOrWhiteSpace(txtEspecialidad.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar." +
                    "Datos Incompletos",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (OleDbConnection conexion =
                    ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string consulta =
                        "INSERT INTO Alumnos " +
                        "(Matricula, Nombre, Semestre, Grupo, Especialidad) " +
                        "VALUES (?, ?, ?, ?, ?)";
                    using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                    {
                        //Con OleDB importa el oreden de los parámetros
                        comando.Parameters.Add(
                            "?", OleDbType.VarWChar, 20
                            ).Value = txtMatricula.Text.Trim();
                        comando.Parameters.Add(
                            "?", OleDbType.VarWChar, 100
                            ).Value = txtNombre.Text.Trim();
                        comando.Parameters.Add(
                            "?", OleDbType.Integer
                            ).Value = int.Parse(nudSemestre.Text);
                        comando.Parameters.Add(
                            "?", OleDbType.VarWChar, 20
                            ).Value = txtGrupo.Text.Trim();
                        comando.Parameters.Add(
                            "?", OleDbType.VarWChar, 20
                            ).Value = txtEspecialidad.Text.Trim();
                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el alumno: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarAlumno()
        {
            try
            {
                using (OleDbConnection conexion =
                    ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string consulta =
                        "SELECT idAlumno, Matricula, Nombre, Semestre, Grupo, Especialidad " +
                        "FROM Alumnos Order By IdAlumno";
                    using (OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);
                        dgvAlumnos.DataSource = tabla;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los alumnos: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }
    }
}
