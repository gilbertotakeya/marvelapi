﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marvel.Models
{
    public class ConsultaMarvelQuadrinhoNivel2ViewModel
    {
        public int offset { get; set; }
        public int limit { get; set; }
        public int total { get; set; }
        public int count { get; set; }
        public List<ConsultaMarvelQuadrinhoNivel3ViewModel> results { get; set; }
    }
}