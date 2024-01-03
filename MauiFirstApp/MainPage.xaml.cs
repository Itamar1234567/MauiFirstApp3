namespace MauiFirstApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        private void ChangeTextEvent(object sender, EventArgs e)
        {
            Button bt=(Button)sender;
            bt.Text = "החזר טקסט";
        }
    }
}