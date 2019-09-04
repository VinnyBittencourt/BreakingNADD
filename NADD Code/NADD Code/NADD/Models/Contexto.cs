﻿using Microsoft.EntityFrameworkCore;
using NADD.Mapeamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NADD.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Area> Area { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Disciplina> Disciplina { get; set; }
        public DbSet<Avaliacao> Avaliacao { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<Questoes> Questoes { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AreaMap());
            modelBuilder.ApplyConfiguration(new CursoMap());


            /*modelBuilder.Entity<Professor>()
                .HasMany(c => c.Disciplinas).WithMany(i => i.Professores)
                .Map(t => t.MapLeftKey("ProfessorID")
                    .MapRightKey("DisciplinaID")
                    .ToTable("Professor")); */

            modelBuilder.Entity<DisciplinaProfessor>()
                .HasKey(bc => new { bc.DisciplinaId, bc.ProfessorId });
            modelBuilder.Entity<DisciplinaProfessor>()
                .HasOne(bc => bc.Disciplina)
                .WithMany(b => b.DisciplinaProfessor)
                .HasForeignKey(bc => bc.DisciplinaId);
            modelBuilder.Entity<DisciplinaProfessor>()
                .HasOne(bc => bc.Professor)
                .WithMany(c => c.DisciplinaProfessor)
                .HasForeignKey(bc => bc.ProfessorId);
        }
    }
}
