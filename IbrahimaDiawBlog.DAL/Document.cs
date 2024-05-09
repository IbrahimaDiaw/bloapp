using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IbrahimaDiawBlog.DAL
{
    public class Document
    {
        protected string title {  get; set; }
        public Document(string title ) 
        {
            this.title = title;
        }

        Livre livre = new Livre("hello world", "Mouhammad", DateTime.Now);
        Document doc = new Document("title");
    }

    public class Livre : Document
    {
        public DateTime DatePublication { get; set; }
        public string Auteur { get; set; }
        public Livre(string title, string auteur, DateTime date) : base(title)
        {
            this.DatePublication = date;
            this.Auteur = auteur;
        }
    }

    public interface IEntite
    {

    }
}
