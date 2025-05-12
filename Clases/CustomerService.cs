using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Clases;

// Esta clase es la que se encarga de manejar la logica de negocio
// y de interactuar con el repositorio de clientes
public class CustomerService 
{
    public CustomerRepository Repository {get; set;} 

    /// <summary>
    /// Constructor de la clase <see cref="CustomerService"/>
    /// </summary>
    /// <param name="repository">Repositorio del cliente</param>
    public CustomerService(CustomerRepository repository)
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
