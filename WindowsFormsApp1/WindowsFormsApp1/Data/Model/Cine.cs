using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1.Data.Model
{
    public class Cine
    {
        public List<Sala> Salas { get; set; }

        public Cine()
        {
            Salas = new List<Sala>();
        }
    }
}
