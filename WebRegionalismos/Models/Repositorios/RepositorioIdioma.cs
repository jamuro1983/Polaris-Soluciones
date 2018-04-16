using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebRegionalismos.Models
{
    public class RepositorioIdioma
    {

        public Idioma BuscarIdioma(Int64 IdIdioma)
        {
            using (RegionalismoContexto contexto = new RegionalismoContexto())
            {
                return contexto.Idioma.Find(IdIdioma);
            }
        }

        public void AgregarIdioma(Idioma idioma)
        {
            using (RegionalismoContexto contexto = new RegionalismoContexto())
            {
                contexto.Idioma.Add(idioma);
                contexto.SaveChanges();
            }
        }

        public void EditarIdioma(Idioma idioma)
        {
            using (RegionalismoContexto contexto = new RegionalismoContexto())
            {
                contexto.Entry(idioma).State = EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void EliminarIdioma(Idioma idioma)
        {
            using (RegionalismoContexto contexto = new RegionalismoContexto())
            {
                contexto.Entry(idioma).State = EntityState.Deleted;
                contexto.SaveChanges();
            }
        }

        public List<Idioma> ListarIdiomas()
        {
            using (RegionalismoContexto contexto = new RegionalismoContexto())
            {
                return contexto.Idioma.ToList();
            }
        }
    }
}