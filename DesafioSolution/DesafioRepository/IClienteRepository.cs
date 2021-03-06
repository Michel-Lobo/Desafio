﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioRepository
{
    public interface IClienteRepository: IRepository<Cliente>
    {
        void Update(Cliente cliente);
    }
}
