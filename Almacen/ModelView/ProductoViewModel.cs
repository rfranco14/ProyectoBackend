using Almacen.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Almacen.ModelView
{
    enum ACCIONP
    {
        NINGUNO,
        NUEVO,
        GUARDAR,
        ACTUALIZAR
    };
    class ProductoViewModel : INotifyPropertyChanged, ICommand
    {
        private AlmacenDataContext db = new AlmacenDataContext();

        private ACCIONP accion = ACCIONP.NINGUNO;
        private Boolean _IsReadOnlyCodigoCategoria = true;
        private Boolean _IsReadOnlyCodigoEmpaque = true;
        private Boolean _IsReadOnlyDescripcion = true;
        private Boolean _IsReadOnlyImagen = true;

        private ProductoViewModel _Instancia;
        private bool _IsEnabledAdd = true;
        private bool _IsEnabledDelete = true;
        private bool _IsEnableUpdate = true;
        private bool _IsEnableSave = false;
        private bool _IsEnableCancel = false;
        private bool _IsEnableCategoria = false;
       //private List<Categoria> _listaCategorias;
        private string _CodigoCategoria;
        private string _CodigoEmpaque;
        private string _Descripcion;
        private string _Imagen;
        private Producto _SelectProducto;

        public ProductoViewModel()
        {
            this.Titulo = "Lista de Productos";
            this.Instancia = this;
        }

        private ObservableCollection<Producto> _Producto;

        public Boolean IsReadOnlyCodigoCategoria
        {
            get { return this._IsReadOnlyCodigoCategoria; }
            set
            {
                this._IsReadOnlyCodigoCategoria = value;
                ChangeNotify("IsReadOnlyCodigoCategoria");
            }
        }

        public Boolean IsReadOnlyCodigoEmpaque
        {
            get { return this._IsReadOnlyCodigoEmpaque; }
            set
            {
                this._IsReadOnlyCodigoEmpaque = value;
                ChangeNotify("IsReadOnlyCodigoEmpaque");
            }
        }
        public Boolean IsReadOnlyDescripcion
        {
            get { return this._IsReadOnlyDescripcion; }
            set
            {
                this._IsReadOnlyDescripcion = value;
                ChangeNotify("IsReadOnlyDescripcion");
            }
        }

        public Boolean IsReadOnlyImagen
        {
            get { return this._IsReadOnlyImagen; }
            set
            {
                this._IsReadOnlyImagen = value;
                ChangeNotify("IsReadOnlyImagen");
            }
        }

        public ProductoViewModel Instancia
        {
            get { return this._Instancia; }
            set { this._Instancia = value; }
        }

        public ObservableCollection<Producto> Productos
        {
            get
            {
                if (this._Producto == null)
                {
                    this._Producto = new ObservableCollection<Producto>();
                    foreach (Producto elemento in db.Productos.ToList())
                    {
                        this._Producto.Add(elemento);
                    }
                }
                return this._Producto;
            }
            set { this._Producto = value; }
        }


        public string CodigoCategoria
        {
            get { return _CodigoCategoria; }
            set
            {
                this._CodigoCategoria = value;
                ChangeNotify("CodigoCategoria");
            }
        }

        public string CodigoEmpaque
        {
            get { return _CodigoEmpaque; }
            set
            {
                this._CodigoEmpaque = value;
                ChangeNotify("CodigoEmpaque");
            }
        }

        public string Descripcion
        {
            get { return _Descripcion; }
            set
            {
                this._Descripcion = value;
                ChangeNotify("Descripcion");
            }
        } 

        public string Imagen
        {
            get { return _Imagen; }
            set
            {
                this._Imagen = value;
                ChangeNotify("Imagen");
            }
        }

        public Producto SelectProducto
        {
            get { return this._SelectProducto; }
            set
            {
                if (value != null)
                {
                    this._SelectProducto = value;
                    this.CodigoCategoria = value.CodigoCategoria.ToString();
                    this.CodigoEmpaque = value.CodigoEmpaque.ToString();
                    this.Descripcion = value.Descripcion;
                    this.Imagen = value.Imagen;
                    ChangeNotify("SelectProducto");
                }
            }
        }

        public Boolean IsEnabledAdd
        {
            get { return this._IsEnabledAdd; }
            set
            {
                this._IsEnabledAdd = value;
                ChangeNotify("IsEnabledAdd");
            }
        }

        public Boolean IsEnabledDelete
        {
            get { return this._IsEnabledDelete; }
            set
            {
                this._IsEnabledDelete = value;
                ChangeNotify("IsEnabledDelete");
            }
        }

        public Boolean IsEnableUpdate
        {
            get { return this._IsEnableUpdate; }
            set
            {
                this._IsEnableUpdate = value;
                ChangeNotify("IsEnableUpdate");
            }
        }

        public Boolean IsEnableSave
        {
            get { return this._IsEnableSave; }
            set
            {
                this._IsEnableSave = value;
                ChangeNotify("IsEnableSave");
            }
        }

        public Boolean IsEnableCancel
        {
            get { return this._IsEnableCancel; }
            set
            {
                this._IsEnableCancel = value;
                ChangeNotify("IsEnableCancel");
            }
        }

        public bool IsEnabledCategoria
        {
            get { return _IsEnableCategoria; }
            set
            {
                _IsEnableCategoria = value;
                ChangeNotify("IsEnabledCategoria");
            }
        }

        public string Titulo { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public void ChangeNotify(string propertie)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertie));
            }
        }

       /* public List<Categoria> ListaCategoria
        {
            get
            {
                if (_listaCategorias != null)
                {
                    return _listaCategorias;
                }
                else
                {
                    _listaCategorias = db.Categorias.ToList();
                    return _listaCategorias;
                }
            }
            set
            {
                _listaCategorias = value;
                ChangeNotify("ListaCategoria");
            }
        }*/



        public void isEnabledAdd()
        {
            this.IsReadOnlyCodigoCategoria = false;
            this.IsReadOnlyCodigoEmpaque = false;
            this.IsReadOnlyDescripcion = false;
            this.IsReadOnlyImagen = false;
            this.IsEnabledCategoria = true;
            this.IsEnableSave = true;
            this.IsEnableUpdate = false;
            this.IsEnabledDelete = false;
            this.IsEnableCancel = true;
            this.accion = ACCIONP.NUEVO;
        }

        public void isEnableSave()
        {
            this.IsReadOnlyCodigoCategoria = true;
            this.IsReadOnlyCodigoEmpaque = true;
            this.IsReadOnlyDescripcion = true;
            this.IsReadOnlyImagen = true;
            this.IsEnabledCategoria = true;
            this.IsEnableSave = false;
            this.IsEnableUpdate = true;
            this.IsEnabledDelete = true;
            this.IsEnableCancel = false;
        }

        public void isEnableUpdate()
        {
            this.accion = ACCIONP.ACTUALIZAR;
            this.IsReadOnlyCodigoCategoria = false;
            this.IsReadOnlyCodigoEmpaque = false;
            this.IsReadOnlyDescripcion = false;
            this.IsReadOnlyImagen = false;
            this.IsEnabledCategoria = false;
            this.IsEnabledAdd = false;
            this.IsEnabledDelete = false;
            this.IsEnableUpdate = false;
            this.IsEnableSave = true;
            this.IsEnableCancel = true;
        }

        public void isEnableActualizar()
        {
            this.IsReadOnlyCodigoCategoria = true;
            this.IsReadOnlyCodigoEmpaque = true;
            this.IsReadOnlyDescripcion = true;
            this.IsReadOnlyImagen = true;
            this.IsEnabledCategoria = true;
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
            this.IsEnabledCategoria = false;
            this._IsReadOnlyCodigoCategoria = true;
            this._IsReadOnlyCodigoEmpaque = true;
            this.IsReadOnlyDescripcion = true;
            this.IsReadOnlyImagen = true;
        }

        public void isEnableCancel()
        {
            this.IsEnabledAdd = true;
            this.IsEnabledDelete = true;
            this.IsEnableUpdate = true;
            this.IsEnableSave = false;
            this.IsEnableCancel = false;
            this.IsEnabledCategoria = false;
            this.IsReadOnlyCodigoCategoria = true;
            this.IsReadOnlyCodigoEmpaque = true;
            this.IsReadOnlyDescripcion = true;
            this.IsReadOnlyImagen = true;
        }

        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter.Equals("Add"))
            {
                MessageBox.Show("Agregar Producto");
                this.isEnabledAdd();
            }
            if (parameter.Equals("Save"))
            {
                switch (this.accion)
                {
                    case ACCIONP.NUEVO:
                        Producto nuevo = new Producto();
                        nuevo.CodigoCategoria = Convert.ToInt16(this.CodigoCategoria);
                        nuevo.CodigoEmpaque = Convert.ToInt16(this.CodigoEmpaque);
                        nuevo.Descripcion = this.Descripcion;
                        nuevo.Imagen = this.Imagen;

                        db.Productos.Add(nuevo);
                        db.SaveChanges();
                        this.Productos.Add(nuevo);
                        MessageBox.Show("Registro Almacenado");
                        isEnableSave();
                        break;
                    case ACCIONP.ACTUALIZAR:
                        try
                        {
                            int posicion = this.Productos.IndexOf(this.SelectProducto);
                            var updateProducto = this.db.Productos.Find(this.SelectProducto.CodigoProducto);
                            updateProducto.CodigoCategoria = Convert.ToInt16(this.CodigoCategoria);
                            updateProducto.CodigoEmpaque = Convert.ToInt16(this.CodigoEmpaque);
                            updateProducto.Descripcion = this.Descripcion;
                            updateProducto.Imagen = this.Imagen;
                            this.db.Entry(updateProducto).State = EntityState.Modified;
                            this.db.SaveChanges();
                            this.Productos.RemoveAt(posicion);
                            this.Productos.Insert(posicion, updateProducto);
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
                this.accion = ACCIONP.ACTUALIZAR;
                isEnableUpdate();
            }
            else if (parameter.Equals("Delete"))
            {
                if (this.SelectProducto != null)
                {
                    var respuesta = MessageBox.Show("Esta seguro de eliminar el registro", "Eliminar", MessageBoxButton.YesNo);
                    if (respuesta == MessageBoxResult.Yes)
                    {
                        try
                        {
                            db.Productos.Remove(this.SelectProducto);
                            db.SaveChanges();
                            this.Productos.Remove(this.SelectProducto);
                            this.accion = ACCIONP.NINGUNO;
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message);
                        }
                        MessageBox.Show("Registro eliminado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar un registro", "Eliminar", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
        }
    }
}
