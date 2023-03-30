

using System.Collections.ObjectModel;

namespace YourCity;


public partial class News : ContentPage
{
    public ObservableCollection<Grouping<string, NewsObj>> NewsObj { get; set; }
    public News(string MainLabelStreetsName, string MainLabelCity_name)
	{

		InitializeComponent();


       
        LabelCityName.Text = $"�����: {MainLabelCity_name}";
        LabelStreetsName.Text = $"�����: {MainLabelStreetsName}";

        var news = new List<NewsObj>
        {
               new NewsObj { DataStart = new DateTime (2023, 03 ,25),StreetsNameNews = "��. �����" ,NewsTitle = "�������� ����������� � ������������� �������", NewsDetails = "� ������������� ������� � 1 ������ ������� �������� �����������, �� ������� ������������ ������ ��������� ������������� ������. �������� ��������� �� 31 ���.", NewsImage = "https://switki.ru/assets/i/ai/4/7/7/i/3285859.jpg"},
                new NewsObj { DataStart = new DateTime (2023, 03 ,16),StreetsNameNews = "��. ������� ��������" ,NewsTitle = "����� ������� ������ �� ������� ���������", NewsDetails = "������� �� ������� ��������� �������� ����� �������, ������� ���������� ������� ����� ������� �� ��������� �����.", NewsImage = "http://rasfokus.ru/images/photos/medium/9e406768105dd8a8779b3375c28a3ff2.jpg"},
                new NewsObj { DataStart = new DateTime (2023, 02 ,27),StreetsNameNews = "��. ���������������" ,NewsTitle = "�������� ����� �� ���������������", NewsDetails = "������� �� �������������� �������� ����� �����, ��� ����� ������ � ������� ������ � ������. ���� ����������.", NewsImage = "https://avatars.mds.yandex.net/get-altay/859900/2a0000015f8c36faf0e2ec034ae593ccdbde/XXL"},
                new NewsObj { DataStart = new DateTime (2023, 01 ,08),StreetsNameNews = "��. ������" ,NewsTitle = "������������� ����� ������� �� ��. ������ �������� � ������", NewsDetails = "� ������ �������� ������������� ����� ������� �� ��. ������. ������ ����� ����� 60 ������ � ������ ����� �� ����� ������� � ������.", NewsImage = "https://sun9-31.userapi.com/impg/oHbj3dUxcskyv9EV5kXT5ku8kHHCSC5VHdQvFg/NpDdut40jxo.jpg?size=900x596&quality=95&sign=873d851c5f79999b2e60769aec630293&c_uniq_tag=DYVF1WVeZzpnAWwp1oIzwTn7HSgbofaSYC6mqr46wlg&type=album"},
                new NewsObj { DataStart = new DateTime (2023, 03 ,29),StreetsNameNews = "��. �������" ,NewsTitle = "�������� ������ ���� �� ��. �������", NewsDetails = "������� �� ��. ������� ��������� ����� ����, ��� ����� ����������� ������� ��� � ������ �������������� ����. ���� ���� � 10:00 �� 22:00.", NewsImage = "https://kartarf.ru/images/heritage/1080/5/59189.jpg" },
                new NewsObj { DataStart = new DateTime(2023, 04, 16), StreetsNameNews = "��. ������� ��������", NewsTitle = "�������� ������ ���� �� ������� ���������", NewsDetails = "�� ������� ��������� ��������� ����� ����, ������������ ������ � ������� ����� �� �������� �����. ���� ����������� � ����� ������ ������ � �������� �������� ������ ��� ���������� ������ � �������� � ������-����������.", NewsImage = "https://gcdn.tomesto.ru/img/place/000/022/580/restoran-mama-na-dache-na-nevskom-prospekte_c9f21_full-251119.jpg"},
                new NewsObj { DataStart = new DateTime(2023, 02, 16), StreetsNameNews = "��. ������� �������", NewsTitle = "������������� ��������� ������ �� ������� �������", NewsDetails = "� 15 ������ �� ������� ������� ������� ������������� ��������� ������, �� ������� �������� ��������� ����������� �� ������ ����� ����. ��������� ��������� �� ����� ������ � ������� ���� ����� � �������������� �������� ��� ���� ��������� ������.", NewsImage = "https://catherineasquithgallery.com/uploads/posts/2021-02/1612905309_134-p-krasnaya-ploshchad-fon-173.jpg"},
                new NewsObj { DataStart = new DateTime(2023, 01, 27), StreetsNameNews = "��. �������", NewsTitle = "�������� ������ �������� ����������� �� ����� �������", NewsDetails = "�� ����� ������� �������� ����� ������� �����������, ��� ����� ���������� ����� ����������� � ������������ �������. � ����� �������� ������� ���������� ������ �� ��� ��������� �� ����� ������.", NewsImage = "http://photos.wikimapia.org/p/00/02/31/90/25_full.jpeg"},
                new NewsObj { DataStart = new DateTime (2023, 03 ,07),StreetsNameNews = "��. ��������� ��������",NewsTitle = "�������� ������ ����������", NewsDetails = "������� �� ����� ��������� �������� �������� ����� ��������� ��������� ���������. � ���� ������������� �� ���������� ����� �������, ����� ���������� ����� ����� � ��������� ������. ", NewsImage = "https://cre.ru/content/upload/players/object/normal/1517075969339.jpg"},
                new NewsObj { DataStart = new DateTime (2023, 03 ,29),StreetsNameNews = "��. 8 �����",NewsTitle = "�������� �������� ��������", NewsDetails = "������� ��������� �������� ����� ������� ���������� � �������������� ������ �� ����� 8 �����. �������� ����� ��������� � ������� ������, �� ��� ������������ ������ ������ ������: �������, ��������, ����������. ", NewsImage = "https://cdn.culture.ru/images/aab9ae0c-16b9-5d1c-a339-d99ea2265141"},
                new NewsObj { DataStart = new DateTime(2023, 04, 06), StreetsNameNews = "��. ������� �������", NewsTitle = "�������� �������� ������������ ��������� � ��������������� ������������ �����", NewsDetails = "� 1 ������ � ��������������� ������������ ����� ������� �������� ������������ ���������, �� ������� ����� ������������ ������ ��������� ����������� ����������. �������� ��������� �� 31 ���.", NewsImage = "https://www.euromag.ru/storage/c/2021/07/01/1625153420_822314_31.jpg" },
                new NewsObj { DataStart = new DateTime(2023, 04, 07), StreetsNameNews = "��. ������", NewsTitle = "�������� ������ ����� ��. ������", NewsDetails = "������� � ������������ �������� ����� ����� ��. ������, ������� ������������ � ����� � ������������ ����� ����������� ������������� �������. ����� ����������� ��������������� �����������, ������� ������������ ��������� � ����������. ���� ���������.", NewsImage = "https://ic.pics.livejournal.com/ta_chesnokova/51466703/42500/42500_original.jpg" },
                new NewsObj { DataStart = new DateTime(2023, 02, 28), StreetsNameNews = "��. ��������", NewsTitle = "�������� �������� ���� ����� � ����� ����", NewsDetails = "� 1 ������ � ����� ���� ������� �������� ��������, ������� ������ ������ ���� � ����� �������. �� �������� ����� ������� ������� ����� �������������, ��� ������� �����, ���� �������, ����� ����� � ������ ������. �������� ��������� �� 31 ���.", NewsImage = "https://user72557.clients-cdnnow.ru/wp-content/uploads/2019/02/converted_file_6cd3989f-1500x844.jpg" },
                new NewsObj {DataStart = new DateTime(2023, 01, 15),StreetsNameNews = "��. �������",NewsTitle = "�������� �������� \"����������� ���������\"",NewsDetails = "� ������� ������������ ��������� �� ����� ������� � 15 ������ ��������� ����� �������� ������������ ���������. �� �������� ������������ ������������ ��������� ������� ���������� � �����������.",NewsImage = "https://sinara-center.com/upload/iblock/88e/photo_5303394560648527008_y.jpg"},
                new NewsObj {DataStart = new DateTime(2023, 02, 18),StreetsNameNews = "��. ������� ��������",NewsTitle = "������� �������������� �������� � ���������� ������",NewsDetails = "18 ������ � ���������� ������ �� ������� ��������� ��������� ������� �������������� �������� ��� ����������� ���������� ��������. � ��������� - ������������ ������������ ������ ��������� ������������.",NewsImage = "https://i.ytimg.com/vi/63PhLUsaoJA/maxresdefault.jpg"},
                new NewsObj {DataStart = new DateTime(2023, 03, 21),StreetsNameNews = "��. 8 �����",NewsTitle = "��������� ������ � �������������",NewsDetails = "� 21 ������ � ����� �� ����� 8 ����� � ������������� �������� ��������� ������. � ������ ��������� ������� ������-������ �� ������������, �������� ���������� � �������� ����� ��������� �����������.",NewsImage = "https://foxtime.ru/wp-content/uploads/2020/07/Zahod.jpg"},
                new NewsObj { DataStart = new DateTime (2023, 04, 10), StreetsNameNews = "��. ������� �������", NewsTitle = "�������� �������� �� ������� �������", NewsDetails = "10 ������ �� ������� ������� � ������ ��������� ������������� �������� ��������. ����� ������������ ����� ����������� � ���������� ������ ���.", NewsImage = "https://static.mk.ru/upload/entities/2020/07/22/15/articles/facebookPicture/c3/70/e7/8f/8d2f1e7df25f18d16271cde84ef8d61c.jpg"},
                new NewsObj { DataStart = new DateTime (2023, 04, 15), StreetsNameNews = "��. ��������� ��������", NewsTitle = "������� ���� ������ � �����-����������", NewsDetails = "15 ������ �� ��������� ��������� � �����-���������� ��������� ������� ���������� ������ ���� ������. ����� ��������� ����� ���������� ����.", NewsImage = "https://news412media.com/wp-content/uploads/2022/02/4-19.jpg"},
                new NewsObj { DataStart = new DateTime (2023, 01, 20), StreetsNameNews = "��. ������", NewsTitle = "�������� ����� �������� � ������������", NewsDetails = "20 ������ � ������������ �� ��������� ������ ��������� ����� ��������, ����������� ��������� �������������. ����� ������������ ������ ������� ���������� � �����������.", NewsImage = "https://www.oblgazeta.ru/media/filer_public/2023/03/28/bb333abe-5229-45ab-bd5d-3f535a8e4f6a-PAV_8419.jpg"},
                new NewsObj { DataStart = new DateTime (2023, 01, 25), StreetsNameNews = "��. ��������", NewsTitle = "�������� ���������� ������� ������� � ������", NewsDetails = "� 25 ������ �� ����� �������� � ������ ��������� ���������� ������� �������, �� ������� ����� ������������ ������ ������������ ����������� ����������, � ����� ����� ������ �������.", NewsImage = "https://likes.ru/uploads/place/image/5688/super_medium_ac57843a76fa41a708cf63672e75d2e5.jpg"},
                new NewsObj {DataStart = new DateTime(2023, 01, 03),StreetsNameNews = "��. ������",NewsTitle = "�������� ����� �������� � ������������� �����",NewsDetails = "� ������������� ����� ��. �.�. �������� 5 ������ ��������� ����� ��������, �� ������� ����� ������������ ������������ ����������� ����������. �������� ��������� �� 15 ���.",NewsImage = "https://cdn4.telegram-cdn.org/file/rpx6l6Mu4o5_ktM_JUxQBG17WHgdChm_63mi9CSD8jnZ9ORKbr1eZD-zvgyrtjMu3iQmf2Vkmez6i5CSJGRYk6iFmbMjwFU_TLtuNUNrQ54Iax9SkFegbiHHr6fiW0XuXNY4hrlldr84CNY79NgayfSACFuy2qjdXjxnjr2dkqPMcKui2Zpr8RtTFAXEFGEBCf_3qs1lrakaiyiKV8mSVlZ1Pzv3C3sKnH3sQpgKCg6ZrmHAa3WlOTIsfbl9_xypdUawGBbAJMt4xj7E7ncUDeq9o5w3rz9jEumzawK7DjOqdBhym8eOZI9DNniNbPzrMcamfCNZNQz9RTqjjr4jLA.jpg"},
                new NewsObj {DataStart = new DateTime(2023, 02, 10),StreetsNameNews = "��. �������",NewsTitle = "�������� ������ ���� � ������ �������������",NewsDetails = "� ������ ������������� ��������� ����� ����, � ������� ����� ����������� ������������� ����� ����������� �����. ���� �������� ��������� � 10:00 �� 22:00.",NewsImage = "https://cdn.iportal.ru/news/2021/99/preview/a35c15f741192a2a529dc1af57d1d3720556e446_1280_720_c.jpg"},
                new NewsObj {DataStart = new DateTime(2023, 04, 15),StreetsNameNews = "��. ��������",NewsTitle = "�������� ������ ���������� � ������ ������",NewsDetails = "� ������ ������ �������� ����� ��������� � ����������� 4D, � ������� ������� ����� ��������� ����������� � ������������ �� ������. ��������� �������� ��������� � 10:00 �� 23:00.",NewsImage = "https://img-fotki.yandex.ru/get/172684/29150237.59/0_bb15c_f2abe861_orig.jpg"},
                new NewsObj {DataStart = new DateTime(2023, 04, 20),StreetsNameNews = "��. ������� �������",NewsTitle = "��������� �������� ������ � �����-����������",NewsDetails = "� 20 �� 25 ������ � �����-���������� ������� ��������� �������� ������, �� ������� �������� ��������� ��������� �� ������ �����. �������� ����� ��������� � ��������� ���������� ����� ������.",NewsImage = "https://avatars.mds.yandex.net/i?id=2a000001871b0be0d0b7d41312e598255c5e-1356030-fast-images&n=13&exp=1"},
                new NewsObj { DataStart = new DateTime(2023, 01, 06), StreetsNameNews = "��. ������� ��������", NewsTitle = "�������� ����� �������������� �������� � ��������", NewsDetails = "� 1 ������ � �������� ����������� ����� �������� ������������ ���������, �� ������� ����� ������������ ������ ���������� �� ����� ����. �������� ��������� �� 30 ����.", NewsImage = "https://sportishka.com/uploads/posts/2022-04/1650701958_9-sportishka-com-p-nevskii-prospekt-sankt-peterburg-krasivo-f-9.jpg"},
                new NewsObj { DataStart = new DateTime(2023, 03, 17), StreetsNameNews = "��. �����", NewsTitle = "����������� �������� �� ������ � ����� � ������������", NewsDetails = "� 1 ������ �� ������ ����� ���������� �������� ���������� � ����� � ����������� �������� ���������� �����������. ����������� ��������� �� 3 ������.", NewsImage = "https://altairk.ru/upload/news/74/b8/remontnie_raboti.jpg"},
                new NewsObj { DataStart = new DateTime(2023, 04, 20), StreetsNameNews = "��. �����", NewsTitle = "����� ������� �������� ����� �������� �� ����� �����", NewsDetails = "�� ����� ����� �������� ����� ������� �������� �����, � ������� ������������ �������� ��������� ������� �������. � ����� �������� ���� ����������� ��������� �� �������� �� 50%. ", NewsImage = "https://krot.info/uploads/posts/2021-12/1638513960_45-krot-info-p-ulitsa-arbat-v-moskve-dostoprimechatelnost-46.jpg"},
                new NewsObj { DataStart = new DateTime(2023, 01, 29), StreetsNameNews = "��. ������� ��������", NewsTitle = "�������� ������ �������� Louis Vuitton � �����-����������", NewsDetails = "������� �������� ����� ������� Louis Vuitton �� ������� ���������. � �������� ������������ ����� ��������� ��������� �������� ������. ���� ���� �� �������� � �������!", NewsImage = "https://www.spb-guide.ru/img/474/nachalo-prospekta-77489big.jpg"},
                new NewsObj { DataStart = new DateTime(2023, 01, 30), StreetsNameNews = "��. ������� �������", NewsTitle = "�������� �������� �������� '������� XX ����'", NewsDetails = "� ��������������� ����� ��������������� �������� �� ������� ������� ������� ��������� �������� �������� '������� XX ����'. �� �������� ������������ ������ ����� ��������� ��������, ��� ����� �������, ��������� ����, ���� ����� � ������. �������� ��������� �� 30 ������.", NewsImage = "https://fotovideoforum.ru/resources/image/145053" },
                new NewsObj { DataStart = new DateTime(2023, 04, 01), StreetsNameNews = "��. ������� �������", NewsTitle = "�������� ����� ������� �� ������� �������", NewsDetails = "������� �� ������� ������� ��������� ����� ������� 'Coffeeland'. � ���� ������������ ����� ������������� ������� � �������. ��������� �� ������� ���� � �������� ����������!", NewsImage = "https://nationmagazine.ru/upload/medialibrary/14d/hmyzjwr3536sf1ge8614e2klz5rnvvrj.jpg" }

        };

        var StreetsNews = new List<NewsObj>
        {

        };
        news.Sort((x, y) => DateTime.Compare(y.DataStart, x.DataStart));
        //DateOnly test;
        for (int i = 0; i < news.Count; i++)
        {
            if (news[i].StreetsNameNews == MainLabelStreetsName)
            {
                //for (int j = i + 1; j < news.Count; j++)
                //{
                //    if (news[i].DataStart > news[j].DataStart)
                //    {
                //        test = news[j].DataStart;
                //        news[i].DataStart = news[j].DataStart;
                //        news[j].DataStart = test;
                //    }
                //}

                StreetsNews.Add(news[i]);
                
            }
            
        }


        //var groupsNews = StreetsNews.GroupBy(p => p.DataStart).Select(g => new Grouping<string, NewsObj>(g.Key, g));
        //NewsObj = new ObservableCollection<Grouping<string, NewsObj>>(groupsNews);

        collectionView.ItemsSource = StreetsNews;
        BindingContext = this;

        
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        await Navigation.PushAsync(new NewsDetail(NewsTitle.Text, NewsDetails.Text, NewsImage.Text, DataStart.Text));
    }
}



