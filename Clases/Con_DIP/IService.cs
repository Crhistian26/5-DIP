using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Con_DIP
{
    /// <summary>
    /// Interfaz que representa un servicio para los clientes
    /// </summary>
    public interface IService
    {
        public string GetFullName();
        public string GetContactInfo();
    }
}
