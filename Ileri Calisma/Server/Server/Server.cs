using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    class Server
    {

        //clientten Gelen veriler
        public static string data = null;
        static void Main(string[] args)
        {
            StartListening();
        }

        public static void StartListening()
        {
            //Gelen veriler için veri arabelleği
            byte[] bytes = new Byte[1024];

            // Soket için yerel bitiş noktası oluşturun.
            // Dns.GetHostName, uygulamayı çalıştıran ana makinenin adını döndürür. 
            IPHostEntry ipEntry = Dns.Resolve(Dns.GetHostName());
            IPAddress ipAddress = ipEntry.AddressList[0];
            IPEndPoint endPoint = new IPEndPoint(ipAddress,11000);

            // TCP/IP socket oluştur
            Socket listener = new Socket(AddressFamily.InterNetwork
                ,SocketType.Stream,ProtocolType.Tcp);

            //Yuvayı yerel bitiş noktasına bağlayın
            //ve gelen bağlantıları dinleyin.
            try
            {
                listener.Bind(endPoint);
                listener.Listen(10);

                //Bağlantıları dinlemeye başlayın.
                while (true)
                {
                    Console.WriteLine("Waiting for a connection...");

                    // Program, gelen bir bağlantıyı beklerken askıya alınır
                    Socket handler = listener.Accept();
                    data = null;

                    //Gelen bir bağlantının işlenmesi gerekiyor.
                    while (true)
                    {
                        bytes = new byte[1024];
                        int bytesRec = handler.Receive(bytes);
                        data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                        if(data.IndexOf("<EOF>") > -1)
                        {
                            break;
                        }
                    }
                    // Verileri konsolda gösterin.
                    Console.WriteLine("Text received : {0}", data);

                    byte[] msg = Encoding.ASCII.GetBytes(data);

                    handler.Send(msg);
                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\nPress ENTER to continue...");
            Console.Read();

        }
    }
}
