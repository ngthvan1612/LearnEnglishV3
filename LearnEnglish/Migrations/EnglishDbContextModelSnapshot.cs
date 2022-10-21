﻿// <auto-generated />
using System;
using LearnEnglish.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LearnEnglish.Migrations
{
    [DbContext(typeof(EnglishDbContext))]
    partial class EnglishDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LearnEnglish.Domain.Aggregate.LearningStatuses.LearningVocabStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Result")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VocabId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VocabId");

                    b.ToTable("LearningVocabStatuses");
                });

            modelBuilder.Entity("LearnEnglish.Domain.Aggregate.TopicTrees.TopicTree", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NodeType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TopicTrees");
                });

            modelBuilder.Entity("LearnEnglish.Domain.Aggregate.Vocabs.Vocab", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte[]>("Audio")
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Eng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TopicTreeId")
                        .HasColumnType("int");

                    b.Property<string>("Vie")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TopicTreeId");

                    b.ToTable("Vocabs");
                });

            modelBuilder.Entity("LearnEnglish.Domain.Aggregate.LearningStatuses.LearningVocabStatus", b =>
                {
                    b.HasOne("LearnEnglish.Domain.Aggregate.Vocabs.Vocab", "Vocab")
                        .WithMany()
                        .HasForeignKey("VocabId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vocab");
                });

            modelBuilder.Entity("LearnEnglish.Domain.Aggregate.Vocabs.Vocab", b =>
                {
                    b.HasOne("LearnEnglish.Domain.Aggregate.TopicTrees.TopicTree", "TopicTree")
                        .WithMany()
                        .HasForeignKey("TopicTreeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TopicTree");
                });
#pragma warning restore 612, 618
        }
    }
}
