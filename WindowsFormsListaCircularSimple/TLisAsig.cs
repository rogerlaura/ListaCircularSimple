using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsListaCircularSimple
{
    internal class TLisAsig:TLista
    {
        public TLisAsig() : base() { }

        public void crearLista(string a, int hr)
        {
            insertar(new TNodoAsig(a, hr));
        }

        public TNodo sucessor()
        {
            return getProxCursor();
        }

        public TNodo antecessor()
        {
            return getAntCursor();
        }

        public bool eliminarLista()
        {
            eliminar();
            return true;
        }
        public bool BuscarAsig(String nom)
        {
            bool bus = false;
            TNodo p;
            p = primero;
            while (p != null && bus == false)
            {
                if (((TNodoAsig)p).dameAsig().Equals(nom))
                    bus = true;
                else
                    p = p.pEnlace;
            }
            if (bus)
                cursor = p;
            return bus;
        }
        public void Listar(ListBox lista,ListBox horas)
        {
            lista.Items.Clear();
            horas.Items.Clear();
            if (this.vacia())
            {
                MessageBox.Show("LA LISTA ESTA VACIA");

            }
            else
            {
                TNodo puntero = this.primero;
                do
                {
                    lista.Items.Add(((TNodoAsig)puntero).dameAsig());
                    horas.Items.Add(((TNodoAsig)puntero).dameHoras().ToString());
                    puntero = puntero.pEnlace;
                } while (puntero != primero);
                

            }
        }
        public void Seleccionar(ListBox lista)
        {
            if (!this.vacia())
            {
                TNodo puntero = this.primero;
                int i = 0;
                do
                {
                    if (((TNodoAsig)getCursor()).dameAsig().Equals(((TNodoAsig)puntero).dameAsig()))
                    {
                        lista.SetSelected(i, true);
                    }
                    puntero = puntero.pEnlace;
                    i++;
                } while (puntero != primero);
            }
        }
    }
}
