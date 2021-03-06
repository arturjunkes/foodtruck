﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodtruck.Negocio.Models
{
    public abstract class Produto
    {
        public long Id { get; set; }
        public String Nome { get; set; }
        public decimal Valor { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
        public abstract String Descrever();
    }
}
