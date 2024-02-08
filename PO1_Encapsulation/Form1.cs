namespace PO1_Encapsulation
{
    public partial class Form1 : Form
    {
        Personnage joueur = new Personnage(); // je me cree un personnage
        Personnage dragon = new();

        public Form1()
        {
            InitializeComponent();
            //propriete pour acceeder aux attributs privé. on selectionne nos attribut dans la classe puis on fait action rapide et apres encapsuler les champs et utuliser la propriété
            joueur.PointsDeVie = 10;
            dragon.PointsDeVie = joueur.PointsDeVie * 3;
            joueur.PointsDePuissance = 1;
            dragon.PointsDePuissance = joueur.PointsDePuissance * 3;


        }
        private void ActualiserLabel()
        {
            lbl_pointsVieJoueur.Text = "point de vie :" + joueur.PointsDeVie.ToString(); //pour changer le label et mettre devant les pdv du joueur 

            lbl_pointsVieDragon.Text = "point de vie: " + dragon.PointsDeVie.ToString(); //pour changer le label et mettre devant les pdv du dragon 

            lbl_puissanceAttaqueJoueur.Text = " puissance d'attaque: " + joueur.PointsDePuissance.ToString();

            lbl_puissanceAttaqueDragon.Text = "puissance d'attaque: " + dragon.PointsDePuissance.ToString();
        }
        private void btn_attaquer_Click(object sender, EventArgs e)
        {
            ActualiserLabel();
            TourDragon();
            dragon.PointsDeVie -= joueur.PointsDePuissance;  // si le joueur tape le dragon il s enleve 1 de vie 
        }

        private void btn_seSoigner_Click(object sender, EventArgs e)
        {
            joueur.PointsDeVie += 5;
            TourDragon();
            ActualiserLabel();
        }

        private void btn_puissanceAttaque_Click(object sender, EventArgs e)
        {
            joueur.PointsDePuissance += 1;
            TourDragon();
            ActualiserLabel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualiserLabel();
        }
        private void TourDragon()
        {
            joueur.PointsDeVie -= dragon.PointsDePuissance;
        }
    }
}