using Examen2doParcial_MaverickArguijo.Modelos.DAO;
using Examen2doParcial_MaverickArguijo.Modelos.Entidades;
using Examen2doParcial_MaverickArguijo.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2doParcial_MaverickArguijo.Controladores
{
   public class DetalleTicketController
    {
        DetallesView vista;
        DetalleDAO detalleDAO = new DetalleDAO();
        Detalle detalle = new Detalle();


        public DetalleTicketController(DetallesView view)
        {
            vista = view;
            vista.MostrarTicketButton.Click += new EventHandler(Load);
            vista.LimpiarButton.Click += new EventHandler(Limpiar);
        }

        private void Load(object serder, EventArgs e)
        {
            ListarTickets();
        }

        private void ListarTickets()
        {
            vista.DetalleDataGridView.DataSource = detalleDAO.GetDetalleTickets();
        }

        private void Limpiar(object serder, EventArgs e)
        {
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            vista.DetalleDataGridView.DataSource = null;
            vista.DetalleDataGridView.Refresh();
        }
    }
}
