using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9.ModelView
{
    public class Cine
    {
        public List<SalaView> Salas { get; set; }

        public Cine()
        {
            Salas = new List<SalaView>();
        }
    }
}
