using Clases;
using Clases.Con_DIP;

namespace Principio_DIP;

class Program
{
    static void Main(string[] args)
    {
        //Aca se crea a Juan un repositorio de cliente
        //y se le asigna el servicio de cliente
        CustomerRepository Juan = new CustomerRepository("Juan","Carrasco","juan@gmail.com", "123456789", "Calle 123");
        CustomerService JuanService = new CustomerService(Juan);

        //Aca se imprime el nombre completo y la informacion de contacto
        //Claro estas son las clases sin el principio de invercion de dependencias
        Console.WriteLine(JuanService.GetFullName());
        Console.WriteLine(JuanService.GetContactInfo());

        //Aca se crea a Jhan un repositorio de cliente
        //y se le asigna el servicio de cliente
        DIP_Customer_Repository Jhan = new DIP_Customer_Repository("Jhan","Terrero","Jhan@gmail.com", "987654321", "Calle 456");
        DIP_Customer_Service JhanService = new DIP_Customer_Service(Jhan);

        //Aca se imprime el nombre completo y la informacion de contacto
        //Claro estas son las clases con el principio de invercion de dependencias
        Console.WriteLine(JhanService.GetFullName());
        Console.WriteLine(JhanService.GetContactInfo());
        Console.ReadKey();

    }
}
