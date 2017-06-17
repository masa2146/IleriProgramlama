using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Client
{
    class Client
    {
        static void Main(string[] args)
        {
            StartClient();
            Console.ReadLine();
            
        }

        public static void StartClient()
        {
            // gelen veriler için veri arabelleği
            byte[] bytes = new byte[1024];

            //uzak bir aygıta bağlanma
            try
            {
                //Soket için uzak  uç noktasını kurma
                /*
                 Bu örnek, yerel bilgisayarda 
                 11000 numaralı bağlantı noktasını kullanmakta
                 */
                IPHostEntry ipEntry = Dns.Resolve(Dns.GetHostName());
                IPAddress ipAdress = ipEntry.AddressList[0];
                IPEndPoint endPoint = new IPEndPoint(ipAdress, 11000);

                // TCP/IP soketi oluşturuyoruz
                Socket sender = new Socket(AddressFamily.InterNetwork,
                    SocketType.Stream,ProtocolType.Tcp);

                // Soketi uzak uç noktasına bağlama. Herhangi br hata yakalama

                try
                {
                    sender.Connect(ipAdress,11000);
 
                    Console.WriteLine("Socket connected to {0}",
                   sender.RemoteEndPoint.ToString());
                    //gereksiz o andaki enpoint gösteriyor

                    // Veri dizisini bir byte dizisine kopyalayın
                    byte[] msg = Encoding.ASCII.GetBytes("Fatih BULUT<EOF>");

                    // Verileri soketten gönderin
                    int bytesSent = sender.Send(msg);

                    //Uzak cihazdan gelen yanıtı al.
                    int bytesRec = sender.Receive(bytes);
                    Console.WriteLine("Echoed test = {0}",
                        Encoding.ASCII.GetString(bytes,0,bytesRec));

                    //Soketi serbest bırak
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();


                }

                catch (ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unexpected exception : {0}", e.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
