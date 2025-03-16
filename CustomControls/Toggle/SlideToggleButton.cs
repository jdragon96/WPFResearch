using System.Windows.Controls;
using System.Windows;
using System.Windows.Media;

namespace CustomControls
{
    public class SlideToggleButton : CheckBox
    {
        static SlideToggleButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SlideToggleButton),
                new FrameworkPropertyMetadata(typeof(SlideToggleButton)));
        }
        public SlideToggleButton() : base()
        {

        }

        public Brush TrackOnBorderColor
        {
            get { return (Brush)GetValue(TrackOnBorderColorProperty); }
            set { SetValue(TrackOnBorderColorProperty, value); }
        }
        public static readonly DependencyProperty TrackOnBorderColorProperty =
            DependencyProperty.Register("TrackOnBorderColor", typeof(Brush), typeof(SlideToggleButton),
                new PropertyMetadata(Brushes.Black));  // 기본값은 Brushes.Black

        public Brush TrackOffBorderColor
        {
            get { return (Brush)GetValue(TrackOffBorderColorProperty); }
            set { SetValue(TrackOffBorderColorProperty, value); }
        }
        public static readonly DependencyProperty TrackOffBorderColorProperty =
            DependencyProperty.Register("TrackOffBorderColor", typeof(Brush), typeof(SlideToggleButton),
                new PropertyMetadata(Brushes.Black));  // 기본값은 Brushes.Black

        public Brush TrackOnColor
        {
            get { return (Brush)GetValue(TrackOnColorProperty); }
            set { SetValue(TrackOnColorProperty, value); }
        }
        public static readonly DependencyProperty TrackOnColorProperty =
            DependencyProperty.Register("TrackOnColor", typeof(Brush), typeof(SlideToggleButton),
                new PropertyMetadata(Brushes.Black));  // 기본값은 Brushes.Black

        public Brush TrackOffColor
        {
            get { return (Brush)GetValue(TrackOffColorProperty); }
            set { SetValue(TrackOffColorProperty, value); }
        }
        public static readonly DependencyProperty TrackOffColorProperty =
            DependencyProperty.Register("TrackOffColor", typeof(Brush), typeof(SlideToggleButton),
                new PropertyMetadata(Brushes.Black));  // 기본값은 Brushes.Black

        public Thickness TrackMargin
        {
            get { return (Thickness)GetValue(TrackMarginProperty); }
            set { SetValue(TrackMarginProperty, value); }
        }
        public static readonly DependencyProperty TrackMarginProperty =
            DependencyProperty.Register("TrackMargin", typeof(Thickness), typeof(SlideToggleButton),
                new PropertyMetadata(new Thickness(0)));  // 기본값은 Brushes.Black

        public Thickness ThumbMargin
        {
            get { return (Thickness)GetValue(ThumbMarginProperty); }
            set { SetValue(ThumbMarginProperty, value); }
        }
        public static readonly DependencyProperty ThumbMarginProperty =
            DependencyProperty.Register("ThumbMargin", typeof(Thickness), typeof(SlideToggleButton),
                new PropertyMetadata(new Thickness(0)));  // 기본값은 Brushes.Black

        public CornerRadius TrackBorderRadius
        {
            get { return (CornerRadius)GetValue(TrackBorderRadiusProperty); }
            set { SetValue(TrackBorderRadiusProperty, value); }
        }
        public static readonly DependencyProperty TrackBorderRadiusProperty =
            DependencyProperty.Register("TrackBorderRadius", typeof(CornerRadius), typeof(SlideToggleButton),
                new PropertyMetadata(new CornerRadius(0)));  // 기본값은 Brushes.Black

        public CornerRadius TrackRadius
        {
            get { return (CornerRadius)GetValue(TrackRadiusProperty); }
            set { SetValue(TrackRadiusProperty, value); }
        }
        public static readonly DependencyProperty TrackRadiusProperty =
            DependencyProperty.Register("TrackRadius", typeof(CornerRadius), typeof(SlideToggleButton),
                new PropertyMetadata(new CornerRadius(0)));  // 기본값은 Brushes.Black

        public CornerRadius ThunmbRadius
        {
            get { return (CornerRadius)GetValue(ThunmbRadiusProperty); }
            set { SetValue(ThunmbRadiusProperty, value); }
        }
        public static readonly DependencyProperty ThunmbRadiusProperty =
            DependencyProperty.Register("ThunmbRadius", typeof(CornerRadius), typeof(SlideToggleButton),
                new PropertyMetadata(new CornerRadius(0)));  // 기본값은 Brushes.Black

        public Brush ThumbOnColor
        {
            get { return (Brush)GetValue(ThumbOnColorProperty); }
            set { SetValue(ThumbOnColorProperty, value); }
        }
        public static readonly DependencyProperty ThumbOnColorProperty =
            DependencyProperty.Register("ThumbOnColor", typeof(Brush), typeof(SlideToggleButton),
                new PropertyMetadata(Brushes.Blue));

        public Brush ThumbOffColor
        {
            get { return (Brush)GetValue(ThumbOffColorProperty); }
            set { SetValue(ThumbOffColorProperty, value); }
        }
        public static readonly DependencyProperty ThumbOffColorProperty =
            DependencyProperty.Register("ThumbOffColor", typeof(Brush), typeof(SlideToggleButton),
                new PropertyMetadata(Brushes.Blue));

        public int ThumbPadding
        {
            get { return (int)GetValue(ThumbPaddingProperty); }
            set { SetValue(ThumbPaddingProperty, value); }
        }
        public static readonly DependencyProperty ThumbPaddingProperty =
            DependencyProperty.Register("ThumbPadding", typeof(int), typeof(SlideToggleButton),
                new PropertyMetadata(25));

        public Brush FontOnColor
        {
            get { return (Brush)GetValue(FontOnColorProperty); }
            set { SetValue(FontOnColorProperty, value); }
        }
        public static readonly DependencyProperty FontOnColorProperty =
            DependencyProperty.Register("FontOnColor", typeof(Brush), typeof(SlideToggleButton),
                new PropertyMetadata(Brushes.Black));

        public Brush FontOffColor
        {
            get { return (Brush)GetValue(FontOffColorProperty); }
            set { SetValue(FontOffColorProperty, value); }
        }
        public static readonly DependencyProperty FontOffColorProperty =
            DependencyProperty.Register("FontOffColor", typeof(Brush), typeof(SlideToggleButton),
                new PropertyMetadata(Brushes.Black));

        public IResultCommand<bool> ValidationCommand
        {
            get { return (IResultCommand<bool>)GetValue(ValidationCommandProperty); }
            set { SetValue(ValidationCommandProperty, value); }
        }
        public static readonly DependencyProperty ValidationCommandProperty =
            DependencyProperty.Register("ValidationCommand", typeof(IResultCommand<bool>), typeof(SlideToggleButton), new PropertyMetadata(null));

        public IResultCommand<object> StateCommand
        {
            get { return (IResultCommand<object>)GetValue(StateCommandProperty); }
            set { SetValue(StateCommandProperty, value); }
        }
        public static readonly DependencyProperty StateCommandProperty =
            DependencyProperty.Register("StateCommand", typeof(IResultCommand<object>), typeof(SlideToggleButton), new PropertyMetadata(null, OnStateCommandChanged));

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            var TrackBorder = GetTemplateChild("TrackBorder") as Border;
            var Track = GetTemplateChild("Track") as Border;
            var Thumb = GetTemplateChild("Thumb") as Border;
            var Font = GetTemplateChild("Font") as TextBlock;

            this.PreviewMouseLeftButtonDown += (s, e) =>
            {
                FlagChangedExecute(IsChecked.GetValueOrDefault());
            };
            if (TrackBorder != null)
            {
                TrackBorder.SetValue(Border.WidthProperty, Width);
                TrackBorder.SetValue(Border.HeightProperty, Height);
                TrackBorder.SetValue(Border.BackgroundProperty, TrackOffBorderColor);
                var Radius = Height * 0.5;
                TrackBorderRadius = new CornerRadius(Radius < 0 ? 0 : Radius);
                TrackBorder.SetValue(Border.CornerRadiusProperty, TrackBorderRadius);
            }
            if (Track != null)
            {
                Track.SetValue(Border.BackgroundProperty, TrackOffColor);
                Track.SetValue(Border.MarginProperty, TrackMargin);
                var Radius = (Height - TrackMargin.Right * 2) * 0.5;
                TrackRadius = new CornerRadius(Radius < 0 ? 0 : Radius);
                Track.SetValue(Border.CornerRadiusProperty, TrackRadius);
            }
            if (Thumb != null)
            {
                Thumb.SetValue(Border.BackgroundProperty, ThumbOffColor);
                var Radius = (Height - TrackMargin.Right * 2 - ThumbMargin.Right * 2) * 0.5;
                ThunmbRadius = new CornerRadius(Radius < 0 ? 0 : Radius);
                Thumb.SetValue(Border.CornerRadiusProperty, ThunmbRadius);
                Thumb.SetValue(Border.MarginProperty, ThumbMargin);
                var ThumbWidth = Width - TrackMargin.Right * 2 - ThumbMargin.Right * 2;
                Thumb.SetValue(Border.WidthProperty, ThumbWidth - ThumbPadding);
            }
            if (Font != null)
            {
                var ThumbWidth = Height - TrackMargin.Right * 2 - ThumbMargin.Right * 2 - 8;
                Font.SetValue(TextBlock.FontSizeProperty, ThumbWidth);
                Font.SetValue(TextBlock.FontWeightProperty, FontWeight);
            }
            if (StateCommand != null)
            {
                SetDefaultState(StateCommand.Execute(this));
            }
        }

        public void FlagChangedExecute(bool currentFlag)
        {
            if (ValidationCommand == null)
                return;
            var NextState = !currentFlag;
            if (!ValidationCommand.Execute(NextState))
                return;
            SetDefaultState(NextState);
        }

        public void SetDefaultState(bool NewState)
        {
            var TrackBorder = GetTemplateChild("TrackBorder") as Border;
            var Track = GetTemplateChild("Track") as Border;
            var Thumb = GetTemplateChild("Thumb") as Border;
            var Font = GetTemplateChild("Font") as TextBlock;
            if (TrackBorder != null)
            {
                TrackBorder.SetValue(Border.BackgroundProperty, NewState ? TrackOnBorderColor : TrackOffBorderColor);
            }
            if (Track != null)
            {
                Track.SetValue(Border.BackgroundProperty, NewState ? TrackOnColor : TrackOffColor);
            }
            if (Thumb != null)
            {
                Thumb.SetValue(Border.BackgroundProperty, NewState ? ThumbOnColor : ThumbOffColor);
            }
            if (Font != null)
            {
                Font.SetValue(TextBlock.ForegroundProperty, NewState ? FontOnColor : FontOffColor);
                Font.SetValue(TextBlock.TextProperty, NewState ? "ON" : "OFF");
            }
            IsChecked = NewState;
        }

        private static void OnStateCommandChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = (SlideToggleButton)d;
            IResultCommand<object> newValue = (IResultCommand<object>)e.NewValue;
            if (newValue == null)
                return;
            control.SetDefaultState(newValue.Execute(control));
        }

        protected override void OnClick()
        {
            // Nothing
        }

        protected override void OnToggle()
        {
            // Nothing
        }
    }
}
