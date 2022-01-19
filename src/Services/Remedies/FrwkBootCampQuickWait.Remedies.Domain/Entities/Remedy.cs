
namespace FrwkBootCampQuickWait.Remedies.Domain.Entities
{
    public sealed class Remedy
    {
        #region "Propriedades"

        public Guid Id { get; private set; }

        public string Nome { get; private set; }

        #endregion

        #region "Construtor"

        public Remedy(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome;
        }

        #endregion

    }
}
