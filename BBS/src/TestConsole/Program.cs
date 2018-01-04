using System;
using System.Linq;
using TestConsole.BbsService;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceClient = new BbsServiceClient();

            serviceClient.ClientCredentials.UserName.UserName = "labas";
            serviceClient.ClientCredentials.UserName.Password = "labas";

            var greai = serviceClient.GetUsers().FirstOrDefault();

            var aybars = serviceClient.FindUser(1014);

            var aciu = serviceClient.GetRoles();

            var prasom = serviceClient.GetGendersAsync().Result;

            Console.WriteLine(greai);
        }
    }
}
