using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RRHH.BL
{
    public class SeguridadBL
    {
        #region Inicializar Lista
        Contexto _contexto;
        public BindingList<Usuario> ListaSeguridad { get; set; }

        public SeguridadBL()
        {
            _contexto = new Contexto();
            ListaSeguridad = new BindingList<Usuario>();
        }
        public BindingList<Usuario> ObtenerUsuario()
        {
            //_contexto.Usuarios.Include("Privilegio").Load();
            _contexto.Usuarios.Load();
            //_contexto.Privilegios.Load();

            ListaSeguridad = _contexto.Usuarios.Local.ToBindingList();
            return ListaSeguridad;
        }

        #endregion



        // GUARDAD
        public Resultado3 GuardarUsuario(Usuario usuario)
        {
            var resultado = Validar(usuario);

            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }

        //CANCELAR CAMBIOS
        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        //AGREGAR
        public void AgregarUsuario()
        {
            var nuevoUsuario = new Usuario();
            ListaSeguridad.Add(nuevoUsuario);
        }

        //ELIMINAR
        public bool EliminarUsuario(int id)
        {
            foreach (var usuario in ListaSeguridad)
            {
                if (usuario.Id == id)
                {
                    ListaSeguridad.Remove(usuario);
                    _contexto.SaveChanges();

                    return true;
                }
            }
            return false;
        }

        //VALIDACION
        private Resultado3 Validar(Usuario usuario )
        {
            var resultado = new Resultado3();           
            resultado.Exitoso = true;

            //if(usuario.Contrasena.Length < 6)
            //{
            //    resultado.Mensaje = "La contraseña es menor a 6";
            //    resultado.Exitoso = false;
            //}

            if (string.IsNullOrEmpty(usuario.Nombre) == true)
            {
                resultado.Mensaje = "Ingrese un Nombre";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(usuario.Apellido) == true)
            {
                resultado.Mensaje = "Ingrese un Apellido";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(usuario.Correo) == true)
            {
                resultado.Mensaje = "Ingrese un Correo";
                resultado.Exitoso = false;
            }      
 
            if (usuario.edad <= 0)
            {
                resultado.Mensaje = "Ingrese una Edad";
                resultado.Exitoso = false;
            }

            if (usuario.Cedula <= 0)
            {
                resultado.Mensaje = "Ingrese un numero de Cedula";
                resultado.Exitoso = false;
            }

            //SEGURIDAD
            if (string.IsNullOrEmpty(usuario.NombUsuario) == true)
            {
                resultado.Mensaje = "Ingrese un Nombre de Usuario";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(usuario.Contrasena) == true)
            {
                resultado.Exitoso = false;
                resultado.Mensaje = "Ingrese una contraseña";
            }

            if (usuario.PrivilegioId <= 0)
            {
                resultado.Mensaje = "Seleccion un Privilegio";
                resultado.Exitoso = false;
            }

            return resultado;
        }

        #region Autorizacion

        public Usuario Autorizar(string usuario, string contrasena)
        {
            var usuarios = _contexto.Usuarios.ToList();
            _contexto.Usuarios.Include("Privilegio").Load();
            foreach (var usuarioDB in usuarios)
            {
                if (usuario == usuarioDB.NombUsuario && contrasena == usuarioDB.Contrasena)
                {
                    return usuarioDB;
                    
                }
            }

            return null;
        }
    }

    #endregion

    public class Usuario
    {
        public int Id { get; set; }
        public byte[] Foto { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public int edad { get; set; }
        public DateTime FechaInicio { get; set; }
        public double Cedula { get; set; }

        //SEGURIDAD
        public string NombUsuario { get; set; }
        public string Contrasena { get; set; }

        public int PrivilegioId { get; set; }
        public Privilegio Privilegio { get; set; }

        public Usuario()
        {
            FechaInicio = DateTime.Now;
        }
    }

    public class Resultado3
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }

}