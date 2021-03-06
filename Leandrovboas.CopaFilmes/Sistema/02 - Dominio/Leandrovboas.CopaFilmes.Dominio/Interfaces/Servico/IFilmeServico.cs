﻿using Leandrovboas.CopaFilmes.Dominio.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Leandrovboas.CopaFilmes.Dominio.Interfaces.Servico
{
    public interface IFilmeServico
    {
        Task<IEnumerable<Filme>> GetAllAsync();
    }
}
