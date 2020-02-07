using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using Cliente.Clases;

namespace Cliente
{
    public partial class FrmCliente : Form
    {
        private Usuario nuevoUsuario;
        private TcpClient cliente;

        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            cliente = new TcpClient(txtDireccionServidor.Text, 8080);
            if (cliente.Connected)
                MessageBox.Show("Estamos conectados.... Puedes enviar los datos!");
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            nuevoUsuario = new Usuario(txtNombre.Text,
                Convert.ToInt32(txtEdad.Text),
                Convert.ToChar(txtSexo.Text),
                Convert.ToDecimal(txtSalario.Text));

            BinaryWriter datos = new BinaryWriter(new BufferedStream(cliente.GetStream()));
            datos.Write(nuevoUsuario.Nombre);
            datos.Write(nuevoUsuario.Edad);
            datos.Write(nuevoUsuario.Sexo);
            datos.Write(nuevoUsuario.Salario);
            datos.Flush();

            BinaryReader datosRx = new BinaryReader(new BufferedStream(cliente.GetStream()));
            string mensaje1 = datosRx.ReadString();
            string mensaje2 = datosRx.ReadString();
            string mensaje3 = datosRx.ReadString();
            string mensaje4 = datosRx.ReadString();
            lsbInfo.Items.Add(mensaje1);
            lsbInfo.Items.Add(mensaje2);
            lsbInfo.Items.Add(mensaje3);
            lsbInfo.Items.Add(mensaje4);
        }
    }
}