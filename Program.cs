using Tickets;

namespace proyectoTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket oTicket = new Ticket();
            oTicket.setColor("Naranja");
            oTicket.setTamanio(2);
            oTicket.setTipo(3);
            oTicket.setCantidad(120);

            // Consola

            Console.WriteLine("Color de la pelota: " + oTicket.getColor());
            Console.WriteLine("Tipo: " + oTicket.getTipo());
            Console.WriteLine("El pago total es: " + oTicket.calcularPrecio());
        }
    }
}