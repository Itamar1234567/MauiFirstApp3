using MauiApp2;
using static System.Net.Mime.MediaTypeNames;

namespace MauiFirstApp
{
    public partial class MainPage : ContentPage
    {
        List<Monkey> monkeyList;
        int place = 0;
        public MainPage()
        {
            InitializeComponent();
            monkeyList = Monkey.GetMonkeys();
            img_monkey.Source = monkeyList[place].Image;
        }

        private void ChangeMonkeyImageUpEvent(object sender, EventArgs e)
        {
            if (place < monkeyList.Count()-1)
            {
                place++;
                img_monkey.Source = monkeyList[place].Image;
            }
            else
                btn_changeMonkeyImageUp.IsEnabled = false;

            if (place == 1 && btn_changeMonkeyImageDown.IsEnabled == false)
            {
                btn_changeMonkeyImageDown.IsEnabled = true;
            }

        }
        private void ChangeMonkeyImageDownEvent(object sender, EventArgs e)
        {
            if (place > 0)
            {
                place--;
                img_monkey.Source = monkeyList[place].Image;
            }
            else
                btn_changeMonkeyImageUp.IsEnabled = false;
            if(place ==monkeyList.Count()-2 && btn_changeMonkeyImageUp.IsEnabled==false) 
            {
                btn_changeMonkeyImageUp.IsEnabled = true;
            }

        }

        //private void ChangeTextEvent(object sender, EventArgs e)
        //{
        //    Button bt = (Button)sender;
        //    if (bt.Text == "החלף טקסט")
        //    {
        //        bt.Text = "החזר טקסט";
        //        lbl_year.Text = "Welcome 2024!";
        //    }
        //    else
        //    {
        //        bt.Text = "החלף טקסט";
        //        lbl_year.Text = "Goodbey 2023!";
        //    }


        //}

    }
}