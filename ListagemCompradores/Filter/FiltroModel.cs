namespace ListagemCompradores.Filter
{
    public class FiltroModel
    {
        public string Nomee { get; set; } 
        public string Emaill { get; set; }
        public string Telefonee { get; set; }
        public DateTime? DataCadastroo { get; set; } = null;
        public bool Bloqueadoo { get; set; }

    }
}
