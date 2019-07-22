using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using System.Windows;
using System.Data.Entity;
using Almacen.Model;

namespace Almacen.ModelView
{
    enum ACCION
    {
        NINGUNO,
        NUEVO,
        GUARDAR,
        ACTUALIZAR
    };
    public class CategoriaViewModel : INotifyPropertyChanged,ICommand
    {
        private AlmacenDataContext db = new AlmacenDataContext();

        private ACCION accion = ACCION.NINGUNO;
        private Boolean _IsReadOnlyDescripcion = true;

        private CategoriaViewModel _Instancia;
        private bool _IsEnabledAdd = true;
        private bool _IsEnabledDelete = true;
        private bool _IsEnableUpdate = true;
        private bool _IsEnableSave = false;
        private bool _IsEnableCancel = false;

        private string _Descripcion;
        private Categoria _SelectCategoria;

        public CategoriaViewModel()
        {
            this.Titulo = "Lista de Categorias";
            this.Instancia = this;
        }

        private ObservableCollection<Categoria> _Categoria;

        public Boolean IsReadOnlyDescripcion
        {
            get { return this._IsReadOnlyDescripcion; }
            set { this._IsReadOnlyDescripcion = value;
                ChangeNotify("IsReadOnlyDescripcion"); }
        }

        public CategoriaViewModel Instancia
        {
            get { return this._Instancia; }
            set { this._Instancia = value; }
        }

        public ObservableCollection<Categoria> Categorias
        {
            get
            {
                if (this._Categoria == null)
                {
                    this._Categoria = new ObservableCollection<Categoria>();
                    foreach (Categoria elemento in db.Categorias.ToList())
                    {
                        this._Categoria.Add(elemento);
                    }
                }
                return this._Categoria;
            }
            set { this._Categoria = value; }
        }

        public string Descripcion
        {
            get { return _Descripcion; }
            set { this._Descripcion = value;
                ChangeNotify("Descripcion"); }
        }

        public Categoria SelectCategoria
        {
            get { return this._SelectCategoria; }
            set
            {
                if (value != null)
                {
                    this._SelectCategoria = value;
                    this.Descripcion = value.Descripcion;
                    ChangeNotify("SelectCategoria");
                }
            }
        }

        public Boolean IsEnabledAdd
        {
            get { return this._IsEnabledAdd;  }
            set { this._IsEnabledAdd = value;
                ChangeNotify("IsEnabledAdd");}
        }

        public Boolean IsEnabledDelete
        {
            get { return this._IsEnabledDelete; }
            set { this._IsEnabledDelete = value;
                ChangeNotify("IsEnabledDelete");}
        }

        public Boolean IsEnableUpdate
        {
            get { return this._IsEnableUpdate; }
            set { this._IsEnableUpdate = value;
                ChangeNotify("IsEnableUpdate"); }
        }

        public Boolean IsEnableSave
        {
            get { return this._IsEnableSave; }
            set { this._IsEnableSave = value;
                ChangeNotify("IsEnableSave"); }
        }

        public Boolean IsEnableCancel
        {
            get { return this._IsEnableCancel;  }
            set { this._IsEnableCancel = value;
                ChangeNotify("IsEnableCancel");}
        }

        public string Titulo { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public void ChangeNotify(string propertie)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertie));
            }
        }

        public void isEnabledAdd()
        {
            this.IsReadOnlyDescripcion = false;
            this.IsEnableSave = true;
            this.IsEnableUpdate = false;
            this.IsEnabledDelete = false;
            this.IsEnableCancel = true;
            this.accion = ACCION.NUEVO;
        }
          
        public void isEnableSave()
        {
            this.IsReadOnlyDescripcion = true;
            this.IsEnableSave = false;
            this.IsEnableUpdate = true;
            this.IsEnabledDelete = true;
            this.IsEnableCancel = false;
        }

        public void isEnableUpdate ()
        {
            this.accion = ACCION.ACTUALIZAR;
            this.IsReadOnlyDescripcion = false;
            this.IsEnabledAdd = false;
            this.IsEnabledDelete = false;
            this.IsEnableUpdate = false;
            this.IsEnableSave = true;
            this.IsEnableCancel = true;
        }

        public void isEnableActualizar()
        {
            this.IsReadOnlyDescripcion = true;
            this.IsEnabledAdd = true;
            this.IsEnableSave = false;
            this.IsEnableUpdate = true;
            this.IsEnabledDelete = true;
            this.IsEnableCancel = false;
        }

        public void isEnableErrorActualizar()
        {
            this.IsEnabledAdd = true;
            this.IsEnabledDelete = true;
            this.IsEnableUpdate = true;
            this.IsEnableSave = false;
            this.IsEnableCancel = false;
            this.IsReadOnlyDescripcion = true;
        }

        public void isEnableCancel ()
        {
            this.IsEnabledAdd = true;
            this.IsEnabledDelete = true;
            this.IsEnableUpdate = true;
            this.IsEnableSave = false;
            this.IsEnableCancel = false;
            this.IsReadOnlyDescripcion = true;
        }

        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public  void Execute(object parameter)
        {
            if(parameter.Equals("Add"))
            {
                MessageBox.Show("Agregar Categoria");
                this.isEnabledAdd();
            }
            if (parameter.Equals("Save"))
            {
                switch(this.accion)
                {
                    case ACCION.NUEVO:
                        Categoria nuevo = new Categoria();
                        nuevo.Descripcion = this.Descripcion;
                        db.Categorias.Add(nuevo);
                        db.SaveChanges();
                        this.Categorias.Add(nuevo);
                        MessageBox.Show("Registro Almacenado");
                        isEnableSave();
                        break;
                    case ACCION.ACTUALIZAR:
                        try
                        {
                            int posicion = this.Categorias.IndexOf(this.SelectCategoria);
                            var updateCategoria = this.db.Categorias.Find(this.SelectCategoria.CodigoCategoria);
                            updateCategoria.Descripcion = this.Descripcion;
                            this.db.Entry(updateCategoria).State = EntityState.Modified;
                            this.db.SaveChanges();
                            this.Categorias.RemoveAt(posicion);
                            this.Categorias.Insert(posicion, updateCategoria);
                            MessageBox.Show("Registro Actualizado");
                            isEnableActualizar();
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message);
                            isEnableErrorActualizar();
                        }
                        break;
                }
            }
            else if (parameter.Equals("Update"))
            {
                this.accion = ACCION.ACTUALIZAR;
                isEnableUpdate();
            }
            else if (parameter.Equals("Delete"))
            {
                if (this.SelectCategoria != null)
                {
                    var respuesta = MessageBox.Show("Esta seguro de eliminar el registro", "Eliminar", MessageBoxButton.YesNo);
                    if(respuesta == MessageBoxResult.Yes)
                    {
                        try
                        {
                            db.Categorias.Remove(this.SelectCategoria);
                            db.SaveChanges();
                            this.Categorias.Remove(this.SelectCategoria);
                            this.accion = ACCION.NINGUNO;
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message);
                        }
                        MessageBox.Show("Registro eliminado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar un registro", "Eliminar", MessageBoxButton.OK,MessageBoxImage.Error);
                    }
                }
            }
        }
    }
}
