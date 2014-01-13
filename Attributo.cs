namespace PocketSql
{
    public class Attributo
    {
        public Attributo(string nome, string tipo, bool opt = false, bool pk = false, string fk = "")
        {
            Nome = nome;
            Tipo = tipo;
            PK = pk;
            FK = fk;
            Opzionale = opt;
        }

        public string Nome { get; set; }
        public string Tipo { get; set; }
        public bool PK { get; set; }
        public string FK { get; set; }
        public bool Opzionale { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}