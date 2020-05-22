using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleApp9.Data.Model;
using ConsoleApp9.Data.Repository;
using ConsoleApp9.ModelView;

namespace ConsoleApp9.Logic
{
    public class SalaLogic
    {
        private SalaRepository Repo { get; set; }
        public Sala Sala { get; set; }

        public SalaLogic()
        {
            Repo = new SalaRepository();
            var salas = Repo.Obtener();
            Sala = salas.First();
        }
        public SalaLogic(Sala sala)
        {
            Repo = new SalaRepository();
            Sala = sala;
        }

        public void Liberar(int idasiento)
        {
            var asiento = Sala.Asientos.FirstOrDefault(e => e.Id == idasiento);

            if(asiento != null)
            {
                asiento.Libre = true;
                Update();
            }
        }

        public void Ocupar(int idasiento)
        {
            var asiento = Sala.Asientos.FirstOrDefault(e => e.Id == idasiento);

            if(asiento != null)
            {
                asiento.Libre = false;
                Update();
            }
        }

        public SalaView GetSalaView()
        {
            var salaView = new SalaView() { Id = Sala.Id, Nombre = Sala.Nombre };

            foreach(var asiento in Sala.Asientos)
            {
                salaView.Asientos.Add(new AsientoView() { Id = asiento.Id, Libre = asiento.Libre, Nombre = asiento.Nombre });

            }

            return salaView;
        }

        private void Update()
        {
            Repo.Modificar(Sala);
        }


    }
}
