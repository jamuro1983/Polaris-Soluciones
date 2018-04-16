using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebRegionalismos.Models
{
    public class RepositorioPalabraDefinicion
    {

        public List<Definicion> listarDefinicionPalabra()
        {
            using (RegionalismoContexto contexto = new RegionalismoContexto())
            {
            
                return contexto.Definicion.Include("Palabra").Include("Idioma").Include("Pais").ToList();
            }
        }

        public void AgregarPalabraDefinicion(Definicion definicion)
        {
            using (RegionalismoContexto contexto = new RegionalismoContexto())
            {
                contexto.Definicion.Add(definicion);

                contexto.SaveChanges();
            }
        }

    }
}