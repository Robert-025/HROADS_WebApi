﻿using System;
using System.Collections.Generic;

#nullable disable

namespace senai_hroads_webApiDBFirst.Domains
{
    public partial class TiposUsuario
    {
        public TiposUsuario()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int IdTipoUsuario { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
