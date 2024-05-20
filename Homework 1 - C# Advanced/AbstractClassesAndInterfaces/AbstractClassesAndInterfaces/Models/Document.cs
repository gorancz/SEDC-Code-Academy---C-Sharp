using AbstractClassesAndInterfaces.Interfaces;

namespace AbstractClassesAndInterfaces.Models
{
    public class Document : ISearchable
    {
        private string text;

        public Document(string text)
        {
            this.text = text;
        }

        public bool Search(string word)
        {
            return text.Contains(word);
        }
    }
}
