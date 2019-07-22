using MahApps.Metro.Controls;
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
using System.Windows.Shapes;
using Almacen.ModelView;

namespace Almacen.View
{
    /// <summary>
    /// Lógica de interacción para TipoEmpaqueView.xaml
    /// </summary>
    public partial class TipoEmpaqueView : MetroWindow
    {
        public TipoEmpaqueView()
        {
            InitializeComponent();
            this.DataContext = new TipoEmpaqueViewModel();
        }
    }
}
