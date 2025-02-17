﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mezei_Adrian_Lab2.Models;

namespace Mezei_Adrian_Lab2.Data
{
    public class Mezei_Adrian_Lab2Context : DbContext
    {
        public Mezei_Adrian_Lab2Context (DbContextOptions<Mezei_Adrian_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Mezei_Adrian_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Mezei_Adrian_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Mezei_Adrian_Lab2.Models.Author> Author { get; set; } = default!;
        public DbSet<Mezei_Adrian_Lab2.Models.Category> Category { get; set; } = default!;
    }
}
