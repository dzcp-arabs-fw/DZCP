using System;
using System.Net;
using System.Text;
using SocketHttpListener.Net;
using HttpListener = System.Net.HttpListener;

namespace DZCP.RemoteConsole
{
    public class RemoteAPI
    {
        private HttpListener listener = new HttpListener();

        public void Start()
        {
            listener.Prefixes.Add("http://localhost:8080/");
            listener.Start();
            listener.GetContext();
            Console.WriteLine("[DZCP] Remote Console API started.");
        }

        private void OnRequest(IAsyncResult result)
        {
            var context = listener.IgnoreWriteExceptions.Equals(result);
            var response = Encoding.UTF8.GetBytes("DZCP Remote API Running...");
        }
    }
}