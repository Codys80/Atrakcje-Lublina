namespace AtrakcjeLublina
{
    public partial class MainPage : ContentPage
    {

        int likes = 0;


        public MainPage()
        {
            InitializeComponent();

            List<Attraction> attractions = new List<Attraction>
            {
                new Attraction
                {
                    Name = "Zamek Lubelski",
                    Image = "getimage1.jpg"
                },
                new Attraction
                {
                    Name = "Stare Miasto",
                    Image = "getimage2.jpg"
                },
                new Attraction
                {
                    Name = "Czarcia Łapa",
                    Image = "getimage3.jpg"
                }
            };

        }

        private void IncrementLikes(object sender, EventArgs e)
        {
            likes++;
            LblLikeCounter.Text = $"Polubień: {likes}";

        }
        private void DecrementLikes(object sender, EventArgs e)
        {
            if (likes == 0){
                return;
            }
            likes--;
            LblLikeCounter.Text = $"Polubień: {likes}";
        }
    }

    public class Attraction
    {
        public string Name { get; set; }
        public string Image { get; set; }
    }

}
