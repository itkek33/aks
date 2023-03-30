//using System.Collections.ObjectModel;
//using System.ComponentModel;
//using System.Runtime.CompilerServices;


//namespace YourCity;
//public class NewsViewModel : INotifyPropertyChanged
//{




//    NewsObj news = new NewsObj { NewsTitle = "Спасли котёнка", NewsDetails = "С дерева спали котёнка. Спасителем оказался известный в своих кругах человек по прозвищу чёрный мечник", NewsImage = "https://yt3.googleusercontent.com/-7KyibSKtYr6KiFcVoqI6EoqgivLyN6fxTzancu7pvWg87aCFraHpRb_BNOjUgBGUXtEmmMG6g=s900-c-k-c0x00ffffff-no-rj" };

//    public event PropertyChangedEventHandler? PropertyChanged;

//    public string NewsTitle
//    {
//        get => news.NewsTitle;
//        set
//        {
//            if (news.NewsTitle != value)
//            {
//                news.NewsTitle = value;
//                OnPropertyChanged();
//            }
//        }
//    }
//    public string NewsDetails
//    {
//        get => news.NewsDetails;
//        set
//        {
//            if (news.NewsDetails != value)
//            {
//                news.NewsDetails = value;
//                OnPropertyChanged();
//            }
//        }
//    }
//    public string NewsImage
//    {
//        get => news.NewsImage;
//        set
//        {
//            if (news.NewsImage != value)
//            {
//                news.NewsImage = value;
//                OnPropertyChanged();
//            }
//        }
//    }
//    public void OnPropertyChanged([CallerMemberName] string prop = "")
//    {
//        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
//    }
//}
