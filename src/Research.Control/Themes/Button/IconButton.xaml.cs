using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Research.Control
{
    public class IconButton : Button
    {
        static IconButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(IconButton), new FrameworkPropertyMetadata(typeof(IconButton)));
        }

        public Brush InnerColor
        {
            get { return (Brush)GetValue(InnerColorProperty); }
            set { SetValue(InnerColorProperty, value); }
        }
        public static readonly DependencyProperty InnerColorProperty =
            DependencyProperty.Register("InnerColor", typeof(Brush), typeof(IconButton),
                new PropertyMetadata(Brushes.Black));

        public Brush HoverColor
        {
            get { return (Brush)GetValue(HoverColorProperty); }
            set { SetValue(HoverColorProperty, value); }
        }
        public static readonly DependencyProperty HoverColorProperty =
            DependencyProperty.Register("HoverColor", typeof(Brush), typeof(IconButton),
                new PropertyMetadata(Brushes.Black));

        public Brush ClickColor
        {
            get { return (Brush)GetValue(ClickColorProperty); }
            set { SetValue(ClickColorProperty, value); }
        }
        public static readonly DependencyProperty ClickColorProperty =
            DependencyProperty.Register("ClickColor", typeof(Brush), typeof(IconButton),
                new PropertyMetadata(Brushes.Black));

        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(IconButton),
                new PropertyMetadata(new CornerRadius(2)));

        public ImageSource IconSource
        {
            get { return (ImageSource)GetValue(IconSourceProperty); }
            set { SetValue(IconSourceProperty, value); }
        }
        public static readonly DependencyProperty IconSourceProperty =
            DependencyProperty.Register("IconSource", typeof(ImageSource), typeof(IconButton),
                new PropertyMetadata(null));

        public double IconWidth
        {
            get { return (double)GetValue(IconWidthProperty); }
            set { SetValue(IconWidthProperty, value); }
        }
        public static readonly DependencyProperty IconWidthProperty =
            DependencyProperty.Register("IconWidth", typeof(double), typeof(IconButton),
                new PropertyMetadata(20.0));

        public double IconHeight
        {
            get { return (double)GetValue(IconHeightProperty); }
            set { SetValue(IconHeightProperty, value); }
        }
        public static readonly DependencyProperty IconHeightProperty =
            DependencyProperty.Register("IconHeight", typeof(double), typeof(IconButton),
                new PropertyMetadata(20.0));
    }
}
