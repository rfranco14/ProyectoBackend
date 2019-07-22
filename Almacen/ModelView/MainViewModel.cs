using Almacen.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Almacen.ModelView
{
    public class MainViewModel : INotifyPropertyChanged, ICommand 
    {
        public event EventHandler CanExecuteChanged;
        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel Instancia { get; set; }
        public MainViewModel()
        {
            this.Instancia = this;
        }

        public bool CanExecute(object paramenter)
        {
            return true;
        }

        public void Execute (object parameter)
        {
            if (parameter.Equals("Categorias"))
                {
                new CategoriaView().ShowDialog();
            }
            else if (parameter.Equals("TipoEmpaques"))
            {
                new TipoEmpaqueView().ShowDialog();
            }
            else if (parameter.Equals("Productos"))
            {
                new ProductoView().ShowDialog();
            }
        }
    }
}
