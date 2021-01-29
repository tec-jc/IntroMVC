using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntroMVC.Models
{
    public class Contacto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Movil { get; set; }
        public string Telefono { get; set; }

        public Contacto() { }

        public Contacto(int pId, string pNombre, string pEmail, string pMovil, string pTelefono)
        {
            Id = pId;
            Nombre = pNombre;
            Email = pEmail;
            Movil = pMovil;
            Telefono = pTelefono;
        }
    }
}