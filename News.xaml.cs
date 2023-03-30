

using System.Collections.ObjectModel;

namespace YourCity;


public partial class News : ContentPage
{
    public ObservableCollection<Grouping<string, NewsObj>> NewsObj { get; set; }
    public News(string MainLabelStreetsName, string MainLabelCity_name)
	{

		InitializeComponent();


       
        LabelCityName.Text = $"Город: {MainLabelCity_name}";
        LabelStreetsName.Text = $"Улица: {MainLabelStreetsName}";

        var news = new List<NewsObj>
        {
               new NewsObj { DataStart = new DateTime (2023, 03 ,25),StreetsNameNews = "ул. Арбат" ,NewsTitle = "Выставка архитектуры в Третьяковской галерее", NewsDetails = "В Третьяковской галерее с 1 апреля открыта выставка архитектуры, на которой представлены работы лауреатов международных премий. Выставка продлится до 31 мая.", NewsImage = "https://switki.ru/assets/i/ai/4/7/7/i/3285859.jpg"},
                new NewsObj { DataStart = new DateTime (2023, 03 ,16),StreetsNameNews = "ул. Невский проспект" ,NewsTitle = "Новый магазин открыт на Невском проспекте", NewsDetails = "Сегодня на Невском проспекте открылся новый магазин, который предлагает широкий выбор товаров по доступным ценам.", NewsImage = "http://rasfokus.ru/images/photos/medium/9e406768105dd8a8779b3375c28a3ff2.jpg"},
                new NewsObj { DataStart = new DateTime (2023, 02 ,27),StreetsNameNews = "ул. Красноармейская" ,NewsTitle = "Открытие музея на Красноармейской", NewsDetails = "Сегодня на Красноармйской открылся новый музей, где можно узнать о истории Москвы и России. Вход бесплатный.", NewsImage = "https://avatars.mds.yandex.net/get-altay/859900/2a0000015f8c36faf0e2ec034ae593ccdbde/XXL"},
                new NewsObj { DataStart = new DateTime (2023, 01 ,08),StreetsNameNews = "пр. Ленина" ,NewsTitle = "Строительство новой высотки на пр. Ленина начнется в апреле", NewsDetails = "В апреле начнется строительство новой высотки на пр. Ленина. Здание будет иметь 60 этажей и станет одним из самых высоких в городе.", NewsImage = "https://sun9-31.userapi.com/impg/oHbj3dUxcskyv9EV5kXT5ku8kHHCSC5VHdQvFg/NpDdut40jxo.jpg?size=900x596&quality=95&sign=873d851c5f79999b2e60769aec630293&c_uniq_tag=DYVF1WVeZzpnAWwp1oIzwTn7HSgbofaSYC6mqr46wlg&type=album"},
                new NewsObj { DataStart = new DateTime (2023, 03 ,29),StreetsNameNews = "ул. Вайнера" ,NewsTitle = "Открытие нового кафе на ул. Вайнера", NewsDetails = "Сегодня на ул. Вайнера открылось новое кафе, где можно попробовать вкусную еду и выпить свежесваренный кофе. Всех ждут с 10:00 до 22:00.", NewsImage = "https://kartarf.ru/images/heritage/1080/5/59189.jpg" },
                new NewsObj { DataStart = new DateTime(2023, 04, 16), StreetsNameNews = "ул. Невский проспект", NewsTitle = "Открытие нового кафе на Невском проспекте", NewsDetails = "На Невском проспекте открылось новое кафе, предлагающее свежие и вкусные блюда по приятным ценам. Кафе расположено в самом центре города и является отличным местом для проведения встреч с друзьями и бизнес-партнерами.", NewsImage = "https://gcdn.tomesto.ru/img/place/000/022/580/restoran-mama-na-dache-na-nevskom-prospekte_c9f21_full-251119.jpg"},
                new NewsObj { DataStart = new DateTime(2023, 02, 16), StreetsNameNews = "ул. Красная площадь", NewsTitle = "Международный фестиваль музыки на Красной площади", NewsDetails = "С 15 апреля на Красной площади пройдет международный фестиваль музыки, на котором выступят известные исполнители из разных стран мира. Фестиваль продлится до конца месяца и обещает быть ярким и запоминающимся событием для всех любителей музыки.", NewsImage = "https://catherineasquithgallery.com/uploads/posts/2021-02/1612905309_134-p-krasnaya-ploshchad-fon-173.jpg"},
                new NewsObj { DataStart = new DateTime(2023, 01, 27), StreetsNameNews = "ул. Вайнера", NewsTitle = "Открытие нового магазина электроники на улице Вайнера", NewsDetails = "На улице Вайнера открылся новый магазин электроники, где можно приобрести самые современные и качественные гаджеты. В честь открытия магазин предлагает скидки на всю продукцию до конца месяца.", NewsImage = "http://photos.wikimapia.org/p/00/02/31/90/25_full.jpeg"},
                new NewsObj { DataStart = new DateTime (2023, 03 ,07),StreetsNameNews = "ул. Лиговский проспект",NewsTitle = "Открытие нового кинотеатра", NewsDetails = "Сегодня на улице Лиговский проспект открылся новый кинотеатр «Киномакс Лиговский». В зале оборудованном по последнему слову техники, будут показывать самые новые и ожидаемые фильмы. ", NewsImage = "https://cre.ru/content/upload/players/object/normal/1517075969339.jpg"},
                new NewsObj { DataStart = new DateTime (2023, 03 ,29),StreetsNameNews = "ул. 8 Марта",NewsTitle = "Открытие выставки живописи", NewsDetails = "Сегодня открылась выставка работ молодых художников в художественном центре на улице 8 Марта. Выставка будет проходить в течение месяца, на ней представлены работы разных жанров: пейзажи, портреты, натюрморты. ", NewsImage = "https://cdn.culture.ru/images/aab9ae0c-16b9-5d1c-a339-d99ea2265141"},
                new NewsObj { DataStart = new DateTime(2023, 04, 06), StreetsNameNews = "ул. Красная площадь", NewsTitle = "Открытие выставки современного искусства в Государственном Историческом музее", NewsDetails = "С 1 апреля в Государственном Историческом музее открыта выставка современного искусства, на которой будут представлены работы известных современных художников. Выставка продлится до 31 мая.", NewsImage = "https://www.euromag.ru/storage/c/2021/07/01/1625153420_822314_31.jpg" },
                new NewsObj { DataStart = new DateTime(2023, 04, 07), StreetsNameNews = "пр. Ленина", NewsTitle = "Открытие нового музея им. Ленина", NewsDetails = "Сегодня в Новосибирске открылся новый музей им. Ленина, который рассказывает о жизни и деятельности этого выдающегося политического деятеля. Музей представлен многочисленными экспонатами, включая оригинальные документы и фотографии. Вход свободный.", NewsImage = "https://ic.pics.livejournal.com/ta_chesnokova/51466703/42500/42500_original.jpg" },
                new NewsObj { DataStart = new DateTime(2023, 02, 28), StreetsNameNews = "ул. Тверская", NewsTitle = "Выставка костюмов кино звезд в Музее кино", NewsDetails = "С 1 апреля в Музее кино открыта выставка костюмов, которые носили звезды кино в своих фильмах. На выставке можно увидеть костюмы таких знаменитостей, как Мэрилин Монро, Одри Хепберн, Кларк Гейбл и многие другие. Выставка продлится до 31 мая.", NewsImage = "https://user72557.clients-cdnnow.ru/wp-content/uploads/2019/02/converted_file_6cd3989f-1500x844.jpg" },
                new NewsObj {DataStart = new DateTime(2023, 01, 15),StreetsNameNews = "ул. Вайнера",NewsTitle = "Открытие выставки \"Современное искусство\"",NewsDetails = "В галерее современного искусства на улице Вайнера с 15 апреля открылась новая выставка современного искусства. На выставке представлены произведения известных мировых художников и скульпторов.",NewsImage = "https://sinara-center.com/upload/iblock/88e/photo_5303394560648527008_y.jpg"},
                new NewsObj {DataStart = new DateTime(2023, 02, 18),StreetsNameNews = "ул. Невский проспект",NewsTitle = "Концерт Симфонического оркестра в Мариинском театре",NewsDetails = "18 апреля в Мариинском театре на Невском проспекте состоится концерт Симфонического оркестра под управлением известного дирижера. В программе - произведения классической музыки известных композиторов.",NewsImage = "https://i.ytimg.com/vi/63PhLUsaoJA/maxresdefault.jpg"},
                new NewsObj {DataStart = new DateTime(2023, 03, 21),StreetsNameNews = "ул. 8 Марта",NewsTitle = "Фестиваль цветов в Екатеринбурге",NewsDetails = "С 21 апреля в парке на улице 8 Марта в Екатеринбурге стартует фестиваль цветов. В рамках фестиваля пройдут мастер-классы по цветоводству, выставки флористики и конкурсы среди любителей садоводства.",NewsImage = "https://foxtime.ru/wp-content/uploads/2020/07/Zahod.jpg"},
                new NewsObj { DataStart = new DateTime (2023, 04, 10), StreetsNameNews = "ул. Красная площадь", NewsTitle = "Открытие фонтанов на Красной площади", NewsDetails = "10 апреля на Красной площади в Москве состоится торжественное открытие фонтанов. Будут представлены новые конструкции и интересные водные шоу.", NewsImage = "https://static.mk.ru/upload/entities/2020/07/22/15/articles/facebookPicture/c3/70/e7/8f/8d2f1e7df25f18d16271cde84ef8d61c.jpg"},
                new NewsObj { DataStart = new DateTime (2023, 04, 15), StreetsNameNews = "ул. Лиговский проспект", NewsTitle = "Концерт Лары Фабиан в Санкт-Петербурге", NewsDetails = "15 апреля на Лиговском проспекте в Санкт-Петербурге состоится концерт знаменитой певицы Лары Фабиан. Будут исполнены самые популярные хиты.", NewsImage = "https://news412media.com/wp-content/uploads/2022/02/4-19.jpg"},
                new NewsObj { DataStart = new DateTime (2023, 01, 20), StreetsNameNews = "пр. Ленина", NewsTitle = "Открытие новой выставки в Новосибирске", NewsDetails = "20 апреля в Новосибирске на проспекте Ленина откроется новая выставка, посвященная искусству современности. Будут представлены работы молодых художников и скульпторов.", NewsImage = "https://www.oblgazeta.ru/media/filer_public/2023/03/28/bb333abe-5229-45ab-bd5d-3f535a8e4f6a-PAV_8419.jpg"},
                new NewsObj { DataStart = new DateTime (2023, 01, 25), StreetsNameNews = "ул. Тверская", NewsTitle = "Открытие крупнейшей книжной ярмарки в Москве", NewsDetails = "С 25 апреля на улице Тверской в Москве откроется крупнейшая книжная ярмарка, на которой будут представлены лучшие произведения современной литературы, а также книги редких авторов.", NewsImage = "https://likes.ru/uploads/place/image/5688/super_medium_ac57843a76fa41a708cf63672e75d2e5.jpg"},
                new NewsObj {DataStart = new DateTime(2023, 01, 03),StreetsNameNews = "пр. Ленина",NewsTitle = "Открытие новой выставки в Новосибирском музее",NewsDetails = "В Новосибирском музее им. В.Н. Сукачева 5 апреля открылась новая выставка, на которой будут представлены произведения современных художников. Выставка продлится до 15 мая.",NewsImage = "https://cdn4.telegram-cdn.org/file/rpx6l6Mu4o5_ktM_JUxQBG17WHgdChm_63mi9CSD8jnZ9ORKbr1eZD-zvgyrtjMu3iQmf2Vkmez6i5CSJGRYk6iFmbMjwFU_TLtuNUNrQ54Iax9SkFegbiHHr6fiW0XuXNY4hrlldr84CNY79NgayfSACFuy2qjdXjxnjr2dkqPMcKui2Zpr8RtTFAXEFGEBCf_3qs1lrakaiyiKV8mSVlZ1Pzv3C3sKnH3sQpgKCg6ZrmHAa3WlOTIsfbl9_xypdUawGBbAJMt4xj7E7ncUDeq9o5w3rz9jEumzawK7DjOqdBhym8eOZI9DNniNbPzrMcamfCNZNQz9RTqjjr4jLA.jpg"},
                new NewsObj {DataStart = new DateTime(2023, 02, 10),StreetsNameNews = "ул. Вайнера",NewsTitle = "Открытие нового кафе в центре Екатеринбурга",NewsDetails = "В центре Екатеринбурга открылось новое кафе, в котором можно попробовать разнообразные блюда европейской кухни. Кафе работает ежедневно с 10:00 до 22:00.",NewsImage = "https://cdn.iportal.ru/news/2021/99/preview/a35c15f741192a2a529dc1af57d1d3720556e446_1280_720_c.jpg"},
                new NewsObj {DataStart = new DateTime(2023, 04, 15),StreetsNameNews = "ул. Тверская",NewsTitle = "Открытие нового кинотеатра в центре Москвы",NewsDetails = "В центре Москвы открылся новый кинотеатр с технологией 4D, в котором зрители могут полностью погрузиться в происходящее на экране. Кинотеатр работает ежедневно с 10:00 до 23:00.",NewsImage = "https://img-fotki.yandex.ru/get/172684/29150237.59/0_bb15c_f2abe861_orig.jpg"},
                new NewsObj {DataStart = new DateTime(2023, 04, 20),StreetsNameNews = "ул. Большая Садовая",NewsTitle = "Фестиваль джазовой музыки в Санкт-Петербурге",NewsDetails = "С 20 по 25 апреля в Санкт-Петербурге пройдет фестиваль джазовой музыки, на котором выступят известные музыканты из разных стран. Концерты будут проходить в различных концертных залах города.",NewsImage = "https://avatars.mds.yandex.net/i?id=2a000001871b0be0d0b7d41312e598255c5e-1356030-fast-images&n=13&exp=1"},
                new NewsObj { DataStart = new DateTime(2023, 01, 06), StreetsNameNews = "ул. Невский проспект", NewsTitle = "Открытие новой художественной выставки в Эрмитаже", NewsDetails = "С 1 апреля в Эрмитаже открывается новая выставка современного искусства, на которой будут представлены работы художников со всего мира. Выставка продлится до 30 июня.", NewsImage = "https://sportishka.com/uploads/posts/2022-04/1650701958_9-sportishka-com-p-nevskii-prospekt-sankt-peterburg-krasivo-f-9.jpg"},
                new NewsObj { DataStart = new DateTime(2023, 03, 17), StreetsNameNews = "ул. Арбат", NewsTitle = "Ограничения движения на Арбате в связи с мероприятием", NewsDetails = "С 1 апреля на Арбате будет ограничено движение транспорта в связи с проведением крупного городского мероприятия. Ограничения продлятся до 3 апреля.", NewsImage = "https://altairk.ru/upload/news/74/b8/remontnie_raboti.jpg"},
                new NewsObj { DataStart = new DateTime(2023, 04, 20), StreetsNameNews = "ул. Арбат", NewsTitle = "Новый крупный торговый центр открылся на улице Арбат", NewsDetails = "На улице Арбат открылся новый крупный торговый центр, в котором представлены магазины известных мировых брендов. В честь открытия весь ассортимент продается со скидками до 50%. ", NewsImage = "https://krot.info/uploads/posts/2021-12/1638513960_45-krot-info-p-ulitsa-arbat-v-moskve-dostoprimechatelnost-46.jpg"},
                new NewsObj { DataStart = new DateTime(2023, 01, 29), StreetsNameNews = "ул. Невский проспект", NewsTitle = "Открытие нового магазина Louis Vuitton в Санкт-Петербурге", NewsDetails = "Сегодня открылся новый магазин Louis Vuitton на Невском проспекте. В магазине представлены самые последние коллекции мирового бренда. Ждем всех на просмотр и покупки!", NewsImage = "https://www.spb-guide.ru/img/474/nachalo-prospekta-77489big.jpg"},
                new NewsObj { DataStart = new DateTime(2023, 01, 30), StreetsNameNews = "ул. Красная площадь", NewsTitle = "Открытие выставки живописи 'Мастера XX века'", NewsDetails = "В Государственном музее изобразительных искусств на Красной площади сегодня открылась выставка живописи 'Мастера XX века'. На выставке представлены работы таких известных мастеров, как Пабло Пикассо, Сальвадор Дали, Марк Шагал и других. Выставка продлится до 30 апреля.", NewsImage = "https://fotovideoforum.ru/resources/image/145053" },
                new NewsObj { DataStart = new DateTime(2023, 04, 01), StreetsNameNews = "ул. Большая Садовая", NewsTitle = "Открытие новой кофейни на Большой Садовой", NewsDetails = "Сегодня на Большой Садовой открылась новая кофейня 'Coffeeland'. В меню представлены самые разнообразные напитки и закуски. Приходите за вкусным кофе и приятной атмосферой!", NewsImage = "https://nationmagazine.ru/upload/medialibrary/14d/hmyzjwr3536sf1ge8614e2klz5rnvvrj.jpg" }

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



