using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Con_DIP
{
    /// <summary>
    /// Clase que representa el servicio de cliente, pero enlazada a la interfaz <see cref="IService"/>
    /// </summary>
    public class DIP_Customer_Service : IService
    {
        public IRepository Repository { get; set; }

        /// <summary>
        /// Constructor de la clase <see cref="DIP_Customer_Service"/>
        /// </summary>
        /// <param name="repository">Un elemento con la interfaz de <see cref="IRepository"/></param>
        public DIP_Customer_Service(IRepository repository)
        {
            Repository = repository;
        }

        /// <summary>
        /// Metodo que devuelve el nombre completo del cliente
        /// </summary>
        /// <returns>Nombre y apellido</returns>
        public string GetFullName()
        {
            return $"{Repository.Name} {Repository.LastName}";
        }

        /// <summary>
        /// Metodo que devuelve la informacion de contacto del cliente
        /// </summary>
        /// <returns>Email y telefono</returns>
        public string GetContactInfo()
        {
            return $"Email: {Repository.Email}, Phone: {Repository.Phone}";
        }
    }
}
