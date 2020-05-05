using Microsoft.EntityFrameworkCore;
using ProyectoFinalAp2.Data;
using ProyectoFinalAp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProyectoFinalAp2.Controllers
{
    public class CategoriaControllers
    {
        private readonly Context db;

        public CategoriaControllers()
        {
            db = new Context();
        }

        public bool Guardar(Categorias categoria)
        {
            bool paso = false;
            try
            {
                if (db.Categorias.Add(categoria) != null)
                    paso = db.SaveChanges() > 0;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }

        public  bool Modificar(Categorias categorias)
        {
            bool paso = false;

            try
            {
                db.Entry(categorias).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }

        public virtual bool Eliminar(int ID)
        {
            bool paso = false;
            try
            {
                var aux = db.Categorias.Find(ID);
                db.Categorias.Remove(aux);

                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }


            return paso;
        }

        public Categorias Buscar(int ID)
        {
            Categorias categorias = new Categorias();

            try
            {
                categorias = db.Categorias.Find(ID);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }

            return categorias;
        }

    }
}
