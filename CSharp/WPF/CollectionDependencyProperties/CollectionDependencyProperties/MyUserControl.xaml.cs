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

namespace CollectionDependencyProperties
{
    /// <summary>
    /// Interaction logic for MyUserControl.xaml
    /// </summary>
    public partial class MyUserControl : UserControl
    {
        public MyUserControl()
        {
            SetValue(MyCustomPropertyKey, new List<Button>());
            InitializeComponent();
        }

        private static readonly DependencyPropertyKey MyCustomPropertyKey =
            DependencyProperty.RegisterReadOnly(
              nameof(MyCustomProperty),
              typeof(List<Button>),
              typeof(MyUserControl),
              new PropertyMetadata(new List<Button>())
        );

        public static readonly DependencyProperty MyCustomerPropertyProperty =
            MyCustomPropertyKey.DependencyProperty;

        public List<Button> MyCustomProperty => (List<Button>)GetValue(MyCustomerPropertyProperty);
    }
}
