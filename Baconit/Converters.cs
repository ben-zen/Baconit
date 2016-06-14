using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace Baconit
{
  public class BoolToVisibilityConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, string language)
    {
      Visibility isVisible = Visibility.Collapsed;
      if (value is bool && ((bool)value)) // If value is a bool and it's true, isVisible should be Visible.
      {
        isVisible = Visibility.Visible;
      }
      return isVisible;
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
      throw new NotImplementedException();
    }
  }
}
