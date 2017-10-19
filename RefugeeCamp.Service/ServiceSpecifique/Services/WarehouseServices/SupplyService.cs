﻿using RefugeeCamp.Data.Infrastructure;
using RefugeeCamp.Domaine.Entity;
using RefugeeCamp.Service.ServicePattern;
using RefugeeCamp.Service.ServiceSpecifique.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugeeCamp.Service.ServiceSpecifique.Services
{
    public class SupplyService : Service<Supply>, ISupplyService
    {
        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork uof = new UnitOfWork(dbf);

        public SupplyService() : base(uof)
        {

        }
    }
}