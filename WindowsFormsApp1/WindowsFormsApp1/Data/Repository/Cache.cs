using System;
using System.Collections.Generic;
using System.Text;
using WindowsFormsApp1.Data.Model;

namespace WindowsFormsApp1.Data.Repository
{
    public class Cache
    {
        private static Cine _Data { get; set; }

        public static Cine GetData()
        {
            if(_Data == null)
            {
                _Data = new Cine();

                var sala1 = new Sala() { Id = 1, Nombre = "Sala 1" };
                
                for(var i = 0; i < 30; i++)
                    sala1.Asientos.Add(new Asiento() { Id = i + 1, Nombre = "Asiento " + (i + 1), Libre = true });

                _Data.Salas.Add(sala1);
            }

            return _Data;
        }
    }
}
