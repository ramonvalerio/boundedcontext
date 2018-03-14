using BoundedContext.NucleoCompartilhado.Domain.Model;

namespace BoundedContext.ControleAcesso.Domain.Model.Usuarios
{
    public class Email : ValueObject
    {
        public string Text { get; private set; }

        public Email(string text)
        {
            Text = text;
        }

        public bool IsValid()
        {
            if (Text.Length < 6)
                return false;

            if (!Text.Contains("@"))
                return false;

            if (!Text.Contains(".com"))
                return false;

            return true;
        }
    }
}