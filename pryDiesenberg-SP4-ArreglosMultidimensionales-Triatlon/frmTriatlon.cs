using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDiesenberg_SP4_ArreglosMultidimensionales_Triatlon
{
    public partial class frmTriatlon : Form
    {
        public struct DATOS
        {
            public int participante;
            public int puntos;
        }
        public frmTriatlon()
        {
            InitializeComponent();
        }


        private void frmTriatlon_Load(object sender, EventArgs e)
        {
            dgvGanadores.RowHeadersVisible = false;
            dgvParticipantes.RowHeadersVisible = false;
            dgvPosiciones.RowHeadersVisible = false;


            dgvParticipantes.ColumnCount = 3;
            dgvParticipantes.Columns[0].Name = "Número";
            dgvParticipantes.Columns[1].Name = "Nombre";
            dgvParticipantes.Columns[2].Name = "País";

            // Agregar filas (participantes)
            dgvParticipantes.Rows.Add("1", "Carlos", "Ar");
            dgvParticipantes.Rows.Add("2", "Juan", "Ch");
            dgvParticipantes.Rows.Add("3", "Pedro", "Br");
            dgvParticipantes.Rows.Add("4", "Luis", "Uy");
            dgvParticipantes.Rows.Add("5", "Marcos", "Pe");
            dgvParticipantes.Rows.Add("6", "Diego", "Ar");

            // desactivar fila vacía al final
            dgvParticipantes.AllowUserToAddRows = false;

            dgvPosiciones.ColumnCount = 7;
            dgvPosiciones.Columns[0].Name = "Prueba";
            dgvPosiciones.Columns[1].Name = "Carlos";
            dgvPosiciones.Columns[2].Name = "Juan";
            dgvPosiciones.Columns[3].Name = "Pedro";
            dgvPosiciones.Columns[4].Name = "Luis";
            dgvPosiciones.Columns[5].Name = "Marcos";
            dgvPosiciones.Columns[6].Name = "Diego";

            // Ejemplo de filas (podés cambiarlas después)
            dgvPosiciones.Rows.Add("Natación", "1", "3", "5", "2", "6", "4");
            dgvPosiciones.Rows.Add("Ciclismo", "3", "6", "4", "2", "1", "5");
            dgvPosiciones.Rows.Add("Carrera", "2", "1", "4", "3", "5", "6");

            dgvPosiciones.AllowUserToAddRows = false;

            dgvGanadores.ColumnCount = 4;
            dgvGanadores.Columns[0].Name = "Puesto";
            dgvGanadores.Columns[1].Name = "Nombre";
            dgvGanadores.Columns[2].Name = "País";
            dgvGanadores.Columns[3].Name = "Puntos";

            // Ejemplo de datos (podés calcularlos luego)
            dgvGanadores.Rows.Add("1", "Carlos", "Ar", "2750");
            dgvGanadores.Rows.Add("2", "Juan", "Ch", "2570");
            dgvGanadores.Rows.Add("3", "Luis", "Uy", "2400");

            dgvGanadores.AllowUserToAddRows = false;

            dgvParticipantes.RowHeadersVisible = false;
            dgvPosiciones.RowHeadersVisible = false;
            dgvGanadores.RowHeadersVisible = false;
        }

        private void dgvParticipantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private DATOS BuscarMayorPuntaje(DATOS[] participantes, DATOS[] ganadoresPrevios)
        {
            DATOS mayor = new DATOS { participante = -1, puntos = -1 };

            foreach (var p in participantes)
            {
                // Saltar si ya está en los ganadores anteriores
                bool yaElegido = false;
                foreach (var g in ganadoresPrevios)
                {
                    if (g.participante == p.participante)
                    {
                        yaElegido = true;
                        break;
                    }
                }
                if (yaElegido) continue;

                if (p.puntos > mayor.puntos)
                {
                    mayor = p;
                }
            }

            return mayor;
        }
        private void MostrarGanadores(DATOS[] ganadores, DataGridView dgvGanadores, DataGridView dgvParticipantes)
        {
            dgvGanadores.Rows.Clear();

            for (int fila = 0; fila < 3; fila++)
            {
                dgvGanadores.Rows.Add();
                dgvGanadores.Rows[fila].Cells[0].Value = fila + 1; // Puesto final

                int f = ganadores[fila].participante; // índice en dgvParticipantes

                dgvGanadores.Rows[fila].Cells[1].Value = dgvParticipantes.Rows[f].Cells[1].Value.ToString(); // nombre
                dgvGanadores.Rows[fila].Cells[2].Value = dgvParticipantes.Rows[f].Cells[2].Value.ToString(); // nacionalidad
                dgvGanadores.Rows[fila].Cells[3].Value = ganadores[fila].puntos.ToString(); // puntos
            }

            dgvGanadores.ClearSelection();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            int i;
            dgvPosiciones.Rows.Clear();
            // verificar que estén cargados todos los participantes
            for (i = 0; i < 6; i++)
            {
                if (dgvParticipantes.Rows[i].Cells[1].Value == null ||
                dgvParticipantes.Rows[i].Cells[2].Value == null)
                {
                    MessageBox.Show("Debe completar los datos de todos los participantes",
                    "Error", MessageBoxButtons.OK);
                    return;
                }
            }
            // configurar las columnas de la grilla
            for (i = 0; i < 6; i++)
            {
                dgvPosiciones.Columns[i + 1].HeaderText =
                dgvParticipantes.Rows[i].Cells[1].Value.ToString();
            }
            // configurar las filas con las 3 pruebas del Triatlón
            for (i = 0; i < 3; i++)
            {
                dgvPosiciones.Rows.Add();
            }
            dgvPosiciones.Rows[0].Cells[0].Value = "Natación";
            dgvPosiciones.Rows[1].Cells[0].Value = "Ciclismo";
            dgvPosiciones.Rows[2].Cells[0].Value = "Carrera";
            dgvPosiciones.Columns[0].ReadOnly = true;
            dgvParticipantes.ClearSelection();
            dgvPosiciones.Enabled = true;
        }
        private bool ValidarPosiciones()
        {
            int fila, col;
            for (fila = 0; fila < 3; fila++)
            {
                for (col = 0; col < 6; col++)
                {
                    var celda = dgvPosiciones.Rows[fila].Cells[col + 1].Value;

                    if (celda == null) return false; // si está vacía
                    if (!int.TryParse(celda.ToString(), out int valor)) return false; // si no es número
                    if (valor < 1 || valor > 6) return false; // si no está entre 1 y 6
                }
            }
            return true; // todo está correcto
        }
        private int ObtenerPuntos(int puesto)
        {
            switch (puesto)
            {
                case 1: return 1000;
                case 2: return 920;
                case 3: return 830;
                case 4: return 740;
                case 5: return 650;
                case 6: return 560;
                default: return 0; // para cualquier valor inválido
            }
        }

        private void btnDeterminar_Click(object sender, EventArgs e)
        {
            int fila;
            int col;
            int i;
            string valor;
            string nombre;
            string nacionalidad;
            // controlar los datos ingresados en la grilla de posiciones
            if (!ValidarPosiciones())
            {
                MessageBox.Show("Los datos son incorrectos, revise las posiciones asignadas",
                "Error", MessageBoxButtons.OK);
                return;
            }
            dgvPosiciones.ClearSelection();
            int[,] puestos = new int[3, 6]; // arreglo bidimensional
                                            // copiar el contenido de la grilla al arreglo bidimensional
            for (fila = 0; fila < 3; fila++) // se recorren las filas de la grilla
            {
                for (col = 0; col < 6; col++) // se recorren las columnas de la grilla
                {
                    // obtener el valor de cada celda
                    valor = dgvPosiciones.Rows[fila].Cells[col + 1].Value.ToString();
                    puestos[fila, col] = int.Parse(valor); // convertirlo a entero
                }
            }
            // inicializar el arreglo para computar los puntos de cada participante
            DATOS[] datos = new DATOS[6];
            for (i = 0; i < 6; i++)
            {
                datos[i].participante = i + 1; // número de participante
                datos[i].puntos = 0; // cantidad de puntos del participante
            }
            // recorrer el arreglo bidimensional de los puestos y sumar los puntos
            for (col = 0; col < 6; col++) // las columnas son los participantes
            {
                // las filas son las posiciones obtenidas por cada participante
                for (fila = 0; fila < 3; fila++)
                {
                    datos[col].puntos += ObtenerPuntos(puestos[fila, col]);
                }
            }
            // arreglo de tipo DATOS para los ganadores
            DATOS[] ganadores = new DATOS[3];
            // obtener el primer puesto
            ganadores[0] = BuscarMayorPuntaje(datos, ganadores);
            // obtener el segundo puesto
            ganadores[1] = BuscarMayorPuntaje(datos, ganadores);
            // obtener el tercer puesto
            ganadores[2] = BuscarMayorPuntaje(datos, ganadores);
            MostrarGanadores(ganadores, dgvGanadores, dgvParticipantes);
        }

    }
}
