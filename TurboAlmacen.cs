using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;

namespace TurboSys
{
    public partial class TurboAlmacen : Form
    {
        CN_Almacen objetoCD = new CN_Almacen();
        public TurboAlmacen()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarAlmacen();
        }
        private void MostrarAlmacen()
        {
            dataGridView1.DataSource = objetoCD.MostrarAlmacen();

        }
    }
}
