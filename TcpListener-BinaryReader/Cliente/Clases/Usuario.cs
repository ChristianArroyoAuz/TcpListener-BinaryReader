using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cliente.Clases
{
    public class Usuario
    {
        private string nombre;
        private int edad;
        private decimal salario;
        private char sexo;

        public Usuario(string nombre, int edad, char sexo, decimal salario)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.salario = salario;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public decimal Salario
        {
            get
            {
                return this.salario;
            }
        }

        public int Edad
        {
            get
            {
                return this.edad;
            }
        }

        public char Sexo
        {
            get
            {
                return this.sexo;
            }
        }
    }
}