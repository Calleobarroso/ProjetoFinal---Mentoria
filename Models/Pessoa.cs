namespace MentoriaProjFinal.Models
{
    public class Pessoa
    {
        public int ID { get; set; }
        public string? Nome { get; set; }
        public int CPF { get; set; }
        public int Nascimento { get; set; }
        public string? Endereço { get; set; }
    }
}