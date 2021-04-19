﻿using System;
using System.Collections.Generic;
using System.Text;
using TrabalhoIHM.Domain.Entidades;
using TrabalhoIHM.Domain.Interfaces.Repositorio;

namespace TrabalhoIHM.Data.Repositories
{
    
    public class AlunoRepository : Repository<Aluno>, IAlunoRepository
    {
        public AlunoRepository(EscolaContext context) : base(context)
        {
        }

    }
}
