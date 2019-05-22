using ClassLibrary1;//应用自己创建的类库
using System.Windows;

namespace WpfApp2
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        Calculate calculate = new Calculate();//实例化类库里的类
        int sum = 0;
        public MainWindow()
        {
            InitializeComponent();
            sum = calculate.sum(1, 2);
            MessageBox.Show("算术和为：" + sum.ToString());
        }
    }
}
