using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Con_DIP
{
    /// <summary>
    /// Clase que representa el repositorio de cliente, pero enlazada a la interfaz <see cref="IRepository"/>
    /// </summary>
    public class DIP_Customer_Repository : IRepository
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Address { get; set; }

        /// <summary>
        /// Constructor de la clase <see cref="DIP_Customer_Repository"/>
        /// </summary>
        /// <param name="name">Nombre</param>
        /// <param name="lastName">Apellido</param>
        /// <param name="email">Email</param>
        /// <param name="phone">Telefono</param>
        /// <param name="address">Direccion</param>
        public DIP_Customer_Repository(string name, string lastName, string email, string phone, string address)
        {
            Name = name;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Address = address;
        }
    }
}
