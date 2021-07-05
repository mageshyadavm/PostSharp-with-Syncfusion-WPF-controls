using PostSharp.Patterns.Xaml;
using Syncfusion.UI.Xaml.Grid;
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

namespace SyncfusionPostSharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SfDataGrid_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void ExecuteCut(object obj)
        {
            if (obj is GridRecordContextMenuInfo)
            {
                var grid = (obj as GridRecordContextMenuInfo).DataGrid;
                var copypasteoption = grid.GridCopyOption;
                grid.GridCopyOption = GridCopyOption.CutData;
                grid.GridCopyPaste.Cut();
                grid.GridCopyOption = copypasteoption;
            }
        }

        private bool CanExecuteCut()
        {
            return true;
        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {

        }

        private void Cut_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
