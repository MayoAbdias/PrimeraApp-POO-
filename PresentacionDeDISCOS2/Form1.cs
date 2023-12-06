using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace PresentacionDeDISCOS2
{
    public partial class Form1 : Form
    {
        private List<Discos> listaDiscos;
        public Form1()
        {
            InitializeComponent();
        }
        public void cargar()
        {
            DiscoNegocio negocio = new DiscoNegocio();
            try
            {
                listaDiscos = negocio.Listar();
                dgvDiscos.DataSource = listaDiscos;
                ocultarColumnas();

                cargarImagen(listaDiscos[0].UrlImagenTapa);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }
        public void cargarImagen(string imagen)
        {
            try
            {
                pictureBoxDiscos.Load(imagen);
            }
            catch (Exception ex)
            {

                pictureBoxDiscos.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
            }
        }
        public void ocultarColumnas()
        {
            dgvDiscos.Columns["UrlImagenTapa"].Visible = false;
            dgvDiscos.Columns["Id"].Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvDiscos.CurrentRow != null)
            {
                Discos seleccionado = (Discos)dgvDiscos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagenTapa);
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            FrmDiscoNuevo nuevo = new FrmDiscoNuevo();
            nuevo.ShowDialog();
            cargar();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Discos seleccionado;
                seleccionado = (Discos)dgvDiscos.CurrentRow.DataBoundItem;
                FrmDiscoNuevo modificado = new FrmDiscoNuevo(seleccionado);

                modificado.ShowDialog();
                cargar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            DiscoNegocio negocio = new DiscoNegocio();
            Discos seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro queres eliminar este disco?","ESTE DISCO ESTA POR SER ELIMINADO..",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                if(respuesta == DialogResult.OK)
                {
                    seleccionado = (Discos)dgvDiscos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        private void textBoxFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Discos> listaFiltrada;
            string filtro = textBoxFiltro.Text;

            if(filtro != "")
            {
                listaFiltrada = listaDiscos.FindAll(x => x.Titulo.ToLower().Contains(filtro.ToLower()) || x.estilo.Descripcion.ToLower().Contains(filtro.ToLower()));

            }
            else
            {
                listaFiltrada = listaDiscos;
            }
            dgvDiscos.DataSource = null;
            dgvDiscos.DataSource = listaFiltrada;
            ocultarColumnas();
        }
    }
}
