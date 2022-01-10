using ProyectoCoreEF.Data;
using ProyectoCoreEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCoreEF.Repositories
{
    public class RepositoryHospital
    {
        private HospitalContext context;
        public RepositoryHospital(HospitalContext context)
        {
            this.context = context;
        }

        public List<Hospital> GetHospitales()
        {
            var consulta = from datos in this.context.Hospitales select datos;
            return consulta.ToList();
        }

        public Hospital FindHospital(int id)
        {
            var consulta = from datos in this.context.Hospitales where datos.IdHospital == id select datos;
            if (consulta.Count() == 0)
            {
                return null;
            } else
            {
                return consulta.First();
            }
        }
    }
}
