using System.Collections.ObjectModel;
using System.Security.AccessControl;

namespace YourCity;

public partial class MainPage : ContentPage
{
    public ObservableCollection<Grouping<string, Streets>> Streets { get; set; }

    public MainPage()
	{

		InitializeComponent();

        var users = new List<Streets>
        {
               new Streets { Streets_name="ул. Арбат", City_name="Москва", ImagePath="https://static.guidego.ru/611cfa7143a5ecb62f45ae20.1280x960.jpeg"},
                new Streets { Streets_name="ул. Невский проспект", City_name="Санкт-Петербург", ImagePath="https://interesnyefakty.org/wp-content/uploads/Nevskiy-prospekt.jpg"},
                new Streets { Streets_name = "ул. Красная площадь", City_name = "Москва", ImagePath = "https://kadet39.ru/wp-content/uploads/b/3/d/b3d095392697014794ff9bbe5fa514b1.jpeg" },
                new Streets { Streets_name = "пр. Ленина", City_name = "Новосибирск", ImagePath = "http://temples.ru/private/f001008/254_0276715b.jpg" },
                new Streets { Streets_name = "ул. Вайнера", City_name = "Екатеринбург", ImagePath = "https://pp.userapi.com/c631528/v631528618/458ba/ZrC2p3rNKt0.jpg" },
                new Streets { Streets_name = "ул. Тверская", City_name = "Москва", ImagePath = "https://img.1ku.ru/c81771d06501e988ca92146fab985ec5/wp-content/uploads/2018/09/91d23275e953e93cb60b63095b6881d2.jpg" },
                new Streets { Streets_name = "ул. Большая Садовая", City_name = "Санкт-Петербург", ImagePath = "https://img-fotki.yandex.ru/get/6310/66666794.4e/0_6c1d6_1d9ddd82_XXL.jpg" },
                new Streets { Streets_name = "ул. Красноармейская", City_name = "Новосибирск", ImagePath = "https://core-pht-proxy.maps.yandex.ru/v1/photos/download?photo_id=4kCw0eDfU-vxexqhp7bkMA&image_size=XL" },
                new Streets {Streets_name="ул. Лиговский проспект", City_name="Санкт-Петербург", ImagePath="https://webpulse.imgsmail.ru/imgpreview?mb=webpulse&key=pulse_cabinet-image-ec3b5777-ff2b-40ed-925b-883065c78bf7"},
                new Streets { Streets_name = "ул. 8 Марта", City_name = "Екатеринбург", ImagePath = "https://nesiditsa.ru/wp-content/uploads/2012/09/101.jpg" },

        };
        // получаем группы
        var groups = users.GroupBy(p => p.City_name).Select(g => new Grouping<string, Streets>(g.Key, g));
        // передаем группы в UserGroups
        Streets = new ObservableCollection<Grouping<string, Streets>>(groups);
        BindingContext = this;

    }

    //private async void Button_Clicked(object sender, EventArgs e)
    //{
    //    await Navigation.PushAsync(new News(MainLabelStreetsName.Text, MainLabelCity_name.Text));
    //}

    private async void collectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        await Navigation.PushAsync(new News(MainLabelStreetsName.Text, MainLabelCity_name.Text));
    }
}

