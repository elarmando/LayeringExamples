using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9.Data.Model
{
    public class Sala
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Asiento> Asientos { get; set; }

        public int Porcentaje { get; set; }

        public Sala()
        {
            Asientos = new List<Asiento>();
        }
    }
}
