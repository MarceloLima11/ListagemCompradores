// <auto-generated />
using System;
using ListagemCompradores.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ListagemCompradores.Migrations
{
    [DbContext(typeof(ListagemDbContext))]
    [Migration("20220627195444_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ListagemCompradores.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Bloqueado")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("CpfCnpj")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("varchar(18)");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("InscricaoEstadual")
                        .HasColumnType("longtext");

                    b.Property<bool>("Isento")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TipoPessoa")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Clientes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bloqueado = false,
                            CpfCnpj = "321.123.321-14",
                            DataCadastro = new DateTime(2022, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(4891),
                            DataNascimento = new DateTime(2001, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(4892),
                            Email = "Admin@hotmail.com",
                            Genero = "Masculino",
                            InscricaoEstadual = "",
                            Isento = true,
                            Nome = "Administrador",
                            Senha = "fa585d89c851dd338a70dcf535aa2a92fee7836dd6aff1226583e88e0996293f16bc009c652826e0fc5c706695a03cddce372f139eff4d13959da6f1f5d3eabe",
                            Telefone = "(13) 99999-9999",
                            TipoPessoa = "Fisica"
                        },
                        new
                        {
                            Id = 2,
                            Bloqueado = false,
                            CpfCnpj = "123.321.342-48",
                            DataCadastro = new DateTime(2022, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(5320),
                            DataNascimento = new DateTime(1999, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(5321),
                            Email = "Junior@hotmail.com",
                            Genero = "Masculino",
                            InscricaoEstadual = "",
                            Isento = true,
                            Nome = "Junior Leite",
                            Senha = "9297e38e6a5692f6521862b47a3a47fd2050d728f5982ed1eafb67332cdc760a34cf17bf0162244dcd28340eb60886373e849ab1822c53503c153a88961172d4",
                            Telefone = "(13) 99898-1234",
                            TipoPessoa = "Fisica"
                        },
                        new
                        {
                            Id = 3,
                            Bloqueado = true,
                            CpfCnpj = "127.321.335-49",
                            DataCadastro = new DateTime(2022, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(5738),
                            DataNascimento = new DateTime(1967, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(5739),
                            Email = "Bebeto@hotmail.com",
                            Genero = "Masculino",
                            InscricaoEstadual = "",
                            Isento = true,
                            Nome = "Roberto Gomes",
                            Senha = "8488472172485868cb8b8bfaebdf156101e40770c423a021b2a7933ddfcc79f0c77b643535db964221eeea5fbbdd783bf30365f9a90821fc771456ca720209c4",
                            Telefone = "(18) 12398-1234",
                            TipoPessoa = "Fisica"
                        },
                        new
                        {
                            Id = 4,
                            Bloqueado = false,
                            CpfCnpj = "132.321.444-23",
                            DataCadastro = new DateTime(2022, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(6166),
                            DataNascimento = new DateTime(1963, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(6166),
                            Email = "Ruanzito@hotmail.com",
                            Genero = "Masculino",
                            InscricaoEstadual = "",
                            Isento = true,
                            Nome = "Ruan",
                            Senha = "ce05b43dd174f1bdc646bdc10e70792a8043690b963075995e4d07a01c124ffef65da462239e2ae9e6bbab185c2895f117917eb9105c42ee3a7327d1ead4edf3",
                            Telefone = "(13) 13456-1234",
                            TipoPessoa = "Fisica"
                        },
                        new
                        {
                            Id = 5,
                            Bloqueado = true,
                            CpfCnpj = "170.167.342-38",
                            DataCadastro = new DateTime(2022, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(6646),
                            DataNascimento = new DateTime(1984, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(6647),
                            Email = "Matheus.Flex@hotmail.com",
                            Genero = "Fasculino",
                            InscricaoEstadual = "",
                            Isento = true,
                            Nome = "Matheus Flexivel",
                            Senha = "4a82615c8e9ed8cc5ea97ca7b95dd397b634e7d94cfb9d9f8f41e05d69dca9bdcf66bc80cef1c61f6b2fc9ed6de1c500b6c15de53418fcb4621813b12f801bff",
                            Telefone = "(99) 99758-3221",
                            TipoPessoa = "Fisica"
                        },
                        new
                        {
                            Id = 6,
                            Bloqueado = true,
                            CpfCnpj = "323.188.999-32",
                            DataCadastro = new DateTime(2022, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(7064),
                            DataNascimento = new DateTime(1999, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(7065),
                            Email = "Rafaela.Love@hotmail.com",
                            Genero = "Feminino",
                            InscricaoEstadual = "",
                            Isento = true,
                            Nome = "Rafaela Love",
                            Senha = "41876995b4b08a066ce8b0de42b08997f040d440ac59bc746238fc569b7728cb93893fe662fd12b02bba42fe1b9aada9f3b0b7d3616d9a8e20279aea20d7f899",
                            Telefone = "(13) 89899-7777",
                            TipoPessoa = "Fisica"
                        },
                        new
                        {
                            Id = 7,
                            Bloqueado = false,
                            CpfCnpj = "556.902.300-30",
                            DataCadastro = new DateTime(2022, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(7483),
                            DataNascimento = new DateTime(1985, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(7484),
                            Email = "Show@hotmail.com",
                            Genero = "Masculino",
                            InscricaoEstadual = "559300404717",
                            Isento = false,
                            Nome = "Show Moon",
                            Senha = "469ab1c50e1906b9b16f247c6a0a225f9f03d7729d54425546df741e4e69c95aec5261482cf3abcb3fac1b65016b27b3eb318104d945c5134d33dc3639d8c152",
                            Telefone = "(13) 99898-1234",
                            TipoPessoa = "Juridica"
                        },
                        new
                        {
                            Id = 8,
                            Bloqueado = false,
                            CpfCnpj = "556.902.300-30",
                            DataCadastro = new DateTime(2022, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(7897),
                            DataNascimento = new DateTime(2005, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(7898),
                            Email = "Elias-Desu@hotmail.com",
                            Genero = "Masculino",
                            InscricaoEstadual = "",
                            Isento = true,
                            Nome = "Elias Desu",
                            Senha = "82d8f02f1869a0ee044ca9deb9ff585555a9ff3969d17842fef4165588a92471413a7dab4855c9d0b3ea47a63018fccf66e2af8555aa28c8e11d83d294057709",
                            Telefone = "(13) 99898-1234",
                            TipoPessoa = "Fisica"
                        },
                        new
                        {
                            Id = 9,
                            Bloqueado = true,
                            CpfCnpj = "243.892.180-34",
                            DataCadastro = new DateTime(2022, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(8349),
                            DataNascimento = new DateTime(2010, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(8350),
                            Email = "SuperMen@hotmail.com",
                            Genero = "Masculino",
                            InscricaoEstadual = "114414815878",
                            Isento = false,
                            Nome = "Super Homem",
                            Senha = "a763389d742ebc44071cf44d2b1e32dd05a4cd1ec996187774ae6d1da0acfd9fc232e560324bb17ac8414638865160653339fe0329ca593ecbcee8be77d92b61",
                            Telefone = "(13) 99898-1234",
                            TipoPessoa = "Juridica"
                        },
                        new
                        {
                            Id = 10,
                            Bloqueado = false,
                            CpfCnpj = "798.740.230-31",
                            DataCadastro = new DateTime(2022, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(8768),
                            DataNascimento = new DateTime(1789, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(8769),
                            Email = "HDASUI@outlook.com",
                            Genero = "Masculino",
                            InscricaoEstadual = "",
                            Isento = true,
                            Nome = "Hdasui",
                            Senha = "40e0916bfec48a01cd3bd1d189f2a43e37529cc8c8970ae17143db233bfe0c8503b5b0466f311419ebe2357fc1ca504e2df4804328d672bb1cb9ba1fc189d633",
                            Telefone = "(13) 99898-1234",
                            TipoPessoa = "Fisica"
                        },
                        new
                        {
                            Id = 11,
                            Bloqueado = false,
                            CpfCnpj = "262.991.203-55",
                            DataCadastro = new DateTime(2022, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(9196),
                            DataNascimento = new DateTime(1899, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(9197),
                            Email = "jose_emanuel_darosa@hotmailo.com",
                            Genero = "Masculino",
                            InscricaoEstadual = "",
                            Isento = true,
                            Nome = "José Emanuel Hugo da Rosa",
                            Senha = "82d8f02f1869a0ee044ca9deb9ff585555a9ff3969d17842fef4165588a92471413a7dab4855c9d0b3ea47a63018fccf66e2af8555aa28c8e11d83d294057709",
                            Telefone = "(13) 99898-1234",
                            TipoPessoa = "Fisica"
                        },
                        new
                        {
                            Id = 12,
                            Bloqueado = false,
                            CpfCnpj = "556.902.300-30",
                            DataCadastro = new DateTime(2022, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(9610),
                            DataNascimento = new DateTime(1963, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(9611),
                            Email = "eduarda_martins@quimicaindaiatuba.com.br",
                            Genero = "Feminino",
                            InscricaoEstadual = "",
                            Isento = true,
                            Nome = "Eduarda Luana Julia Martins",
                            Senha = "82d8f02f1869a0ee044ca9deb9ff585555a9ff3969d17842fef4165588a92471413a7dab4855c9d0b3ea47a63018fccf66e2af8555aa28c8e11d83d294057709",
                            Telefone = "(85) 99948-0437",
                            TipoPessoa = "Fisica"
                        },
                        new
                        {
                            Id = 13,
                            Bloqueado = false,
                            CpfCnpj = "90.476.749/0001-00",
                            DataCadastro = new DateTime(2022, 6, 27, 16, 54, 44, 540, DateTimeKind.Local).AddTicks(66),
                            DataNascimento = new DateTime(2012, 6, 27, 16, 54, 44, 540, DateTimeKind.Local).AddTicks(67),
                            Email = "juridico@miguelerebecaeletronicaltda.com.br",
                            Genero = "Masculino",
                            InscricaoEstadual = "770000098889",
                            Isento = false,
                            Nome = "Miguel e Rebeca Eletrônica Ltda",
                            Senha = "983bdde96f2b56ea154b87ef8107eec753193e16e2734d02f25c9b3b15d8bc3047f77212371c15009c99c7281f682749d5502668080d37a117598152048c74b6",
                            Telefone = "(13) 99898-1234",
                            TipoPessoa = "Juridica"
                        },
                        new
                        {
                            Id = 14,
                            Bloqueado = true,
                            CpfCnpj = "63.577.648/0001-45",
                            DataCadastro = new DateTime(2022, 6, 27, 16, 54, 44, 540, DateTimeKind.Local).AddTicks(486),
                            DataNascimento = new DateTime(2020, 6, 27, 16, 54, 44, 540, DateTimeKind.Local).AddTicks(487),
                            Email = "orcamento@nathanepatriciaentulhosltda.com.br",
                            Genero = "Masculino",
                            InscricaoEstadual = "598816160020",
                            Isento = false,
                            Nome = "Marina e Isabela Padaria ME",
                            Senha = "33fe27fa67128aa75dc0620008a310f7fd7de23e135d780a9eb6c08a818196367f3c29916f639132607f17a15bfd05681ead73bd58f309b1f84dc34ab5d69572",
                            Telefone = "(11) 99937-9238",
                            TipoPessoa = "Juridica"
                        },
                        new
                        {
                            Id = 15,
                            Bloqueado = false,
                            CpfCnpj = "99.157.045/0001-31",
                            DataCadastro = new DateTime(2022, 6, 27, 16, 54, 44, 540, DateTimeKind.Local).AddTicks(905),
                            DataNascimento = new DateTime(2010, 6, 27, 16, 54, 44, 540, DateTimeKind.Local).AddTicks(906),
                            Email = "comunicacoes@marinaeizabela.com.br",
                            Genero = "Masculino",
                            InscricaoEstadual = "698917126033",
                            Isento = true,
                            Nome = "Marina e Isabela Padaria ME",
                            Senha = "23404e5d79d9f2556c681e2b16f5469d500befd7b62e377881537cfa9b27210a7aa96e320e1c2c5da0269d23f39be5432ca5861c213d91bf8bed4a790a1b570f",
                            Telefone = "(12) 99307-1234",
                            TipoPessoa = "Juridica"
                        },
                        new
                        {
                            Id = 16,
                            Bloqueado = false,
                            CpfCnpj = "56.542.713/0001-31",
                            DataCadastro = new DateTime(2022, 6, 27, 16, 54, 44, 540, DateTimeKind.Local).AddTicks(1322),
                            DataNascimento = new DateTime(1967, 6, 27, 16, 54, 44, 540, DateTimeKind.Local).AddTicks(1323),
                            Email = "diretoria@aparecidaebeneditodocessalgadosltda.com.br",
                            Genero = "Masculino",
                            InscricaoEstadual = "401639480020",
                            Isento = false,
                            Nome = "Aparecida e Benedito Doce e Salgados",
                            Senha = "3c1ae58f94079b4851b49f5618f3b0c1ff1956293ac30a46ae522a38c02f6c0d06f387515f2fa71c3d7e7dbb5fe3a8d9b325a4ce90cf414165fc24a519a68f0d",
                            Telefone = "(14) 98677-6241",
                            TipoPessoa = "Juridica"
                        },
                        new
                        {
                            Id = 17,
                            Bloqueado = true,
                            CpfCnpj = "274.210.736-39",
                            DataCadastro = new DateTime(2022, 6, 27, 16, 54, 44, 540, DateTimeKind.Local).AddTicks(1785),
                            DataNascimento = new DateTime(1978, 6, 27, 16, 54, 44, 540, DateTimeKind.Local).AddTicks(1786),
                            Email = "calebe.pietro.damata@policiamilitar.sp.gov.br",
                            Genero = "Masculino",
                            InscricaoEstadual = "",
                            Isento = false,
                            Nome = "Calebe Pietro da Mata",
                            Senha = "d09718a015d783829c5dbabaef88675641e833807a82078a4040f945fcc500bb9f94d6db008d4120d719dfbfb99829200724bd27a7f89a84b2e05550c844899f",
                            Telefone = "(27) 98896-6365",
                            TipoPessoa = "Fisica"
                        },
                        new
                        {
                            Id = 18,
                            Bloqueado = true,
                            CpfCnpj = "754.978.850-20",
                            DataCadastro = new DateTime(2022, 6, 27, 16, 54, 44, 540, DateTimeKind.Local).AddTicks(2251),
                            DataNascimento = new DateTime(1990, 6, 27, 16, 54, 44, 540, DateTimeKind.Local).AddTicks(2252),
                            Email = "calebe.pietro.damata@policiamilitar.sp.gov.br",
                            Genero = "Masculino",
                            InscricaoEstadual = "",
                            Isento = false,
                            Nome = "Benedito Lucca Geraldo Silveira",
                            Senha = "fc9ae11dfa7acd9b16e35da1d06b36f0785c8e3e1b8dd11aedb47999eb93d048b32946502d00727d328a93813f09fdce65e12559b4667c72a00d0181412192ad",
                            Telefone = "(27) 98499-2121",
                            TipoPessoa = "Fisica"
                        },
                        new
                        {
                            Id = 19,
                            Bloqueado = true,
                            CpfCnpj = "007.261.466-84",
                            DataCadastro = new DateTime(2022, 6, 27, 16, 54, 44, 540, DateTimeKind.Local).AddTicks(2669),
                            DataNascimento = new DateTime(1957, 6, 27, 16, 54, 44, 540, DateTimeKind.Local).AddTicks(2670),
                            Email = "catarina_damata@oralcamp.com.br",
                            Genero = "Masculino",
                            InscricaoEstadual = "",
                            Isento = false,
                            Nome = "Catarina Aline da Mata",
                            Senha = "072c8f41f398082b172181ad5c050ec885ed4b50c01aed572921ffcf0bde7311d118b94b687d02c3cb13f43b94e52d54156fc22f8b5a0fbacfa580dfa98ca537",
                            Telefone = "(86) 98365-8932",
                            TipoPessoa = "Fisica"
                        },
                        new
                        {
                            Id = 20,
                            Bloqueado = false,
                            CpfCnpj = "415.498.554-09",
                            DataCadastro = new DateTime(2022, 6, 27, 16, 54, 44, 540, DateTimeKind.Local).AddTicks(3086),
                            DataNascimento = new DateTime(1999, 6, 27, 16, 54, 44, 540, DateTimeKind.Local).AddTicks(3086),
                            Email = "alexandremanoelduarte@kinouchi.com.br",
                            Genero = "Masculino",
                            InscricaoEstadual = "",
                            Isento = true,
                            Nome = "Alexandre Manoel Duarte",
                            Senha = "116d437a5925c1158a821361ce2ff398802ec616122e2f17f8cf1c08d3f7c6a807f9c3945c159aacb7ea6aaf1224735429aee39cc767908ec622a050c3f97174",
                            Telefone = "(82) 98544-7243",
                            TipoPessoa = "Fisica"
                        },
                        new
                        {
                            Id = 21,
                            Bloqueado = false,
                            CpfCnpj = "115.448.354-22",
                            DataCadastro = new DateTime(2022, 6, 27, 16, 54, 44, 540, DateTimeKind.Local).AddTicks(3526),
                            DataNascimento = new DateTime(2008, 6, 27, 16, 54, 44, 540, DateTimeKind.Local).AddTicks(3527),
                            Email = "BABADI@ROKIROKI.com.br",
                            Genero = "Outro",
                            InscricaoEstadual = "",
                            Isento = true,
                            Nome = "Babadi Roki Roki",
                            Senha = "9b4be8a788bf8418333969e714c8cee91b41f40d5be7caab60629d35f78a020fb7a32040f054cc36fbd9086e08d6cf704009662fa6249edbd575f8b9f9060fff",
                            Telefone = "(99) 99999-9999",
                            TipoPessoa = "Fisica"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
