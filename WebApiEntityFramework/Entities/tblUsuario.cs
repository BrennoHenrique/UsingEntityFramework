namespace WebApiEntityFramework.Entities
{
    public class tblUsuario
    {
        public int IdUsuario { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }

        public void SetEmail(string newEmail) => this.Email = newEmail;
    }
}
