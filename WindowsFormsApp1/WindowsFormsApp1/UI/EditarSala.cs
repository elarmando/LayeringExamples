using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp1.Data.Model;
using WindowsFormsApp1.Logic;

namespace WindowsFormsApp1.UI
{
    public partial class EditarSala : Form
    {
        public SalaLogic SalaLogic { get; set; }
        public EditarSala(SalaLogic logic)
        {
            InitializeComponent();
            SalaLogic = logic;

            Render();
        }

        public void Render()
        {
            var Sala = SalaLogic.Sala;
            txtId.Text = Sala.Id + "";
            txtNombre.Text = Sala.Nombre;

            var asientosTxt = string.Empty;

            foreach(var e in Sala.Asientos)
            {
                asientosTxt += e.Id + ", " + e.Nombre + ", " + ((e.Libre) ? "Libre " : " Ocupado") + "\r\n";
            }

            txtAsientos.Text = asientosTxt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOcupar_Click(object sender, EventArgs e)
        {
            try
            {
                var id = txtIdAsiento.Text;

                if (!string.IsNullOrEmpty(id))
                {
                    var idAsiento = int.Parse(id);
                    SalaLogic.Ocupar(idAsiento);
                    Render();
                }
            }
            catch (Exception)
            {
            }
        }

        private void liberar_Click(object sender, EventArgs e)
        {
            try
            {
                var id = txtIdAsiento.Text;

                if (!string.IsNullOrEmpty(id))
                {
                    var idAsiento = int.Parse(id);
                    SalaLogic.Liberar(idAsiento);
                    Render();
                }

            }
            catch (Exception)
            {
            }
        }
    }
}
