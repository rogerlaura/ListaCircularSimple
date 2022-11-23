using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsListaCircularSimple
{
    internal class TLista
    {
        public TNodo primero;
        public TNodo ultimo;
        public TNodo cursor;



        public TLista()
        {
            primero = null;
            ultimo = null;
            cursor = null;
        }

        public void inicializar()
        {
            primero = null;
            ultimo = null;
            cursor = null;
        }

        public bool vacia()
        {
            if (primero == null)
                return true;
            else
                return false;
        }

        public void insertar(TNodo nodo)
        {
            if (vacia())
            {
                primero = nodo;
                ultimo = nodo;
                cursor = nodo;
                nodo.pEnlace = nodo;

            }


            else
            {
                
                ultimo.pEnlace = nodo;
                ultimo = nodo;
                cursor = nodo;
                nodo.pEnlace = primero;

            }
            

        }

        public TNodo eliminarprimero()
        {
            
            if (vacia())
                return null;
            else
            {
                TNodo nodoeliminado = this.primero;
                if (primero == ultimo)
                    inicializar();
                else
                {
                    if (cursor == primero)
                    {
                        cursor = getAntCursor();
                        
                       // cursor = primero;
                       

                    }
                    primero = primero.pEnlace; //sacar de la condicion
                    ultimo.pEnlace = primero;

                }
                return nodoeliminado;
            }

        }

        public TNodo eliminar()
        {
            TNodo pTemp,nodoeliminado;
            if (cursor == null)
                return null;
            else
            {
                if (cursor == primero)
                    return eliminarprimero();
                else
                {
                    nodoeliminado = getCursor();
                    pTemp = getAntCursor();
                    pTemp.pEnlace = cursor.pEnlace;
                    if (cursor == ultimo)
                    {
                        ultimo = pTemp;
                        cursor = pTemp; // Añadir
                        this.ultimo.pEnlace = this.primero; // Solo para Lista Enlazada Circular
                    }
                    else
                    {
                        cursor = pTemp.pEnlace; //añadir
                    }
                        
                    
                    return nodoeliminado;
                }
            }
        }


        public TNodo getPrimero()
        {
            return primero;
        }

        public TNodo getUltimo()
        {
            return ultimo;
        }

        public TNodo getCursor()
        {
            return cursor;
        }
        public TNodo getProxCursor()
        {
            if (cursor != null)
                return cursor.pEnlace;
            else
                return null;

        }

        public TNodo getAntCursor()
        {
            TNodo pTemp;
            pTemp = primero;
            while (pTemp.pEnlace != cursor)
                pTemp = pTemp.pEnlace;
            return pTemp;


        }

        public void setCursor(TNodo p)
        {
            cursor = p;
        }
    }
}
