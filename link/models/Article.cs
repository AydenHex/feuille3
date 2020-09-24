namespace link.models
{
    public class Article
    {
        private int identifiant;
        private string denomination;
        private double prix;
        private int quantite;

        public Article(int identifiant, string denomination, double prix, int quantite) {
            this.identifiant = identifiant;
            this.denomination = denomination;
            this.prix = prix;
            this.quantite = quantite;
        }

        public int Identifiant {
            get { return this.identifiant; }
            set { this.identifiant = value; }
        }

        public string Denomination {
            get { return this.denomination; }
        }

        public double Prix {
            get { return this.prix; }
        }

        public int Quantite {
            get { return this.quantite; }
        }

        public override string ToString()
        {
            return $"No°: {this.identifiant} - {this.denomination} €: {this.prix} - Qt: {this.quantite}";
        }
    }
}