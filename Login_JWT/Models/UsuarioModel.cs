using Login_JWT.Enum;

namespace Login_JWT.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Usuario { get; set; }
        public CargoEnum Cargo { get; set; }
        public byte [] SenhaHash { get; set; }
        public byte[] SenhaSalt { get; set; }
        public DateTime TokenDataCricao { get; set; } = DateTime.Now;
    }
}
