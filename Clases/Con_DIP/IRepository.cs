using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Con_DIP
{
    /// <summary>
    /// Interfaz que representa el repositorio de cliente
    /// </summary>
    public interface IRepository
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }   
    }
}
