
namespace YourCity;

public partial class NewsDetail : ContentPage
{
	public NewsDetail(string NewsTitle, string NewsDetails, string NewsImage, string DataStart)
	{
		InitializeComponent();

        TitleNewsDetail.Text = $"{NewsTitle}";
        DetailsNewsDetail.Text = $"{NewsDetails}";
        ImageNewsDetail.Source =$"{NewsImage}";
        DataStartDetail.Text = $"{DataStart}";






    }
    private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
}