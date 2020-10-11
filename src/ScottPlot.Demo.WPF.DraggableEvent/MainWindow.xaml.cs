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
using Color = System.Drawing.Color;

namespace ScottPlot.Demo.WPF.DraggableEvent
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PlottableVSpan _vSpan;
        private PlottableHSpan _hSpan;

        public MainWindow()
        {
            InitializeComponent();
            _hSpan = Plot.plt.PlotHSpan(0, 0.1, Color.Crimson, draggable: true, dragFixedSize: true);
            _vSpan = Plot.plt.PlotVSpan(0, 0.1, Color.Coral, draggable: true, dragFixedSize: true);
            Plot.MouseDownOnPlottable += OnMouseDragDown;
            Plot.MouseDragPlottable += OnMouseDrag;
            Plot.MouseUpPlottable += OnMouseDragUp;
        }

        private void OnMouseDrag(object sender, PlottableDragEventArgs agrs)
        {
            if (agrs.Draggable == _hSpan)
            {
                TextBox.Text += "\nDrag H-Span!";
            }
            else if (agrs.Draggable == _vSpan)
            {
                TextBox.Text += "\nDrag V-Span!";
            }
        }


        private void OnMouseDragDown(object sender, PlottableDragEventArgs agrs)
        {
            if (agrs.Draggable == _hSpan)
            {
                TextBox.Text += "\n Down Drag H-Span!";
            }
            else if (agrs.Draggable == _vSpan)
            {
                TextBox.Text += "\n Down Drag V-Span!";
            }
        }


        private void OnMouseDragUp(object sender, PlottableDragEventArgs agrs)
        {
            if (agrs.Draggable == _hSpan)
            {
                TextBox.Text = "H-Span up!";
            }
            else if (agrs.Draggable == _vSpan)
            {
                TextBox.Text = "V-Span up!";
            }
        }

    }
}
