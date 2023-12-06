using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace PresentacionDeDISCOS2
{
    
    public partial class FrmDiscoNuevo : Form
    {
        private Discos disco = null;
        public FrmDiscoNuevo()
        {
            InitializeComponent();
        }
        public FrmDiscoNuevo(Discos disco)
        {
            InitializeComponent();
            this.disco = disco;
            Text = "Modificar disco";
        }

        private void FrmDiscoNuevo_Load(object sender, EventArgs e)
        {
            EstiloNegocio estiloNegocio = new EstiloNegocio();
            TipoEdicionNegocio tipoEdicionNeg = new TipoEdicionNegocio();

            try
            {
                comboBoxEstilo.DataSource = estiloNegocio.listar();
                comboBoxEstilo.ValueMember = "Id";
                comboBoxEstilo.DisplayMember = "Descripcion";
                comboBoxTipoEdicion.DataSource = tipoEdicionNeg.listar();
                comboBoxTipoEdicion.ValueMember = "Id";
                comboBoxTipoEdicion.DisplayMember = "Descripcion";

                if(disco != null)
                {
                    textBoxTitulo.Text = disco.Titulo;
                    textBoxFechaLanzamiento.Text = disco.FechaLanzamiento.ToString();
                    textBoxCantidadCanciones.Text = disco.CantidadCanciones.ToString();
                    textBoxUrlImagenNueva.Text = disco.UrlImagenTapa;
                    cargarImagenNueva(disco.UrlImagenTapa);
                    comboBoxEstilo.SelectedValue = disco.estilo.Id;
                    comboBoxTipoEdicion.SelectedValue = disco.tipoEdicion.Id;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
        public void cargarImagenNueva(string imagen)
        {
            try
            {
                pictureBoxImagenNueva.Load(imagen);
            }
            catch (Exception ex)
            {

                pictureBoxImagenNueva.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
            }
           
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            DiscoNegocio negocio = new DiscoNegocio();
            try
            {
                
                if (disco == null)
                    disco = new Discos();
                disco.Titulo = textBoxTitulo.Text;
                disco.FechaLanzamiento = DateTime.Parse(textBoxFechaLanzamiento.Text);
                disco.CantidadCanciones = int.Parse(textBoxCantidadCanciones.Text);
                disco.UrlImagenTapa = textBoxUrlImagenNueva.Text;
                disco.estilo = (Estilo)comboBoxEstilo.SelectedItem;
                disco.tipoEdicion = (TipoEdicion)comboBoxTipoEdicion.SelectedItem;

                if (textBoxTitulo.Text == string.Empty)
                {
                    error.SetError(Owner, "Revise los campos");
                }


                if (disco.Id != 0 )
                {
                    negocio.modificar(disco);
                    MessageBox.Show("Su disco se modifico exitosamente");
                }
                else
                {
                    negocio.agregar(disco);
                    MessageBox.Show("Su disco se agrego exitosamente");
                }
               
               
                Close();

            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Complete los campos vacios..");
            }
            
            
                
            

        }

        private void textBoxUrlImagenNueva_Leave(object sender, EventArgs e)
        {
            cargarImagenNueva(textBoxUrlImagenNueva.Text);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        ErrorProvider error = new ErrorProvider();

        private void textBoxTitulo_Leave(object sender, EventArgs e)
        {
            if (ValidacionTextBox.textVacios(textBoxTitulo))
            {
                error.SetError(textBoxTitulo, "Este campo no puede estar vacio..");
                
            }
            else
            {
                error.Clear();
            }

        }

        private void textBoxFechaLanzamiento_Leave(object sender, EventArgs e)
        {
            if (ValidacionTextBox.textVacios(textBoxFechaLanzamiento))
            {
                error.SetError(textBoxFechaLanzamiento, "Este campo es obligatorio..");
            }
            else
            {
                error.Clear();
            }
        }

        private void textBoxCantidadCanciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidacionTextBox.soloNumeros(e);
            if (!valida)
            {
                error.SetError(textBoxCantidadCanciones, "Este campo solo acepta números..");
            }
            else
            {
                error.Clear();
            }
        }

        private void textBoxFechaLanzamiento_Validating(object sender, CancelEventArgs e)
        {
            DateTime fechaLanzamiento;

            if(!DateTime.TryParse(textBoxFechaLanzamiento.Text, out fechaLanzamiento))
            {
                error.SetError(textBoxFechaLanzamiento, "Utilice el formato DD/MM/YYYY");
            }
            else
            {
                error.Clear();
            }
        }

        private void textBoxCantidadCanciones_Leave(object sender, EventArgs e)
        {
            if (ValidacionTextBox.textVacios(textBoxCantidadCanciones))
            {
                error.SetError(textBoxCantidadCanciones, "Este campo no puede estar vacio");
            }
            else
            {
                ErrorBlinkStyle.BlinkIfDifferentError.ToString();
            }
        }
    }
}
