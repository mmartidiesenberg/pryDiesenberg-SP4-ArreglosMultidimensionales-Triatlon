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
        public frmTriatlon()
        {
            InitializeComponent();
        }

        private void frmTriatlon_Load(object sender, EventArgs e)
        {
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
    }
}
