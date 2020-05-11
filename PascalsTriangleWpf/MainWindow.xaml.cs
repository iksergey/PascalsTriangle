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
using static PascalsTriangle.TriangleProgram;

namespace PascalsTriangleWpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FillTriangle();
            int n = 10;
            row = n;

            FlowDocument flowDocument = new FlowDocument();
            Paragraph paragraph = new Paragraph();

            for (int i = 0; i <= n; i++)
            {
                int k = triangle[n, i];

                Run kof = new Run($"{k}");
                if (k != 1) paragraph.Inlines.Add(kof);

                if(n - i != 0)
                {
                    paragraph.Inlines.Add("a");
                    Run powA = new Run($"{n - i}"); powA.Typography.Variants = FontVariants.Superscript;
                    if (n - i != 1) paragraph.Inlines.Add(powA);
                }
                if (i != 0)
                {
                    paragraph.Inlines.Add("b");
                    Run powB = new Run($"{i}"); powB.Typography.Variants = FontVariants.Superscript;
                    if (i != 1) paragraph.Inlines.Add(powB);
                }
                if (i != n) paragraph.Inlines.Add("+");

            }


            flowDocument.Blocks.Add(paragraph);
            richTB.Document = flowDocument;

        }
    }
}
