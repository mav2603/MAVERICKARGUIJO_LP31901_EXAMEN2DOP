using Examen2doParcial_MaverickArguijo.Modelos.DAO;
using Examen2doParcial_MaverickArguijo.Modelos.Entidades;
using Examen2doParcial_MaverickArguijo.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2doParcial_MaverickArguijo.Controladores
{
    public class LoginController
    {
        LoginView vista;
        

        public LoginController(LoginView loginView)
        {
            vista = loginView;
            vista.btnaceptar.Click += new EventHandler(ValidarUsuario);
        }

        private void ValidarUsuario(object server, EventArgs e)
        {
            bool esValido = false;
            UsuarioDAO userDao = new UsuarioDAO();
            Usuario user = new Usuario();

            user.Email = vista.txtemail.Text;
            user.Clave = EncriptarClave(vista.txtclave.Text);

            esValido = userDao.ValidarUsuario(user);

            if (esValido)
            {
                MessageBox.Show("Usuario Correcto");

                MenuView menu = new MenuView();
                vista.Hide();

                menu.Show();

            }
            else
            {
                MessageBox.Show("Usuario Incorrecto");
            }
        }

        private string EncriptarClave(string str)
        {
            string cadena = str + "MiClavePersonal";
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(cadena));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
    }
}
