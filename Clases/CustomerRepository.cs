namespace Clases;

public class CustomerRepository
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }

    /// <summary>
    /// Constructor de la clase <see cref="CustomerRepository"/>
    /// </summary>
    /// <param name="name">Nombre</param>
    /// <param name="lastName">Apellido</param>
    /// <param name="email">Email</param>
    /// <param name="phone">Telefono</param>
    /// <param name="address">Direccion</param>
    public CustomerRepository(string name, string lastName, string email, string phone, string address)
    {
        Name = name;
        LastName = lastName;
        Email = email;
        Phone = phone;
        Address = address;
    }
    
}