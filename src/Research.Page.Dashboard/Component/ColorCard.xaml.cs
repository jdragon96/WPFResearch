using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Research.Page.Dashboard
{
    public partial class ColorCard : UserControl
    {
        public ColorCard() : base()
        {
            InitializeComponent();
        }

        public string Value
        {
            get => (string)GetValue(ValueProperty);
            set => SetValue(ValueProperty, value);
        }
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(string), typeof(ColorCard), new PropertyMetadata(""));

        public ImageSource IconSource
        {
            get => (ImageSource)GetValue(IconSourceProperty);
            set => SetValue(IconSourceProperty, value);
        }
        public static readonly DependencyProperty IconSourceProperty =
            DependencyProperty.Register("IconSource", typeof(ImageSource), typeof(ColorCard), new PropertyMetadata(null));

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(ColorCard), new PropertyMetadata(null));

        public Color StartColor
        {
            get { return (Color)GetValue(StartColorProperty); }
            set { SetValue(StartColorProperty, value); }
        }
        public static readonly DependencyProperty StartColorProperty =
            DependencyProperty.Register("StartColor", typeof(Color), typeof(ColorCard),
                new PropertyMetadata(Colors.Black));

        public Color EndColor
        {
            get { return (Color)GetValue(EndColorProperty); }
            set { SetValue(EndColorProperty, value); }
        }
        public static readonly DependencyProperty EndColorProperty =
            DependencyProperty.Register("EndColor", typeof(Color), typeof(ColorCard),
                new PropertyMetadata(Colors.Black));
    }
}
