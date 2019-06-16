using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace LoadingDots
{
    public partial class DotsWaitAdorner : UserControl
    {
        /// <summary>
        /// Initializes DotsWaitAdorner <see cref="UserControl"/> instance.
        /// </summary>
        public DotsWaitAdorner() 
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Diameter of shown dots.
        /// </summary>
        public int DotsDiameter
        {
            get { return (int)GetValue(DotsDiameterProperty); }
            set { SetValue(DotsDiameterProperty, value); }
        }

        public static readonly DependencyProperty DotsDiameterProperty =
            DependencyProperty.Register("DotsDiameter", typeof(int), typeof(DotsWaitAdorner), new PropertyMetadata(0));

        /// <summary>
        /// Text shown below for informational purposes.
        /// </summary>
        public string InfoText
        {
            get { return (string)GetValue(InfoTextProperty); }
            set { SetValue(InfoTextProperty, value); }
        }

        public static readonly DependencyProperty InfoTextProperty =
            DependencyProperty.Register("InfoText", typeof(string), typeof(DotsWaitAdorner), new PropertyMetadata(string.Empty));

        /// <summary>
        /// Color (<see cref="Brush"/>) of dots.
        /// </summary>
        public Brush DotsColor
        {
            get { return (Brush)GetValue(DotsColorProperty); }
            set { SetValue(DotsColorProperty, value); }
        }

        public static readonly DependencyProperty DotsColorProperty =
            DependencyProperty.Register("DotsColor", typeof(Brush), typeof(DotsWaitAdorner), new PropertyMetadata(new SolidColorBrush(Color.FromRgb(255,255,255))));

        /// <summary>
        /// Size of the <see cref="InfoText"/> <see cref="DependencyProperty"/>.
        /// </summary>
        public int InfoFontSize
        {
            get { return (int)GetValue(InfoFontSizeProperty); }
            set { SetValue(InfoFontSizeProperty, value); }
        }

        public static readonly DependencyProperty InfoFontSizeProperty =
            DependencyProperty.Register("InfoFontSize", typeof(int), typeof(DotsWaitAdorner), new PropertyMetadata(14));


    }
}
