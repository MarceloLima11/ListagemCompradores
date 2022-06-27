using ListagemCompradores.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Text;
using XSystem.Security.Cryptography;

namespace ListagemCompradores.Context
{
    public class ListagemDbContext : DbContext
    {
        private readonly IConfiguration _configuration;
    
        public ListagemDbContext(DbContextOptions<ListagemDbContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var mySqlConnection = _configuration.GetConnectionString("ListagemConnection");
            
            if (optionsBuilder.IsConfigured) return;

            optionsBuilder.UseMySql(mySqlConnection, ServerVersion.AutoDetect(mySqlConnection));

            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasData(new Cliente
            {
                Id = 1,
                Senha = GetSHA512("12345678"),
                ConfirmarSenha = GetSHA512("12345678"),
                Bloqueado = false,
                CpfCnpj = "321.123.321-14",
                Email = "Admin@hotmail.com",
                DataCadastro = DateTime.Now,
                DataNascimento = DateTime.Now.AddYears(-21),
                Genero = "Masculino",
                InscricaoEstadual = "",
                Isento = true,
                Nome = "Administrador",
                Telefone = "(13) 99999-9999",
                TipoPessoa = "Fisica"
            },
            new Cliente
            {
                Id = 2,
                Senha = GetSHA512("1234567812"),
                ConfirmarSenha = GetSHA512("1234567812"),
                Bloqueado = false,
                CpfCnpj = "123.321.342-48",
                Email = "Junior@hotmail.com",
                DataCadastro = DateTime.Now,
                DataNascimento = DateTime.Now.AddYears(-23),
                Genero = "Masculino",
                InscricaoEstadual = "",
                Isento = true,
                Nome = "Junior Leite",
                Telefone = "(13) 99898-1234",
                TipoPessoa = "Fisica"
            },
            new Cliente
            {
                Id = 3,
                Senha = GetSHA512("123kdasopd2"),
                ConfirmarSenha = GetSHA512("123kdasopd2"),
                Bloqueado = true,
                CpfCnpj = "127.321.335-49",
                Email = "Bebeto@hotmail.com",
                DataCadastro = DateTime.Now,
                DataNascimento = DateTime.Now.AddYears(-55),
                Genero = "Masculino",
                InscricaoEstadual = "",
                Isento = true,
                Nome = "Roberto Gomes",
                Telefone = "(18) 12398-1234",
                TipoPessoa = "Fisica"
            },
            new Cliente
            {
                Id = 4,
                Senha = GetSHA512("23hjo1i3j1"),
                ConfirmarSenha = GetSHA512("23hjo1i3j1"),
                Bloqueado = false,
                CpfCnpj = "132.321.444-23",
                Email = "Ruanzito@hotmail.com",
                DataCadastro = DateTime.Now,
                DataNascimento = DateTime.Now.AddYears(-59),
                Genero = "Masculino",
                InscricaoEstadual = "",
                Isento = true,
                Nome = "Ruan",
                Telefone = "(13) 13456-1234",
                TipoPessoa = "Fisica"
            },
            new Cliente
            {
                Id = 5,
                Senha = GetSHA512("i2o1jio21"),
                ConfirmarSenha = GetSHA512("i2o1jio21"),
                Bloqueado = true,
                CpfCnpj = "170.167.342-38",
                Email = "Matheus.Flex@hotmail.com",
                DataCadastro = DateTime.Now,
                DataNascimento = DateTime.Now.AddYears(-38),
                Genero = "Fasculino",
                InscricaoEstadual = "",
                Isento = true,
                Nome = "Matheus Flexivel",
                Telefone = "(99) 99758-3221",
                TipoPessoa = "Fisica"
            },
            new Cliente
            {
                Id = 6,
                Senha = GetSHA512("j21iojio12"),
                ConfirmarSenha = GetSHA512("j21iojio12"),
                Bloqueado = true,
                CpfCnpj = "323.188.999-32",
                Email = "Rafaela.Love@hotmail.com",
                DataCadastro = DateTime.Now,
                DataNascimento = DateTime.Now.AddYears(-23),
                Genero = "Feminino",
                InscricaoEstadual = "",
                Isento = true,
                Nome = "Rafaela Love",
                Telefone = "(13) 89899-7777",
                TipoPessoa = "Fisica"
            },
            new Cliente
            {
                Id = 7,
                Senha = GetSHA512("128390383"),
                ConfirmarSenha = GetSHA512("128390383"),
                Bloqueado = false,
                CpfCnpj = "556.902.300-30",
                Email = "Show@hotmail.com",
                DataCadastro = DateTime.Now,
                DataNascimento = DateTime.Now.AddYears(-37),
                Genero = "Masculino",
                InscricaoEstadual = "559300404717",
                Isento = false,
                Nome = "Show Moon",
                Telefone = "(13) 99898-1234",
                TipoPessoa = "Juridica"
            },
            new Cliente
            {
                Id = 8,
                Senha = GetSHA512("232132121"),
                ConfirmarSenha = GetSHA512("232132121"),
                Bloqueado = false,
                CpfCnpj = "556.902.300-30",
                Email = "Elias-Desu@hotmail.com",
                DataCadastro = DateTime.Now,
                DataNascimento = DateTime.Now.AddYears(-17),
                Genero = "Masculino",
                InscricaoEstadual = "",
                Isento = true,
                Nome = "Elias Desu",
                Telefone = "(13) 99898-1234",
                TipoPessoa = "Fisica"
            },
            new Cliente
            {
                Id = 9,
                Senha = GetSHA512("H12IU1I12"),
                ConfirmarSenha = GetSHA512("H12IU1I12"),
                Bloqueado = true,
                CpfCnpj = "243.892.180-34",
                Email = "SuperMen@hotmail.com",
                DataCadastro = DateTime.Now,
                DataNascimento = DateTime.Now.AddYears(-12),
                Genero = "Masculino",
                InscricaoEstadual = "114414815878",
                Isento = false,
                Nome = "Super Homem",
                Telefone = "(13) 99898-1234",
                TipoPessoa = "Juridica"
            },
            new Cliente
            {
                Id = 10,
                Senha = GetSHA512("AS89DSAD97A8S"),
                ConfirmarSenha = GetSHA512("AS89DSAD97A8S"),
                Bloqueado = false,
                CpfCnpj = "798.740.230-31",
                Email = "HDASUI@outlook.com",
                DataCadastro = DateTime.Now,
                DataNascimento = DateTime.Now.AddYears(-233),
                Genero = "Masculino",
                InscricaoEstadual = "",
                Isento = true,
                Nome = "Hdasui",
                Telefone = "(13) 99898-1234",
                TipoPessoa = "Fisica"
            },
            new Cliente
            {
                Id = 11,
                Senha = GetSHA512("232132121"),
                ConfirmarSenha = GetSHA512("232132121"),
                Bloqueado = false,
                CpfCnpj = "262.991.203-55",
                Email = "jose_emanuel_darosa@hotmailo.com",
                DataCadastro = DateTime.Now,
                DataNascimento = DateTime.Now.AddYears(-123),
                Genero = "Masculino",
                InscricaoEstadual = "",
                Isento = true,
                Nome = "José Emanuel Hugo da Rosa",
                Telefone = "(13) 99898-1234",
                TipoPessoa = "Fisica"
            },
            new Cliente
            {
                Id = 12,
                Senha = GetSHA512("232132121"),
                ConfirmarSenha = GetSHA512("232132121"),
                Bloqueado = false,
                CpfCnpj = "556.902.300-30",
                Email = "eduarda_martins@quimicaindaiatuba.com.br",
                DataCadastro = DateTime.Now,
                DataNascimento = DateTime.Now.AddYears(-59),
                Genero = "Feminino",
                InscricaoEstadual = "",
                Isento = true,
                Nome = "Eduarda Luana Julia Martins",
                Telefone = "(85) 99948-0437",
                TipoPessoa = "Fisica"
            },
            new Cliente
            {
                Id = 13,
                Senha = GetSHA512("2doko2k221"),
                ConfirmarSenha = GetSHA512("2doko2k221"),
                Bloqueado = false,
                CpfCnpj = "90.476.749/0001-00",
                Email = "juridico@miguelerebecaeletronicaltda.com.br",
                DataCadastro = DateTime.Now,
                DataNascimento = DateTime.Now.AddYears(-10),
                Genero = "Masculino",
                InscricaoEstadual = "770000098889",
                Isento = false,
                Nome = "Miguel e Rebeca Eletrônica Ltda",
                Telefone = "(13) 99898-1234",
                TipoPessoa = "Juridica"
            },
            new Cliente
            {
                Id = 14,
                Senha = GetSHA512("238392791h"),
                ConfirmarSenha = GetSHA512("238392791h"),
                Bloqueado = true,
                CpfCnpj = "63.577.648/0001-45",
                Email = "orcamento@nathanepatriciaentulhosltda.com.br",
                DataCadastro = DateTime.Now,
                DataNascimento = DateTime.Now.AddYears(-2),
                Genero = "Masculino",
                InscricaoEstadual = "598816160020",
                Isento = false,
                Nome = "Marina e Isabela Padaria ME",
                Telefone = "(11) 99937-9238",
                TipoPessoa = "Juridica"
            },
            new Cliente
            {
                Id = 15,
                Senha = GetSHA512("KO2K1P231"),
                ConfirmarSenha = GetSHA512("KO2K1P231"),
                Bloqueado = false,
                CpfCnpj = "99.157.045/0001-31",
                Email = "comunicacoes@marinaeizabela.com.br",
                DataCadastro = DateTime.Now,
                DataNascimento = DateTime.Now.AddYears(-12),
                Genero = "Masculino",
                InscricaoEstadual = "698917126033",
                Isento = true,
                Nome = "Marina e Isabela Padaria ME",
                Telefone = "(12) 99307-1234",
                TipoPessoa = "Juridica"
            },
            new Cliente
            {
                Id = 16,
                Senha = GetSHA512("212asdK1P231"),
                ConfirmarSenha = GetSHA512("212asdK1P231"),
                Bloqueado = false,
                CpfCnpj = "56.542.713/0001-31",
                Email = "diretoria@aparecidaebeneditodocessalgadosltda.com.br",
                DataCadastro = DateTime.Now,
                DataNascimento = DateTime.Now.AddYears(-55),
                Genero = "Masculino",
                InscricaoEstadual = "401639480020",
                Isento = false,
                Nome = "Aparecida e Benedito Doce e Salgados",
                Telefone = "(14) 98677-6241",
                TipoPessoa = "Juridica"
            },
            new Cliente
            {
                Id = 17,
                Senha = GetSHA512("21I90SD231"),
                ConfirmarSenha = GetSHA512("21I90SD231"),
                Bloqueado = true,
                CpfCnpj = "274.210.736-39",
                Email = "calebe.pietro.damata@policiamilitar.sp.gov.br",
                DataCadastro = DateTime.Now,
                DataNascimento = DateTime.Now.AddYears(-44),
                Genero = "Masculino",
                InscricaoEstadual = "",
                Isento = false,
                Nome = "Calebe Pietro da Mata",
                Telefone = "(27) 98896-6365",
                TipoPessoa = "Fisica"
            },
            new Cliente
            {
                Id = 18,
                Senha = GetSHA512("89sd89sadd"),
                ConfirmarSenha = GetSHA512("89sd89sadd"),
                Bloqueado = true,
                CpfCnpj = "754.978.850-20",
                Email = "calebe.pietro.damata@policiamilitar.sp.gov.br",
                DataCadastro = DateTime.Now,
                DataNascimento = DateTime.Now.AddYears(-32),
                Genero = "Masculino",
                InscricaoEstadual = "",
                Isento = false,
                Nome = "Benedito Lucca Geraldo Silveira",
                Telefone = "(27) 98499-2121",
                TipoPessoa = "Fisica"
            },
            new Cliente
            {
                Id = 19,
                Senha = GetSHA512("tt822j3199"),
                ConfirmarSenha = GetSHA512("tt822j3199"),
                Bloqueado = true,
                CpfCnpj = "007.261.466-84",
                Email = "catarina_damata@oralcamp.com.br",
                DataCadastro = DateTime.Now,
                DataNascimento = DateTime.Now.AddYears(-65),
                Genero = "Masculino",
                InscricaoEstadual = "",
                Isento = false,
                Nome = "Catarina Aline da Mata",
                Telefone = "(86) 98365-8932",
                TipoPessoa = "Fisica"
            },
            new Cliente
            {
                Id = 20,
                Senha = GetSHA512("ds78d7d8d98a"),
                ConfirmarSenha = GetSHA512("ds78d7d8d98a"),
                Bloqueado = false,
                CpfCnpj = "415.498.554-09",
                Email = "alexandremanoelduarte@kinouchi.com.br",
                DataCadastro = DateTime.Now,
                DataNascimento = DateTime.Now.AddYears(-23),
                Genero = "Masculino",
                InscricaoEstadual = "",
                Isento = true,
                Nome = "Alexandre Manoel Duarte",
                Telefone = "(82) 98544-7243",
                TipoPessoa = "Fisica"
            },
            new Cliente
            {
                Id = 21,
                Senha = GetSHA512("DUASD98DU90"),
                ConfirmarSenha = GetSHA512("DUASD98DU90"),
                Bloqueado = false,
                CpfCnpj = "115.448.354-22",
                Email = "BABADI@ROKIROKI.com.br",
                DataCadastro = DateTime.Now,
                DataNascimento = DateTime.Now.AddYears(-14),
                Genero = "Outro",
                InscricaoEstadual = "",
                Isento = true,
                Nome = "Babadi Roki Roki",
                Telefone = "(99) 99999-9999",
                TipoPessoa = "Fisica"
            }
            );


            base.OnModelCreating(modelBuilder);
        }

        public static string GetSHA512(string senha)
        {
            UnicodeEncoding UE = new UnicodeEncoding();

            byte[] HashValue, MessageBytes = ASCIIEncoding.UTF8.GetBytes(senha);

            SHA512Managed shaManaged = new SHA512Managed();

            HashValue = shaManaged.ComputeHash(MessageBytes);

            string strSha = string.Join("", HashValue.Select(x => string.Format("{0:x2}", x)));

            return strSha;
        }
    }
}
