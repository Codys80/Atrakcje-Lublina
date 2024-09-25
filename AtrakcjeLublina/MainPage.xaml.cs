namespace AtrakcjeLublina
{
    public partial class MainPage : ContentPage
    {

        int likes = 0;


        public MainPage()
        {
            InitializeComponent();
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

}
