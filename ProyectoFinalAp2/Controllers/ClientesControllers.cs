using Microsoft.EntityFrameworkCore;
using ProyectoFinalAp2.Data;
using ProyectoFinalAp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalAp2.Controllers
{
    public class ClientesControllers
    {
        private readonly Context db;

        public ClientesControllers()
        {
            db = new Context();
        }

        public bool Guardar(Clientes clientes)
        {
            bool paso = false;
            try
            {
                if (db.Clientes.Add(clientes) != null)
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

        public bool Modificar(Clientes clientes)
        {
            bool paso = false;

            try
            {
                db.Entry(clientes).State = EntityState.Modified;
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
                var aux = db.Clientes.Find(ID);
                db.Clientes.Remove(aux);

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

        public Clientes Buscar(int ID)
        {
            Clientes clientes = new Clientes();

            try
            {
                clientes = db.Clientes.Find(ID);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }

            return clientes;
        }
    }
}
