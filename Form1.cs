using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Lista3_ListDataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Persona> Listadgv = new List<Persona>();
        public void guardarpersona()
        {
            Persona persona1 = new Persona(txtnombre.Text, txtapellido.Text, int.Parse(txtedad.Text));
            Listadgv.Add(persona1);
            dgvlista.DataSource = null;
            dgvlista.DataSource = Listadgv;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnguardarpersona_Click(object sender, EventArgs e)
        {
            guardarpersona();
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
