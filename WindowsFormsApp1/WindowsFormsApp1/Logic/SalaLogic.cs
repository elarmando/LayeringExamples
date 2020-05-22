using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApp1.Data.Model;
using WindowsFormsApp1.Data.Repository;

namespace WindowsFormsApp1.Logic
{
    public class SalaLogic
    {
        private SalaRepository Repo { get; set; }
        public Sala Sala { get; set; }

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

        private void Update()
        {
            Repo.Modificar(Sala);
        }


    }
}
