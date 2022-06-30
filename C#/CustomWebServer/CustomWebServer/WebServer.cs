using System;
using System.Net.Sockets;
using System.Text;
namespace CustomWebServer
{
	public class WebServer
	{
		private readonly TcpListener listener; // represents the port we are listening on 

		public WebServer(int portNumber)
		{
			listener = TcpListener.Create(portNumber); // listens for requests
		}

		private static byte[] Header(int contentLength)
		{
			return Encoding.ASCII.GetBytes(
				"HTTP/1.1 200\r\n" // HTTP version number and status code 200 (OK)
			  + "Server: My Simple Web Server\r\n" // Application name
			  + $"Content-Length: {contentLength}\r\n" // Length of the data we send
			  + "Connection: keep-alive\r\n" // Connection type
			  + "Content-Type: text/html\r\n\r\n"); // Content type
		}

		public void Start()
        {
			listener.Start();
            while (true)
            {

                Console.WriteLine("Listening for requests...");
				Socket socket = listener.AcceptSocket();
				byte[] buffer = new byte[1024];
				socket.Receive(buffer, SocketFlags.None);
				Console.WriteLine("Message received!");

				byte[] response = Controller(buffer);

				// create response
											

				socket.Send(Header(response.Length), SocketFlags.None); // sends a HTTP formatted header first
				socket.Send(response, SocketFlags.None); // sends data.
                Console.WriteLine("Response served!");
            }
        }
		public byte[] Controller(byte[] request) // Controller maps the request to the response.
        {
			string message = Encoding.ASCII.GetString(request);
            Console.WriteLine(message);

			// CRUD = Create, Read, Update, Delete
			// HTTP = Post, Get, Patch/Put, Delete	

			// create message

			if(message.Contains("Get /page", StringComparison.OrdinalIgnoreCase))
            {
				return File.ReadAllBytes(@"Page.html");
            }

            //if (message.Contains("Delete /page", StringComparison.OrdinalIgnoreCase))
            //{

            //}


            else
            {
			return File.ReadAllBytes(@"index.html");

            }
		}
	}
}

