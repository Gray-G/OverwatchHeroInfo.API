using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using OverwatchHeroInfo.API.Entities;
using OverwatchHeroInfo.API.Enums;

namespace OverwatchHeroInfo.API.Migrations
{
    [DbContext(typeof(HeroInfoContext))]
    [Migration("20170720004644_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OverwatchHeroInfo.API.Entities.CounterPick", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("HeroId");

                    b.Property<bool>("IsStrongAgainst");

                    b.Property<bool>("IsWeakAgainst");

                    b.Property<int>("Name");

                    b.HasKey("Id");

                    b.HasIndex("HeroId");

                    b.ToTable("CounterPicks");
                });

            modelBuilder.Entity("OverwatchHeroInfo.API.Entities.Hero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Name");

                    b.HasKey("Id");

                    b.ToTable("Heroes");
                });

            modelBuilder.Entity("OverwatchHeroInfo.API.Entities.CounterPick", b =>
                {
                    b.HasOne("OverwatchHeroInfo.API.Entities.Hero", "Hero")
                        .WithMany("CounterPicks")
                        .HasForeignKey("HeroId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
