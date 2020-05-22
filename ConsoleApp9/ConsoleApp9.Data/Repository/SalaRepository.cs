using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleApp9.Data.Model;
using ConsoleApp9.Data.Repository;

namespace ConsoleApp9.Data.Repository
{
    public class SalaRepository
    {
        public void Agregar(Sala id)
        {

        }

        public void Borrar(int id)
        {

        }

        public void Modificar(Sala sala)
        {
            var cine = Cache.GetData();
            var salaVieja = cine.Salas.FirstOrDefault(e => e.Id == sala.Id);

            if(salaVieja != null)
            {
                salaVieja.Id = sala.Id;
                sala.Nombre = sala.Nombre;
                sala.Asientos = sala.Asientos;
            }
        }

        public List<Sala> Obtener()
        {
            return Cache.GetData().Salas;
        }

        //public List<Sala> ObtenerSalasVacias()
        //{

        //}
    }
}
