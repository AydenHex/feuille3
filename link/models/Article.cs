namespace link.models
{
    public class Article
    {
        private int identifiant;
        private string denomination;
        private int prix;

        public Article(int identifiant, string denomination, int prix) {
            this.identifiant = identifiant;
            this.denomination = denomination;
            this.prix = prix;
        }

        public int Identifiant {
            get { return this.identifiant; }
            set { this.identifiant = value; }
        }

        public override string ToString()
        {
            return $"No°: {this.identifiant} - {this.denomination} €: {this.prix}";
        }
    }
}