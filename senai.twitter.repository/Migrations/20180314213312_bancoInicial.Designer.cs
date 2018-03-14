﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using senai.twitter.repository.Context;
using System;

namespace senai.twitter.repository.Migrations
{
    [DbContext(typeof(BikeMobiContext))]
    [Migration("20180314213312_bancoInicial")]
    partial class bancoInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("senai.twitter.domain.Entities.Login", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AtualizadoEm");

                    b.Property<string>("AtualizadoPor");

                    b.Property<DateTime>("CriadoEm");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("NomeUsuario")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("QtdAtualizacoes");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("NomeUsuario")
                        .IsUnique();

                    b.ToTable("Logins");
                });

            modelBuilder.Entity("senai.twitter.domain.Entities.Perfil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AtualizadoEm");

                    b.Property<string>("AtualizadoPor");

                    b.Property<string>("AvatarUrl")
                        .HasMaxLength(200);

                    b.Property<string>("Bio")
                        .HasMaxLength(200);

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("CriadoEm");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("IdLogin");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("QtdAtualizacoes");

                    b.HasKey("Id");

                    b.HasIndex("IdLogin")
                        .IsUnique();

                    b.ToTable("Perfis");
                });

            modelBuilder.Entity("senai.twitter.domain.Entities.RotaPesquisada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AtualizadoEm");

                    b.Property<string>("AtualizadoPor");

                    b.Property<DateTime>("CriadoEm");

                    b.Property<string>("DestinoEnd")
                        .IsRequired();

                    b.Property<double>("DestinoLat");

                    b.Property<double>("DestinoLng");

                    b.Property<int>("Distancia");

                    b.Property<string>("Duracao")
                        .IsRequired();

                    b.Property<int>("IdLogin");

                    b.Property<string>("OrigemEnd")
                        .IsRequired();

                    b.Property<double>("OrigemLat");

                    b.Property<double>("OrigemLng");

                    b.Property<string>("PolylinePoints")
                        .IsRequired();

                    b.Property<int>("QtdAtualizacoes");

                    b.HasKey("Id");

                    b.HasIndex("IdLogin");

                    b.ToTable("RotasPesquisadas");
                });

            modelBuilder.Entity("senai.twitter.domain.Entities.Perfil", b =>
                {
                    b.HasOne("senai.twitter.domain.Entities.Login", "Login")
                        .WithOne("Perfil")
                        .HasForeignKey("senai.twitter.domain.Entities.Perfil", "IdLogin")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("senai.twitter.domain.Entities.RotaPesquisada", b =>
                {
                    b.HasOne("senai.twitter.domain.Entities.Login", "Login")
                        .WithMany("RotasPesquisas")
                        .HasForeignKey("IdLogin")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}