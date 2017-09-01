﻿using GestorMensajesServer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GestorMensajesServer.Repository
{
    public class EntradaRepository : IEntradaRepository
    {
        public Entrada Create(Entrada entrada)
        {
            return ApplicationDbContext.applicationDbContext.Entrada.Add(entrada);
        }

        public Entrada Get(long id)
        {
            return ApplicationDbContext.applicationDbContext.Entrada.Find(id);
        }

        public IQueryable<Entrada> Get()
        {
            IList<Entrada> lista = new List<Entrada>(ApplicationDbContext.applicationDbContext.Entrada);

            return lista.AsQueryable();
        }


        public void Put(Entrada entrada)
        {
            if (ApplicationDbContext.applicationDbContext.Entrada.Count(e => e.Id == entrada.Id) == 0)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }
            ApplicationDbContext.applicationDbContext.Entry(entrada).State = EntityState.Modified;
        }

        public Entrada Delete(long id)
        {
            Entrada entrada = ApplicationDbContext.applicationDbContext.Entrada.Find(id);
            if (entrada == null)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }

            ApplicationDbContext.applicationDbContext.Entrada.Remove(entrada);
            return entrada;
        }
    }
}