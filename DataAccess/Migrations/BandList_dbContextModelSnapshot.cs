﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using DataAccess.Models;

#nullable disable

namespace Musicshare_API.Migrations
{
    [DbContext(typeof(BandList_dbContext))]
    partial class BandList_dbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BandMembersBand", b =>
                {
                    b.Property<int>("MemberId")
                        .HasColumnType("int")
                        .HasColumnName("member_id");

                    b.Property<int>("BandId")
                        .HasColumnType("int")
                        .HasColumnName("band_id");

                    b.HasKey("MemberId", "BandId")
                        .HasName("PK__Band_mem__FE73863EA405A083");

                    b.HasIndex("BandId");

                    b.ToTable("Band_members_bands", (string)null);
                });

            modelBuilder.Entity("Musicshare_API.Models.BandList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Country")
                        .HasColumnType("int")
                        .HasColumnName("country");

                    b.Property<int>("Genre")
                        .HasColumnType("int")
                        .HasColumnName("genre");

                    b.Property<int>("Lang")
                        .HasColumnType("int")
                        .HasColumnName("lang");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("Country");

                    b.HasIndex("Genre");

                    b.HasIndex("Lang");

                    b.ToTable("Band_list", (string)null);
                });

            modelBuilder.Entity("Musicshare_API.Models.BandMember", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("BandId")
                        .HasColumnType("int")
                        .HasColumnName("band_id");

                    b.Property<bool?>("IsInBand")
                        .HasColumnType("bit")
                        .HasColumnName("is_in_band");

                    b.Property<string>("Lastname")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("lastname");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("Pseudonym")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("pseudonym");

                    b.HasKey("Id");

                    b.HasIndex("BandId");

                    b.ToTable("Band_members", (string)null);
                });

            modelBuilder.Entity("Musicshare_API.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Musicshare_API.Models.GenreList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Genre_list", (string)null);
                });

            modelBuilder.Entity("Musicshare_API.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("Musicshare_API.Models.ReleaseList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Band")
                        .HasColumnType("int")
                        .HasColumnName("band");

                    b.Property<int>("Genre")
                        .HasColumnType("int")
                        .HasColumnName("genre");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.Property<int>("SongAmmount")
                        .HasColumnType("int")
                        .HasColumnName("song_ammount");

                    b.Property<int>("Type")
                        .HasColumnType("int")
                        .HasColumnName("type");

                    b.Property<int>("Year")
                        .HasColumnType("int")
                        .HasColumnName("year");

                    b.HasKey("Id");

                    b.HasIndex("Band");

                    b.HasIndex("Genre");

                    b.HasIndex("Type");

                    b.ToTable("Release_list", (string)null);
                });

            modelBuilder.Entity("Musicshare_API.Models.ReleaseType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("type");

                    b.HasKey("Id");

                    b.ToTable("Release_type", (string)null);
                });

            modelBuilder.Entity("Musicshare_API.Models.SongList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Band")
                        .HasColumnType("int")
                        .HasColumnName("band");

                    b.Property<int>("Genre")
                        .HasColumnType("int")
                        .HasColumnName("genre");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.Property<int>("SongReleaseId")
                        .HasColumnType("int")
                        .HasColumnName("song_release_id");

                    b.HasKey("Id");

                    b.HasIndex("Band");

                    b.HasIndex("Genre");

                    b.HasIndex("SongReleaseId");

                    b.ToTable("Song_list", (string)null);
                });

            modelBuilder.Entity("Musicshare_API.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("Lastname")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("lastname");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("password");

                    b.Property<DateTime>("Regdate")
                        .HasColumnType("datetime")
                        .HasColumnName("regdate");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("username");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Musicshare_API.Models.UserFavorite", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.Property<int>("BandId")
                        .HasColumnType("int")
                        .HasColumnName("band_id");

                    b.Property<int>("ReleaseId")
                        .HasColumnType("int")
                        .HasColumnName("release_id");

                    b.Property<int>("SongId")
                        .HasColumnType("int")
                        .HasColumnName("song_id");

                    b.Property<string>("Review")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("review");

                    b.HasKey("UserId", "BandId", "ReleaseId", "SongId")
                        .HasName("PK__User_fav__63F33842C5125F83");

                    b.HasIndex("BandId");

                    b.HasIndex("ReleaseId");

                    b.HasIndex("SongId");

                    b.ToTable("User_favorite", (string)null);
                });

            modelBuilder.Entity("BandMembersBand", b =>
                {
                    b.HasOne("Musicshare_API.Models.BandList", null)
                        .WithMany()
                        .HasForeignKey("BandId")
                        .IsRequired()
                        .HasConstraintName("FK__Band_memb__band___571DF1D5");

                    b.HasOne("Musicshare_API.Models.BandMember", null)
                        .WithMany()
                        .HasForeignKey("MemberId")
                        .IsRequired()
                        .HasConstraintName("FK__Band_memb__membe__5629CD9C");
                });

            modelBuilder.Entity("Musicshare_API.Models.BandList", b =>
                {
                    b.HasOne("Musicshare_API.Models.Country", "CountryNavigation")
                        .WithMany("BandLists")
                        .HasForeignKey("Country")
                        .IsRequired()
                        .HasConstraintName("FK__Band_list__count__46E78A0C");

                    b.HasOne("Musicshare_API.Models.GenreList", "GenreNavigation")
                        .WithMany("BandLists")
                        .HasForeignKey("Genre")
                        .IsRequired()
                        .HasConstraintName("FK__Band_list__genre__44FF419A");

                    b.HasOne("Musicshare_API.Models.Language", "LangNavigation")
                        .WithMany("BandLists")
                        .HasForeignKey("Lang")
                        .IsRequired()
                        .HasConstraintName("FK__Band_list__lang__45F365D3");

                    b.Navigation("CountryNavigation");

                    b.Navigation("GenreNavigation");

                    b.Navigation("LangNavigation");
                });

            modelBuilder.Entity("Musicshare_API.Models.BandMember", b =>
                {
                    b.HasOne("Musicshare_API.Models.BandList", "Band")
                        .WithMany("BandMembers")
                        .HasForeignKey("BandId")
                        .HasConstraintName("FK__Band_memb__band___534D60F1");

                    b.Navigation("Band");
                });

            modelBuilder.Entity("Musicshare_API.Models.ReleaseList", b =>
                {
                    b.HasOne("Musicshare_API.Models.BandList", "BandNavigation")
                        .WithMany("ReleaseLists")
                        .HasForeignKey("Band")
                        .IsRequired()
                        .HasConstraintName("FK__Release_li__band__49C3F6B7");

                    b.HasOne("Musicshare_API.Models.GenreList", "GenreNavigation")
                        .WithMany("ReleaseLists")
                        .HasForeignKey("Genre")
                        .IsRequired()
                        .HasConstraintName("FK__Release_l__genre__4AB81AF0");

                    b.HasOne("Musicshare_API.Models.ReleaseType", "TypeNavigation")
                        .WithMany("ReleaseLists")
                        .HasForeignKey("Type")
                        .IsRequired()
                        .HasConstraintName("FK__Release_li__type__4BAC3F29");

                    b.Navigation("BandNavigation");

                    b.Navigation("GenreNavigation");

                    b.Navigation("TypeNavigation");
                });

            modelBuilder.Entity("Musicshare_API.Models.SongList", b =>
                {
                    b.HasOne("Musicshare_API.Models.BandList", "BandNavigation")
                        .WithMany("SongLists")
                        .HasForeignKey("Band")
                        .IsRequired()
                        .HasConstraintName("FK__Song_list__band__4E88ABD4");

                    b.HasOne("Musicshare_API.Models.GenreList", "GenreNavigation")
                        .WithMany("SongLists")
                        .HasForeignKey("Genre")
                        .IsRequired()
                        .HasConstraintName("FK__Song_list__genre__4F7CD00D");

                    b.HasOne("Musicshare_API.Models.ReleaseList", "SongRelease")
                        .WithMany("SongLists")
                        .HasForeignKey("SongReleaseId")
                        .IsRequired()
                        .HasConstraintName("FK__Song_list__song___5070F446");

                    b.Navigation("BandNavigation");

                    b.Navigation("GenreNavigation");

                    b.Navigation("SongRelease");
                });

            modelBuilder.Entity("Musicshare_API.Models.UserFavorite", b =>
                {
                    b.HasOne("Musicshare_API.Models.BandList", "Band")
                        .WithMany("UserFavorites")
                        .HasForeignKey("BandId")
                        .IsRequired()
                        .HasConstraintName("FK__User_favo__band___656C112C");

                    b.HasOne("Musicshare_API.Models.ReleaseList", "Release")
                        .WithMany("UserFavorites")
                        .HasForeignKey("ReleaseId")
                        .IsRequired()
                        .HasConstraintName("FK__User_favo__relea__66603565");

                    b.HasOne("Musicshare_API.Models.SongList", "Song")
                        .WithMany("UserFavorites")
                        .HasForeignKey("SongId")
                        .IsRequired()
                        .HasConstraintName("FK__User_favo__song___6754599E");

                    b.HasOne("Musicshare_API.Models.User", "User")
                        .WithMany("UserFavorites")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK__User_favo__user___6477ECF3");

                    b.Navigation("Band");

                    b.Navigation("Release");

                    b.Navigation("Song");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Musicshare_API.Models.BandList", b =>
                {
                    b.Navigation("BandMembers");

                    b.Navigation("ReleaseLists");

                    b.Navigation("SongLists");

                    b.Navigation("UserFavorites");
                });

            modelBuilder.Entity("Musicshare_API.Models.Country", b =>
                {
                    b.Navigation("BandLists");
                });

            modelBuilder.Entity("Musicshare_API.Models.GenreList", b =>
                {
                    b.Navigation("BandLists");

                    b.Navigation("ReleaseLists");

                    b.Navigation("SongLists");
                });

            modelBuilder.Entity("Musicshare_API.Models.Language", b =>
                {
                    b.Navigation("BandLists");
                });

            modelBuilder.Entity("Musicshare_API.Models.ReleaseList", b =>
                {
                    b.Navigation("SongLists");

                    b.Navigation("UserFavorites");
                });

            modelBuilder.Entity("Musicshare_API.Models.ReleaseType", b =>
                {
                    b.Navigation("ReleaseLists");
                });

            modelBuilder.Entity("Musicshare_API.Models.SongList", b =>
                {
                    b.Navigation("UserFavorites");
                });

            modelBuilder.Entity("Musicshare_API.Models.User", b =>
                {
                    b.Navigation("UserFavorites");
                });
#pragma warning restore 612, 618
        }
    }
}
