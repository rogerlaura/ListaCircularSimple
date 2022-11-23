using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsListaCircularSimple
{
    public partial class Form1 : Form
    {
        TLisAsig tlista;
        public Form1()
        {
            tlista= new TLisAsig();
            InitializeComponent();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            int horas = int.Parse(txthoras.Text);
            tlista.crearLista(nombre,horas);
            tlista.Listar(listaAsignatura,listahoras);
            lblcursor.Text = ((TNodoAsig)tlista.getCursor()).dameAsig();
            tlista.Seleccionar(listaAsignatura);
            txtnombre.Clear();
            txthoras.Clear();
            txtnombre.Focus();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            tlista.eliminarLista();
            tlista.Listar(listaAsignatura,listahoras);
            tlista.Seleccionar(listaAsignatura);
            //lblcursor.Text = ((TNodoAsig)tlista.getCursor()).dameAsig();
            txtnombre.Clear();
            txthoras.Clear();
            txtnombre.Focus();

        }

        private void btnprimero_Click(object sender, EventArgs e)
        {
            txtnombre.Text=((TNodoAsig)tlista.getPrimero()).dameAsig();
            txthoras.Text = ((TNodoAsig)tlista.getPrimero()).dameHoras().ToString();
            lblcursor.Text= ((TNodoAsig)tlista.getCursor()).dameAsig();
            //tlista.Seleccionar(listaAsignatura);
        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            
            txtnombre.Text=((TNodoAsig)tlista.antecessor()).dameAsig();
            txthoras.Text = ((TNodoAsig)tlista.antecessor()).dameHoras().ToString();
            lblcursor.Text = ((TNodoAsig)tlista.getCursor()).dameAsig();
            //tlista.Seleccionar(listaAsignatura);
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            
            txtnombre.Text=((TNodoAsig)tlista.sucessor()).dameAsig();
            txthoras.Text = ((TNodoAsig)tlista.sucessor()).dameHoras().ToString();
            lblcursor.Text = ((TNodoAsig)tlista.getCursor()).dameAsig();
            //tlista.Seleccionar(listaAsignatura);
        }

        private void btnultimo_Click(object sender, EventArgs e)
        {
            
            txtnombre.Text = ((TNodoAsig)tlista.getUltimo()).dameAsig();
            txthoras.Text = ((TNodoAsig)tlista.getUltimo()).dameHoras().ToString();
            lblcursor.Text = ((TNodoAsig)tlista.getCursor()).dameAsig();
            //tlista.Seleccionar(listaAsignatura);
        }

        private void listaAsignatura_SelectedIndexChanged(object sender, EventArgs e)
        {
            tlista.BuscarAsig(listaAsignatura.Text);
            lblcursor.Text = ((TNodoAsig)tlista.getCursor()).dameAsig();
        }
    }
}
