using static System.Net.Mime.MediaTypeNames;

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
            Button bt = (Button)sender;
            if (bt.Text == "החלף טקסט")
            {
                bt.Text = "החזר טקסט";
                lbl_year.Text = "Welcome 2024!";
            }
            else
            {
                bt.Text = "החלף טקסט";
                lbl_year.Text = "Goodbey 2023!";
            }
                

        }
    }
}