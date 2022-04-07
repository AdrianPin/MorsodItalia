using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorsodItalia.BL
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var nuevoUsuario = new Usuario();
            nuevoUsuario.Nombre = "admin";
            nuevoUsuario.Contrasena = Encriptar.CodificarContrasena("123");
            contexto.Usuarios.Add(nuevoUsuario);

            var Usuario1 = new Usuario();
            Usuario1.Nombre = "maryelaa";
            Usuario1.Contrasena = Encriptar.CodificarContrasena("456");
            contexto.Usuarios.Add(Usuario1);

            var Usuario2 = new Usuario();
            Usuario2.Nombre = "adrianp";
            Usuario2.Contrasena = Encriptar.CodificarContrasena("789");
            contexto.Usuarios.Add(Usuario2);

            var Usuario3 = new Usuario();
            Usuario3.Nombre = "josem";
            Usuario3.Contrasena = Encriptar.CodificarContrasena("012");
            contexto.Usuarios.Add(Usuario2);

            var Usuario4 = new Usuario();
            Usuario4.Nombre = "manuels";
            Usuario4.Contrasena = Encriptar.CodificarContrasena("345");
            contexto.Usuarios.Add(Usuario4);

            var Usuario5 = new Usuario();
            Usuario5.Nombre = "erikoc";
            Usuario5.Contrasena = Encriptar.CodificarContrasena("678");
            contexto.Usuarios.Add(Usuario5);


            base.Seed(contexto);
        }
    }
}