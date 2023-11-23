﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyBlogApp.Data.Concrete.EfCore;

#nullable disable

namespace MyBlogApp.Migrations
{
    [DbContext(typeof(BlogContext))]
    [Migration("20231122185328_AddUrlToTables")]
    partial class AddUrlToTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("MyBlogApp.Entity.Comment", b =>
                {
                    b.Property<int>("CommentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("PostID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("PublishedOn")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TagID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserID")
                        .HasColumnType("INTEGER");

                    b.HasKey("CommentID");

                    b.HasIndex("PostID");

                    b.HasIndex("TagID");

                    b.HasIndex("UserID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("MyBlogApp.Entity.Post", b =>
                {
                    b.Property<int>("PostID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("PublishedOn")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserID")
                        .HasColumnType("INTEGER");

                    b.HasKey("PostID");

                    b.HasIndex("UserID");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("MyBlogApp.Entity.Tag", b =>
                {
                    b.Property<int>("TagID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("TagID");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("MyBlogApp.Entity.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PostTag", b =>
                {
                    b.Property<int>("PostsPostID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TagsTagID")
                        .HasColumnType("INTEGER");

                    b.HasKey("PostsPostID", "TagsTagID");

                    b.HasIndex("TagsTagID");

                    b.ToTable("PostTag");
                });

            modelBuilder.Entity("MyBlogApp.Entity.Comment", b =>
                {
                    b.HasOne("MyBlogApp.Entity.Post", "Post")
                        .WithMany()
                        .HasForeignKey("PostID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyBlogApp.Entity.Tag", null)
                        .WithMany("Comments")
                        .HasForeignKey("TagID");

                    b.HasOne("MyBlogApp.Entity.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MyBlogApp.Entity.Post", b =>
                {
                    b.HasOne("MyBlogApp.Entity.User", "User")
                        .WithMany("Post")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PostTag", b =>
                {
                    b.HasOne("MyBlogApp.Entity.Post", null)
                        .WithMany()
                        .HasForeignKey("PostsPostID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyBlogApp.Entity.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsTagID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyBlogApp.Entity.Tag", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("MyBlogApp.Entity.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Post");
                });
#pragma warning restore 612, 618
        }
    }
}
