using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets
{
   public class Ticket
    {
        private int tipo;
        private string color;
        private double tamanio;
        private int cantidad;


        // Tipo
        public int getTipo()
        {
            return tipo;
        }

        public void setTipo(int tipo)
        {
            if (tipo == 1 || tipo == 2 || tipo == 3)
            {
                this.tipo = tipo;
            }else
            {
                this.tipo = 1;
            }
        }

        // Color

        public string getColor()
        {
            return color;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        // Tamaño

        public double getTamanio()
        {
            return tamanio;
        }

        public void setTamanio(double tamanio)
        {
            this.tamanio = tamanio;
        }
        // Cantidad
        public int getCantidad()
        {
            return cantidad;
        }

        public void setCantidad(int cantidad)
        {
            if (cantidad > 0)
            {
                this.cantidad = cantidad;
            }else
            {
                this.cantidad = 1;
            }
        }

        // Calcular Tipo
        public int calcularTipo()
        {
            int tipo = this.tipo;
            switch (tipo)
            {
                case 1:
                    return 5;
                case 2:
                    return 8;
                case 3:
                    return 10;

                default:
                    return 0;
            }
        }


        // Calcular Precio
        public double calcularPrecio()
        {
            int resultado = calcularTipo();
            return resultado * this.cantidad;
        }
    }
}
