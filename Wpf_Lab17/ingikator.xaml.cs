using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_Lab17
{
    /// <summary>
    /// Логика взаимодействия для ingikator.xaml
    /// </summary>
    public partial class ingikator : UserControl
    {

        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register(
                nameof(Value),
                typeof(double),
                typeof(ingikator),
                new FrameworkPropertyMetadata(
                    default(double),
                    0,
                    null,
                    new CoerceValueCallback(CoerceMyValue)));

        private static object CoerceMyValue(DependencyObject d, object baseValue)
        {
            double v = (double)baseValue;
            if(v<0)
            {
                return 0;
            }
            if (v>180)
            {
                return 180;
            }
            return v;
        }

        public double Value
        {
            get => (double)GetValue(ValueProperty);
            set => SetValue(ValueProperty,value);
        }
        public ingikator()
        {
            InitializeComponent();
        }
    }
}
