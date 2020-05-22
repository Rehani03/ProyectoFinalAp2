using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ProyectoFinalAp2.Controllers
{
    internal interface IRepository<T> where T : class
    {
        List<T> GetList(Expression<Func<T, bool>> expression);
        T Buscar(int ID);
        bool Guardar(T entity);
        bool Modificar(T entity);
        bool Eliminar(int ID);
    }
}