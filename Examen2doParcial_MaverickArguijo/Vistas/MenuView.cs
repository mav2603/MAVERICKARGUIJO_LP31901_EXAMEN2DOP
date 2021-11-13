using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen2doParcial_MaverickArguijo.Vistas
{
    public partial class MenuView : Syncfusion.Windows.Forms.Office2010Form
    {
        public MenuView()
        {
            InitializeComponent();
        }

        SoporteView vistaTipoSoporte;
        EstadoView vistaEstado;
        TicketView vistaCreacion;
        DetallesView vistaDetalle;


        private void Vista_FormClosedTipo(object sender, FormClosedEventArgs e)
        {
            vistaTipoSoporte = null;
        }


        private void Vista_FormClosedEstado(object sender, FormClosedEventArgs e)
        {
            vistaEstado = null;
        }

        private void Vista_FormClosedCreacion(object sender, FormClosedEventArgs e)
        {
            vistaCreacion = null;
        }

        private void Vista_FormClosedDetalle(object sender, FormClosedEventArgs e)
        {
            vistaDetalle = null;
        }

        private void SoporteToolStripButton_Click(object sender, EventArgs e)
        {
            if (vistaTipoSoporte == null)
            {
                vistaTipoSoporte = new SoporteView();
                vistaTipoSoporte.MdiParent = this;
                vistaTipoSoporte.FormClosed += Vista_FormClosedTipo;
                vistaTipoSoporte.Show();
            }
            else
            {
                vistaTipoSoporte.Activate();
            }
        }

        private void EstadoToolStripButton_Click_1(object sender, EventArgs e)
        {
            if (vistaEstado == null)
            {
                vistaEstado = new EstadoView();
                vistaEstado.MdiParent = this;
                vistaEstado.FormClosed += Vista_FormClosedEstado;
                vistaEstado.Show();
            }
            else
            {
                vistaEstado.Activate();
            }
        }

        private void CrearToolStripButton_Click_1(object sender, EventArgs e)
        {
            if (vistaCreacion == null)
            {
                vistaCreacion = new TicketView();
                vistaCreacion.MdiParent = this;
                vistaCreacion.FormClosed += Vista_FormClosedCreacion;
                vistaCreacion.Show();
            }
            else
            {
                vistaCreacion.Activate();
            }
        }

        private void DetalleToolStripButton_Click_1(object sender, EventArgs e)
        {
            if (vistaDetalle == null)
            {
                vistaDetalle = new DetallesView();
                vistaDetalle.MdiParent = this;
                vistaDetalle.FormClosed += Vista_FormClosedDetalle;
                vistaDetalle.Show();
            }
            else
            {
                vistaDetalle.Activate();
            }
        }
    }
}
