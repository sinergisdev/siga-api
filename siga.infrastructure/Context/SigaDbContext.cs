﻿using Microsoft.EntityFrameworkCore;
using siga.infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace siga.infrastructure.Context
{
    public class SigaDbContext : DbContext
    {

        //Constructor
        public SigaDbContext(DbContextOptions<SigaDbContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Faena> Faena { get; set; }

        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<Equipo> Equipo { get; set; }



    }
}
