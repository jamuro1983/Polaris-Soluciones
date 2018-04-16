using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;

namespace WebRegionalismos.Models
{
    public class RepositorioPais
    {
        public Pais BuscarPais(string IdPais)
        {
            using (RegionalismoContexto contexto = new RegionalismoContexto())
            {
                return contexto.Pais.Find(IdPais);
            }
        }


        public void AgregarPais(Pais pais)
        {
            using (RegionalismoContexto contexto = new RegionalismoContexto())
            {
                contexto.Pais.Add(pais);
                contexto.SaveChanges();
            }
        }

        public void EditarPais(Pais pais)
        {
            using (RegionalismoContexto contexto = new RegionalismoContexto())
            {
                contexto.Entry(pais).State = EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void EliminarPais(Pais pais)
        {
            using (RegionalismoContexto contexto = new RegionalismoContexto())
            {
                contexto.Entry(pais).State = EntityState.Deleted;
                contexto.SaveChanges();
            }
        }

        public List<Pais> ListarPaises()
        {
            using (RegionalismoContexto contexto = new RegionalismoContexto())
            {
                return contexto.Pais.ToList();
            }
        }

    
    }
}