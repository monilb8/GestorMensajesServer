﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formulario.Servicios
{
    public interface IPeliculaService
    {
        Pelicula Create(Pelicula pelicula);
        Pelicula Get(long id);
        IQueryable<Pelicula> Get();
        void Put(Pelicula pelicula);
        Pelicula Delete(long id);
    }
}
