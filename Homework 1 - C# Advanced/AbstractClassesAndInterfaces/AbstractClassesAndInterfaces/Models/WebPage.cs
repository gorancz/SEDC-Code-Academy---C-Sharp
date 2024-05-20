using AbstractClassesAndInterfaces.Interfaces;

namespace AbstractClassesAndInterfaces.Models
{
    public class WebPage :ISearchable
    {
        private string url;
        private string pageContent;

        public WebPage(string url, string pageContent)
        {
            this.url = url;
            this.pageContent = pageContent;
        }

        public bool Search(string word)
        {
            return pageContent.Contains(word);
        }
    }
}
