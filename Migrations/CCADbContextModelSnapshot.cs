﻿// <auto-generated />
using CCA_BE.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CCA_BE.Migrations
{
    [DbContext(typeof(CCADbContext))]
    partial class CCADbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CCA_BE.Models.AnualExcelModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("F3G3")
                        .HasColumnType("int");

                    b.Property<int>("K4K4")
                        .HasColumnType("int");

                    b.Property<int>("L11L11")
                        .HasColumnType("int");

                    b.Property<int>("L12L12")
                        .HasColumnType("int");

                    b.Property<int>("L13L13")
                        .HasColumnType("int");

                    b.Property<int>("L14L14")
                        .HasColumnType("int");

                    b.Property<int>("L15L15")
                        .HasColumnType("int");

                    b.Property<int>("L16L16")
                        .HasColumnType("int");

                    b.Property<int>("L17L17")
                        .HasColumnType("int");

                    b.Property<int>("L18L18")
                        .HasColumnType("int");

                    b.Property<int>("L19L19")
                        .HasColumnType("int");

                    b.Property<int>("L20L20")
                        .HasColumnType("int");

                    b.Property<int>("L21L21")
                        .HasColumnType("int");

                    b.Property<int>("L22L22")
                        .HasColumnType("int");

                    b.Property<int>("L23L23")
                        .HasColumnType("int");

                    b.Property<int>("L24L24")
                        .HasColumnType("int");

                    b.Property<int>("L25L25")
                        .HasColumnType("int");

                    b.Property<int>("L26L26")
                        .HasColumnType("int");

                    b.Property<int>("L27L27")
                        .HasColumnType("int");

                    b.Property<int>("L28L28")
                        .HasColumnType("int");

                    b.Property<int>("L29L29")
                        .HasColumnType("int");

                    b.Property<int>("L30L30")
                        .HasColumnType("int");

                    b.Property<int>("L31L31")
                        .HasColumnType("int");

                    b.Property<int>("L32L32")
                        .HasColumnType("int");

                    b.Property<int>("L33L33")
                        .HasColumnType("int");

                    b.Property<int>("L34L34")
                        .HasColumnType("int");

                    b.Property<int>("L35L35")
                        .HasColumnType("int");

                    b.Property<int>("L36L36")
                        .HasColumnType("int");

                    b.Property<int>("L37L37")
                        .HasColumnType("int");

                    b.Property<int>("L38L38")
                        .HasColumnType("int");

                    b.Property<int>("L39L39")
                        .HasColumnType("int");

                    b.Property<int>("L40L40")
                        .HasColumnType("int");

                    b.Property<int>("L41L41")
                        .HasColumnType("int");

                    b.Property<int>("L42L42")
                        .HasColumnType("int");

                    b.Property<int>("L43L43")
                        .HasColumnType("int");

                    b.Property<int>("L44L44")
                        .HasColumnType("int");

                    b.Property<int>("L45L45")
                        .HasColumnType("int");

                    b.Property<int>("L47L47")
                        .HasColumnType("int");

                    b.Property<int>("L48L48")
                        .HasColumnType("int");

                    b.Property<int>("L49L49")
                        .HasColumnType("int");

                    b.Property<int>("L4L4")
                        .HasColumnType("int");

                    b.Property<int>("L50L50")
                        .HasColumnType("int");

                    b.Property<int>("L51L51")
                        .HasColumnType("int");

                    b.Property<int>("L52L52")
                        .HasColumnType("int");

                    b.Property<int>("L53L53")
                        .HasColumnType("int");

                    b.Property<int>("L54L54")
                        .HasColumnType("int");

                    b.Property<int>("L55L55")
                        .HasColumnType("int");

                    b.Property<int>("L56L56")
                        .HasColumnType("int");

                    b.Property<int>("L57L57")
                        .HasColumnType("int");

                    b.Property<int>("L58L58")
                        .HasColumnType("int");

                    b.Property<int>("L59L59")
                        .HasColumnType("int");

                    b.Property<int>("L60L60")
                        .HasColumnType("int");

                    b.Property<int>("L64L64")
                        .HasColumnType("int");

                    b.Property<int>("L65L65")
                        .HasColumnType("int");

                    b.Property<int>("L66L66")
                        .HasColumnType("int");

                    b.Property<int>("L67L67")
                        .HasColumnType("int");

                    b.Property<int>("L68L68")
                        .HasColumnType("int");

                    b.Property<int>("L69L69")
                        .HasColumnType("int");

                    b.Property<int>("L70L70")
                        .HasColumnType("int");

                    b.Property<int>("L71L71")
                        .HasColumnType("int");

                    b.Property<int>("L72L72")
                        .HasColumnType("int");

                    b.Property<int>("L73L73")
                        .HasColumnType("int");

                    b.Property<int>("L74L74")
                        .HasColumnType("int");

                    b.Property<int>("L75L75")
                        .HasColumnType("int");

                    b.Property<int>("L76L76")
                        .HasColumnType("int");

                    b.Property<int>("L77L77")
                        .HasColumnType("int");

                    b.Property<int>("L78L78")
                        .HasColumnType("int");

                    b.Property<int>("L79L79")
                        .HasColumnType("int");

                    b.Property<int>("L80L80")
                        .HasColumnType("int");

                    b.Property<int>("L81L81")
                        .HasColumnType("int");

                    b.Property<int>("L82L82")
                        .HasColumnType("int");

                    b.Property<int>("L83L83")
                        .HasColumnType("int");

                    b.Property<int>("L84L84")
                        .HasColumnType("int");

                    b.Property<int>("L85L85")
                        .HasColumnType("int");

                    b.Property<int>("L86L86")
                        .HasColumnType("int");

                    b.Property<int>("L87L87")
                        .HasColumnType("int");

                    b.Property<int>("L88L88")
                        .HasColumnType("int");

                    b.Property<int>("L89L89")
                        .HasColumnType("int");

                    b.Property<string>("L8L10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("L90L90")
                        .HasColumnType("int");

                    b.Property<int>("L91L91")
                        .HasColumnType("int");

                    b.Property<int>("M4M4")
                        .HasColumnType("int");

                    b.Property<string>("fileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nameid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("state")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("evs", (string)null);
                });

            modelBuilder.Entity("CCA_BE.Models.User", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("users", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
