﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NADD.Mapeamento;
using NADD.Models.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NADD.Models
{
    public class Contexto : IdentityDbContext<UsuarioDaAplicacao>
    {
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
        //Criação das tabelas no BD

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
            base.OnModelCreating(modelBuilder);
            //Aplicação dos Relacionamentos das teblas

            modelBuilder.ApplyConfiguration(new AreaMap());
            modelBuilder.ApplyConfiguration(new CursoMap());
            modelBuilder.ApplyConfiguration(new DisciplinaMap());
            modelBuilder.ApplyConfiguration(new ProfessorMap());
            modelBuilder.ApplyConfiguration(new AvaliacaoMap());
            modelBuilder.ApplyConfiguration(new QuestoesMap());

            //Opcoes para Mapeamento

            /*modelBuilder.Entity<Professor>()
                .HasMany(c => c.Disciplinas).WithMany(i => i.Professores)
                .Map(t => t.MapLeftKey("ProfessorID")
                    .MapRightKey("DisciplinaID")
                    .ToTable("Professor")); */

            //Relationship Many to Many para Disciplina e Professor
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
