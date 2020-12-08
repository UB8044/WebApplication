using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ServiceReservasi;

namespace ServerReservasi_044
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost obj = null;
            try
            {
                obj = new ServiceHost(typeof(Service1));
                obj.Open();
                Console.WriteLine("Server is Ready!!!");
                Console.ReadLine();
                obj.Close();
            }
            catch (Exception ex)
            {
                obj = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
