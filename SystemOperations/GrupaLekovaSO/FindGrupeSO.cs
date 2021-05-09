﻿using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.GrupaLekovaSO
{
    public class FindGrupeSO : SystemOperationBase
    {
        protected override object ExecuteSO(IEntity entity)
        {

            GrupaLekova grupa = (GrupaLekova)entity;
            return broker.Select(grupa).OfType<GrupaLekova>().ToList();

        }
    }
}
