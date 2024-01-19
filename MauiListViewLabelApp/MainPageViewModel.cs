using static System.Net.WebRequestMethods;

namespace MauiListViewLabelApp
  {

  public class MainPageViewModel
    {
    public IList<MyModel> MyList { get; set; }

    public MainPageViewModel()
      {
      MyList = new List<MyModel>();

      for (int i = 0; i < 70; i++)
        {
        MyList.Add(new MyModel
          {
          Name = i + ". " + "Just text"
          // content from maui documentation causes exception as well
          // https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/label?view=net-maui-8.0#display-html
          // + "This is <strong style=\"color:red\">HTML</strong> text"
          });
        }
      }

    }
  }
