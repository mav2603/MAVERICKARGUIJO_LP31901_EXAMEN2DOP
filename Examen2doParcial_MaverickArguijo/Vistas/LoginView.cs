﻿using Examen2doParcial_MaverickArguijo.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2doParcial_MaverickArguijo.Vistas
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
            LoginController controlador = new LoginController(this);
        }
    }
}
