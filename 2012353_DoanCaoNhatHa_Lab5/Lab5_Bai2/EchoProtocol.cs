using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab5_Bai2
{
    class EchoProtocol : IProtocol
    {
        public const int BUFSIZE = 32;
        private Socket clnSock;
        private ILogger logger;
        public EchoProtocol(Socket clnSock, ILogger logger)
        {
            this.clnSock = clnSock;
            this.logger = logger;
        }
        public void handleClient()
        {
            ArrayList entry = new ArrayList();
            entry.Add("Client address and port = " + clnSock.RemoteEndPoint);
            entry.Add("Thread = " + Thread.CurrentThread.GetHashCode());
            try
            {
                int recMsgSize;
                int totalBytesEchoed = 0;
                byte[] rcvBuffer = new byte[BUFSIZE];
                try
                {
                    while ((recMsgSize = clnSock.Receive(rcvBuffer, 0, rcvBuffer.Length, SocketFlags.None)) > 0)
                    {
                        clnSock.Send(rcvBuffer, 0, recMsgSize, SocketFlags.None);
                        totalBytesEchoed += recMsgSize;
                    }
                }
                catch (SocketException se)
                {
                    entry.Add(se.ErrorCode + ": " + se.Message);
                }
                catch (IOException i)
                {
                    entry.Add("ERROR: " + i.Message);
                }
                entry.Add("Client finished; echoed " + totalBytesEchoed + " bytes.");
            }
            catch (SocketException se)
            {
                entry.Add(se.ErrorCode + ": " + se.Message);
            }
            clnSock.Close();
            logger.Write(entry);
        }
    }
}
