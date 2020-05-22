using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1.Data.Model
{
    public class Asiento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public bool Libre { get; set; }

        public Asiento()
        {
            
        }

    }
}
