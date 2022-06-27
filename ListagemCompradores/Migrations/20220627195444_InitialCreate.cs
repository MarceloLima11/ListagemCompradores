using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ListagemCompradores.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataCadastro = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    TipoPessoa = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CpfCnpj = table.Column<string>(type: "varchar(18)", maxLength: 18, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InscricaoEstadual = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Genero = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataNascimento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Bloqueado = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Isento = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Senha = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Bloqueado", "CpfCnpj", "DataCadastro", "DataNascimento", "Email", "Genero", "InscricaoEstadual", "Isento", "Nome", "Senha", "Telefone", "TipoPessoa" },
                values: new object[,]
                {
                    { 1, false, "321.123.321-14", new DateTime(2022, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(4891), new DateTime(2001, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(4892), "Admin@hotmail.com", "Masculino", "", true, "Administrador", "fa585d89c851dd338a70dcf535aa2a92fee7836dd6aff1226583e88e0996293f16bc009c652826e0fc5c706695a03cddce372f139eff4d13959da6f1f5d3eabe", "(13) 99999-9999", "Fisica" },
                    { 2, false, "123.321.342-48", new DateTime(2022, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(5320), new DateTime(1999, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(5321), "Junior@hotmail.com", "Masculino", "", true, "Junior Leite", "9297e38e6a5692f6521862b47a3a47fd2050d728f5982ed1eafb67332cdc760a34cf17bf0162244dcd28340eb60886373e849ab1822c53503c153a88961172d4", "(13) 99898-1234", "Fisica" },
                    { 3, true, "127.321.335-49", new DateTime(2022, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(5738), new DateTime(1967, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(5739), "Bebeto@hotmail.com", "Masculino", "", true, "Roberto Gomes", "8488472172485868cb8b8bfaebdf156101e40770c423a021b2a7933ddfcc79f0c77b643535db964221eeea5fbbdd783bf30365f9a90821fc771456ca720209c4", "(18) 12398-1234", "Fisica" },
                    { 4, false, "132.321.444-23", new DateTime(2022, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(6166), new DateTime(1963, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(6166), "Ruanzito@hotmail.com", "Masculino", "", true, "Ruan", "ce05b43dd174f1bdc646bdc10e70792a8043690b963075995e4d07a01c124ffef65da462239e2ae9e6bbab185c2895f117917eb9105c42ee3a7327d1ead4edf3", "(13) 13456-1234", "Fisica" },
                    { 5, true, "170.167.342-38", new DateTime(2022, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(6646), new DateTime(1984, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(6647), "Matheus.Flex@hotmail.com", "Fasculino", "", true, "Matheus Flexivel", "4a82615c8e9ed8cc5ea97ca7b95dd397b634e7d94cfb9d9f8f41e05d69dca9bdcf66bc80cef1c61f6b2fc9ed6de1c500b6c15de53418fcb4621813b12f801bff", "(99) 99758-3221", "Fisica" },
                    { 6, true, "323.188.999-32", new DateTime(2022, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(7064), new DateTime(1999, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(7065), "Rafaela.Love@hotmail.com", "Feminino", "", true, "Rafaela Love", "41876995b4b08a066ce8b0de42b08997f040d440ac59bc746238fc569b7728cb93893fe662fd12b02bba42fe1b9aada9f3b0b7d3616d9a8e20279aea20d7f899", "(13) 89899-7777", "Fisica" },
                    { 7, false, "556.902.300-30", new DateTime(2022, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(7483), new DateTime(1985, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(7484), "Show@hotmail.com", "Masculino", "559300404717", false, "Show Moon", "469ab1c50e1906b9b16f247c6a0a225f9f03d7729d54425546df741e4e69c95aec5261482cf3abcb3fac1b65016b27b3eb318104d945c5134d33dc3639d8c152", "(13) 99898-1234", "Juridica" },
                    { 8, false, "556.902.300-30", new DateTime(2022, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(7897), new DateTime(2005, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(7898), "Elias-Desu@hotmail.com", "Masculino", "", true, "Elias Desu", "82d8f02f1869a0ee044ca9deb9ff585555a9ff3969d17842fef4165588a92471413a7dab4855c9d0b3ea47a63018fccf66e2af8555aa28c8e11d83d294057709", "(13) 99898-1234", "Fisica" },
                    { 9, true, "243.892.180-34", new DateTime(2022, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(8349), new DateTime(2010, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(8350), "SuperMen@hotmail.com", "Masculino", "114414815878", false, "Super Homem", "a763389d742ebc44071cf44d2b1e32dd05a4cd1ec996187774ae6d1da0acfd9fc232e560324bb17ac8414638865160653339fe0329ca593ecbcee8be77d92b61", "(13) 99898-1234", "Juridica" },
                    { 10, false, "798.740.230-31", new DateTime(2022, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(8768), new DateTime(1789, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(8769), "HDASUI@outlook.com", "Masculino", "", true, "Hdasui", "40e0916bfec48a01cd3bd1d189f2a43e37529cc8c8970ae17143db233bfe0c8503b5b0466f311419ebe2357fc1ca504e2df4804328d672bb1cb9ba1fc189d633", "(13) 99898-1234", "Fisica" },
                    { 11, false, "262.991.203-55", new DateTime(2022, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(9196), new DateTime(1899, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(9197), "jose_emanuel_darosa@hotmailo.com", "Masculino", "", true, "José Emanuel Hugo da Rosa", "82d8f02f1869a0ee044ca9deb9ff585555a9ff3969d17842fef4165588a92471413a7dab4855c9d0b3ea47a63018fccf66e2af8555aa28c8e11d83d294057709", "(13) 99898-1234", "Fisica" },
                    { 12, false, "556.902.300-30", new DateTime(2022, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(9610), new DateTime(1963, 6, 27, 16, 54, 44, 539, DateTimeKind.Local).AddTicks(9611), "eduarda_martins@quimicaindaiatuba.com.br", "Feminino", "", true, "Eduarda Luana Julia Martins", "82d8f02f1869a0ee044ca9deb9ff585555a9ff3969d17842fef4165588a92471413a7dab4855c9d0b3ea47a63018fccf66e2af8555aa28c8e11d83d294057709", "(85) 99948-0437", "Fisica" },
                    { 13, false, "90.476.749/0001-00", new DateTime(2022, 6, 27, 16, 54, 44, 540, DateTimeKind.Local).AddTicks(66), new DateTime(2012, 6, 27, 16, 54, 44, 540, DateTimeKind.Local).AddTicks(67), "juridico@miguelerebecaeletronicaltda.com.br", "Masculino", "770000098889", false, "Miguel e Rebeca Eletrônica Ltda", "983bdde96f2b56ea154b87ef8107eec753193e16e2734d02f25c9b3b15d8bc3047f77212371c15009c99c7281f682749d5502668080d37a117598152048c74b6", "(13) 99898-1234", "Juridica" },
                    { 14, true, "63.577.648/0001-45", new DateTime(2022, 6, 27, 16, 54, 44, 540, DateTimeKind.Local).AddTicks(486), new DateTime(2020, 6, 27, 16, 54, 44, 540, DateTimeKind.Local).AddTicks(487), "orcamento@nathanepatriciaentulhosltda.com.br", "Masculino", "598816160020", false, "Marina e Isabela Padaria ME", "33fe27fa67128aa75dc0620008a310f7fd7de23e135d780a9eb6c08a818196367f3c29916f639132607f17a15bfd05681ead73bd58f309b1f84dc34ab5d69572", "(11) 99937-9238", "Juridica" },
                    { 15, false, "99.157.045/0001-31", new DateTime(2022, 6, 27, 16, 54, 44, 540, DateTimeKind.Local).AddTicks(905), new DateTime(2010, 6, 27, 16, 54, 44, 540, DateTimeKind.Local).AddTicks(906), "comunicacoes@marinaeizabela.com.br", "Masculino", "698917126033", true, "Marina e Isabela Padaria ME", "23404e5d79d9f2556c681e2b16f5469d500befd7b62e377881537cfa9b27210a7aa96e320e1c2c5da0269d23f39be5432ca5861c213d91bf8bed4a790a1b570f", "(12) 99307-1234", "Juridica" },
                    { 16, false, "56.542.713/0001-31", new DateTime(2022, 6, 27, 16, 54, 44, 540, DateTimeKind.Local).AddTicks(1322), new DateTime(1967, 6, 27, 16, 54, 44, 540, DateTimeKind.Local).AddTicks(1323), "diretoria@aparecidaebeneditodocessalgadosltda.com.br", "Masculino", "401639480020", false, "Aparecida e Benedito Doce e Salgados", "3c1ae58f94079b4851b49f5618f3b0c1ff1956293ac30a46ae522a38c02f6c0d06f387515f2fa71c3d7e7dbb5fe3a8d9b325a4ce90cf414165fc24a519a68f0d", "(14) 98677-6241", "Juridica" },
                    { 17, true, "274.210.736-39", new DateTime(2022, 6, 27, 16, 54, 44, 540, DateTimeKind.Local).AddTicks(1785), new DateTime(1978, 6, 27, 16, 54, 44, 540, DateTimeKind.Local).AddTicks(1786), "calebe.pietro.damata@policiamilitar.sp.gov.br", "Masculino", "", false, "Calebe Pietro da Mata", "d09718a015d783829c5dbabaef88675641e833807a82078a4040f945fcc500bb9f94d6db008d4120d719dfbfb99829200724bd27a7f89a84b2e05550c844899f", "(27) 98896-6365", "Fisica" },
                    { 18, true, "754.978.850-20", new DateTime(2022, 6, 27, 16, 54, 44, 540, DateTimeKind.Local).AddTicks(2251), new DateTime(1990, 6, 27, 16, 54, 44, 540, DateTimeKind.Local).AddTicks(2252), "calebe.pietro.damata@policiamilitar.sp.gov.br", "Masculino", "", false, "Benedito Lucca Geraldo Silveira", "fc9ae11dfa7acd9b16e35da1d06b36f0785c8e3e1b8dd11aedb47999eb93d048b32946502d00727d328a93813f09fdce65e12559b4667c72a00d0181412192ad", "(27) 98499-2121", "Fisica" },
                    { 19, true, "007.261.466-84", new DateTime(2022, 6, 27, 16, 54, 44, 540, DateTimeKind.Local).AddTicks(2669), new DateTime(1957, 6, 27, 16, 54, 44, 540, DateTimeKind.Local).AddTicks(2670), "catarina_damata@oralcamp.com.br", "Masculino", "", false, "Catarina Aline da Mata", "072c8f41f398082b172181ad5c050ec885ed4b50c01aed572921ffcf0bde7311d118b94b687d02c3cb13f43b94e52d54156fc22f8b5a0fbacfa580dfa98ca537", "(86) 98365-8932", "Fisica" },
                    { 20, false, "415.498.554-09", new DateTime(2022, 6, 27, 16, 54, 44, 540, DateTimeKind.Local).AddTicks(3086), new DateTime(1999, 6, 27, 16, 54, 44, 540, DateTimeKind.Local).AddTicks(3086), "alexandremanoelduarte@kinouchi.com.br", "Masculino", "", true, "Alexandre Manoel Duarte", "116d437a5925c1158a821361ce2ff398802ec616122e2f17f8cf1c08d3f7c6a807f9c3945c159aacb7ea6aaf1224735429aee39cc767908ec622a050c3f97174", "(82) 98544-7243", "Fisica" },
                    { 21, false, "115.448.354-22", new DateTime(2022, 6, 27, 16, 54, 44, 540, DateTimeKind.Local).AddTicks(3526), new DateTime(2008, 6, 27, 16, 54, 44, 540, DateTimeKind.Local).AddTicks(3527), "BABADI@ROKIROKI.com.br", "Outro", "", true, "Babadi Roki Roki", "9b4be8a788bf8418333969e714c8cee91b41f40d5be7caab60629d35f78a020fb7a32040f054cc36fbd9086e08d6cf704009662fa6249edbd575f8b9f9060fff", "(99) 99999-9999", "Fisica" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
