using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Servidor
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener socketEscucha = new TcpListener(IPAddress.Any, 8080);

            socketEscucha.Start();
            using (TcpClient cliente = socketEscucha.AcceptTcpClient())
            using (NetworkStream datos = cliente.GetStream())
            {
                string mensaje1 = new BinaryReader(datos).ReadString();
                string mensaje2 = new BinaryReader(datos).ReadInt32().ToString();
                string mensaje3 = new BinaryReader(datos).ReadChar().ToString();
                string mensaje4 = new BinaryReader(datos).ReadDecimal().ToString();
                BinaryWriter datosEco = new BinaryWriter(datos);
                datosEco.Write(mensaje1 + " \n Recibido!!");
                datosEco.Write(mensaje2 + " \n Recibido!!");
                datosEco.Write(mensaje3 + " \n Recibido!!");
                datosEco.Write(mensaje4 + " \n Recibido!!");
                datosEco.Flush();
            }
            socketEscucha.Stop();
        }
    }
}