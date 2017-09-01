using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ConnectionActor
    {
        private static string _ServerAddress = "201.54.201.18";

        public static void RequestUsers(User pUser)
        {
            try
            {
                string message = GenerateRequestUsersRequest(pUser);

                // Create a TcpClient.
                // Note, for this client to work you need to have a TcpServer 
                // connected to the same address as specified by the server, port
                // combination.
                Int32 port = 1012;

                using (TcpClient client = new TcpClient(_ServerAddress, port))
                {
                    // Translate the passed message into ASCII and store it as a Byte array.
                    Byte[] data = System.Text.Encoding.UTF8.GetBytes(message);

                    // Get a client stream for reading and writing.
                    //  Stream stream = client.GetStream();

                    using (NetworkStream stream = client.GetStream())
                    {
                        // Send the message to the connected TcpServer. 
                        stream.Write(data, 0, data.Length);

                        Console.WriteLine("Sent: {0}", message);

                        // Receive the TcpServer.response.

                        // Buffer to store the response bytes.
                        data = new Byte[256];

                        // String to store the response ASCII representation.
                        String responseData = String.Empty;

                        // Read the first batch of the TcpServer response bytes.
                        Int32 bytes = stream.Read(data, 0, data.Length);
                        responseData = System.Text.Encoding.UTF8.GetString(data, 0, bytes);
                        Console.WriteLine("Received: {0}", responseData);

                        pUser.UnformatedUserList = responseData;

                        // Close everything.
                    }
                }
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
        }

        public static void ReceiveMessage(User pUser)
        {
            try
            {
                string message = GenerateReceiveMessageRequest(pUser);

                // Create a TcpClient.
                // Note, for this client to work you need to have a TcpServer 
                // connected to the same address as specified by the server, port
                // combination.
                Int32 port = 1012;

                using (TcpClient client = new TcpClient(_ServerAddress, port))
                {
                    // Translate the passed message into ASCII and store it as a Byte array.
                    Byte[] data = System.Text.Encoding.UTF8.GetBytes(message);

                    // Get a client stream for reading and writing.
                    //  Stream stream = client.GetStream();

                    using (NetworkStream stream = client.GetStream())
                    {
                        // Send the message to the connected TcpServer. 
                        stream.Write(data, 0, data.Length);

                        Console.WriteLine("Sent: {0}", message);

                        // Receive the TcpServer.response.

                        // Buffer to store the response bytes.
                        data = new Byte[256];

                        // String to store the response ASCII representation.
                        String responseData = String.Empty;

                        // Read the first batch of the TcpServer response bytes.
                        Int32 bytes = stream.Read(data, 0, data.Length);
                        responseData = System.Text.Encoding.UTF8.GetString(data, 0, bytes);
                        Console.WriteLine("Received: {0}", responseData);

                        if(responseData != null && responseData.TrimEnd().TrimStart() != ":")
                            pUser.MessagesList += string.Format("\n{0}", responseData);
                    }
                }
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
        }

        public static void SendMessage(User pUser, Message pMessage)
        {
            try
            {
                string message = GenerateSendMessageRequest(pUser, pMessage);

                // Create a TcpClient.
                // Note, for this client to work you need to have a TcpServer 
                // connected to the same address as specified by the server, port
                // combination.
                Int32 port = 1011;

                using (UdpClient client = new UdpClient(_ServerAddress, port))
                {

                    client.Connect(_ServerAddress, 1011);
                    // Translate the passed message into ASCII and store it as a Byte array.
                    Byte[] data = System.Text.Encoding.UTF8.GetBytes(message);
                    client.Send(data, data.Length);

                    Console.WriteLine("Sent: {0}", message);

                    /*IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                    Byte[] receiveBytes = client.Receive(ref RemoteIpEndPoint);
                    string returnData = Encoding.ASCII.GetString(receiveBytes);
                    Console.WriteLine("Received: {0}", returnData.ToString());*/
                }
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
        }

        private static string GenerateRequestUsersRequest(User pUser)
        {
            return string.Format("GET USERS {0}:{1}", pUser.LoginUser, pUser.PasswordUser);
        }

        private static string GenerateSendMessageRequest(User pUser, Message pMessage)
        {
            return string.Format("SEND MESSAGE {0}: {1}: {2}:{3}", pUser.LoginUser, pUser.PasswordUser, pMessage.UserCodeDestination, pMessage.MessageContent);
        }

        private static string GenerateReceiveMessageRequest(User pUser)
        {
            return string.Format("GET MESSAGE {0}: {1}", pUser.LoginUser, pUser.PasswordUser);
        }
    }
}
