﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.entidades
{
    public class Cliente
    {
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public DateTime dataNascimento { get; set; }
        public int habilitacao { get; set; }
        public string Estado  { get ; set; }


    }
}
