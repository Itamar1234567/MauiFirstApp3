using MauiApp2;
namespace MauiFirstApp;


public partial class DynamicControlsPage : ContentPage
{
    List<Monkey> monkeyList;
    int place = 0;
    int countup = 0;
    int countdown = 0;
   
    public DynamicControlsPage()
    {
        InitializeComponent();
        //����� ������ ����� �������
        monkeyList = Monkey.GetMonkeys();
        InitializeControlls();
    }

    private void InitializeControlls()
    {
        //Add your Code Here

        AddLayout();  //���� �����

        AddLabels();//���� �� �����

        AddButtons(); //���� �������



    }

    private void AddLayout()
    {
        //����� ����� ����
        StackLayout stackLayout = new StackLayout();
        //����� �� �����
        stackLayout.Orientation = StackOrientation.Vertical;
        //����
        stackLayout.Padding = new Thickness(30, 0);
        //����� ��� ������ ���� ������
        stackLayout.Spacing = 25;
        stackLayout.BackgroundColor = Colors.Brown;

        //����� ���� ����
        stackLayout.VerticalOptions = LayoutOptions.Center;
        //���� ���� ���� ����
        this.Content = stackLayout;

    }
    private void AddLabels()
    {
        //����� ����
        Label lbl = new Label()
        {
            HorizontalOptions = LayoutOptions.Center,
            Text = "�����",
            FontSize = 12


        };
        StackLayout stk = (StackLayout)this.Content;
        stk.Children.Add(lbl);
        //OnPlatform....=>DeviceInfo.Current.Platform=DevicePlatform....
        DevicePlatform OnPlatform = DeviceInfo.Current.Platform;
        if (OnPlatform == DevicePlatform.Android || OnPlatform == DevicePlatform.iOS)
            lbl.FontSize = 15;
        else
            lbl.FontSize = 25;

        //����� ���� ����
        //����: ���� ������ ������� ������� ������ �� ���� ���� ����� 
        //������ ����� ����� ������ ����� ����� ������� ���� ������



    }

    //�������
    private void AddButtons()
    {
        //���� �� ������
        StackLayout stk = (StackLayout)this.Content;
        //����� ����� 1==="\uef7d"
        Button upBtn = new Button()
        {
            HorizontalOptions
        = LayoutOptions.Center,
            Text = "��� �����"

        };
        //����� ����� ������
        upBtn.ImageSource = new FontImageSource()
        {
            FontFamily = "MaterialSymbolsSharp",
            Glyph = "\uef7d",
            Color = Color.FromHex("#db1442")
        };
        //����� ������
        upBtn.Clicked += ClickedUpEvent;

        //����� 2
        //"\ue941"

        Button downBtn = new Button()
        {
            HorizontalOptions
       = LayoutOptions.Center,
            Text = "��� ����"

        };
        //����� ����� ������
        downBtn.ImageSource = new FontImageSource()
        {
            FontFamily = "MaterialSymbolsSharp",
            Glyph = "\uef7d",
            Color = Color.FromHex("#db1442")
        };
        //����� ������
        //����� ������ ������� anoymous functions =>
        downBtn.Clicked += (s, e) =>
        {
            countdown++;
            StackLayout stk = (StackLayout)this.Content;
            Label lbl_txt = stk.Children.FirstOrDefault(x => x is Label) as Label;
            lbl_txt.Text = $"  ����� {countdown} ����� ����";
        };

        //����� ������ �LAYOUT
        stk.Children.Insert(0, upBtn);
        stk.Children.Add(downBtn);
    }

    private void ClickedUpEvent(object sender, EventArgs e)
    {
        countup++;
        StackLayout stk = (StackLayout)this.Content;
        Label lbl_txt = stk.Children.FirstOrDefault(x => x is Label) as Label;
        lbl_txt.Text = $"  ����� {countup} ����� �����";
    }
}