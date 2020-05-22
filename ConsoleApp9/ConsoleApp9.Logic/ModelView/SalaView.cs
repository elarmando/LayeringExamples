using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9.ModelView
{
    public class SalaView
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<AsientoView> Asientos { get; set; }

        public int Porcentaje { get; set; }

        public SalaView()
        {
            Asientos = new List<AsientoView>();
        }
    }
}
