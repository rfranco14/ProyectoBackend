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
    enum ACCIONT
    {
        NINGUNO,
        NUEVO,
        GUARDAR,
        ACTUALIZAR
    };

    class TipoEmpaqueViewModel : INotifyPropertyChanged, ICommand
    {
        private AlmacenDataContext db = new AlmacenDataContext();

        private ACCIONT accion = ACCIONT.NINGUNO;
        private Boolean _IsReadOnlyDescripcion = true;

        private TipoEmpaqueViewModel _Instancia;
        private bool _IsEnabledAdd = true;
        private bool _IsEnabledDelete = true;
        private bool _IsEnableUpdate = true;
        private bool _IsEnableSave = false;
        private bool _IsEnableCancel = false;

        private string _Descripcion;
        private TipoEmpaque _SelectTipoEmpaque;

        public TipoEmpaqueViewModel()
        {
            this.Titulo = "Lista de Tipo Empaque";
            this.Instancia = this;
        }

        private ObservableCollection<TipoEmpaque> _TipoEmpaque;

        public Boolean IsReadOnlyDescripcion
        {
            get { return this._IsReadOnlyDescripcion; }
            set
            {
                this._IsReadOnlyDescripcion = value;
                ChangeNotify("IsReadOnlyDescripcion");
            }
        }

        public TipoEmpaqueViewModel Instancia
        {
            get { return this._Instancia; }
            set { this._Instancia = value; }
        }

        public ObservableCollection<TipoEmpaque> TipoEmpaques
        {
            get
            {
                if (this._TipoEmpaque == null)
                {
                    this._TipoEmpaque = new ObservableCollection<TipoEmpaque>();
                    foreach (TipoEmpaque elemento in db.TipoEmpaques.ToList())
                    {
                        this._TipoEmpaque.Add(elemento);
                    }
                }
                return this._TipoEmpaque;
            }
            set { this._TipoEmpaque = value; }
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
        public TipoEmpaque SelectTipoEmpaque
        {
            get { return this._SelectTipoEmpaque; }
            set
            {
                if (value != null)
                {
                    this._SelectTipoEmpaque = value;
                    this.Descripcion = value.Descripcion;
                    ChangeNotify("SelectTipoEmpaque");
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

        public string Titulo { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public void ChangeNotify(string propertie)
        {
            if (PropertyChanged != null)
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
            this.accion = ACCIONT.NUEVO;
        }

        public void isEnableSave()
        {
            this.IsReadOnlyDescripcion = true;
            this.IsEnableSave = false;
            this.IsEnableUpdate = true;
            this.IsEnabledDelete = true;
            this.IsEnableCancel = false;
        }

        public void isEnableUpdate()
        {
            this.accion = ACCIONT.ACTUALIZAR;
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

        public void isEnableCancel()
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
        public void Execute(object parameter)
        {
            if (parameter.Equals("Add"))
            {
                MessageBox.Show("Agregar Tipo Categoria");
                this.isEnabledAdd();
            }
            if (parameter.Equals("Save"))
            {
                switch (this.accion)
                {
                    case ACCIONT.NUEVO:
                        TipoEmpaque nuevo = new TipoEmpaque();
                        nuevo.Descripcion = this.Descripcion;
                        db.TipoEmpaques.Add(nuevo);
                        db.SaveChanges();
                        this.TipoEmpaques.Add(nuevo);
                        MessageBox.Show("Registro Almacenado");
                        isEnableSave();
                        break;
                    case ACCIONT.ACTUALIZAR:
                        try
                        {
                            int posicion = this.TipoEmpaques.IndexOf(this.SelectTipoEmpaque);
                            var updateTipoEmpaque = this.db.TipoEmpaques.Find(this.SelectTipoEmpaque.CodigoEmpaque);
                            updateTipoEmpaque.Descripcion = this.Descripcion;
                            this.db.Entry(updateTipoEmpaque).State = EntityState.Modified;
                            this.db.SaveChanges();
                            this.TipoEmpaques.RemoveAt(posicion);
                            this.TipoEmpaques.Insert(posicion, updateTipoEmpaque);
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
                this.accion = ACCIONT.ACTUALIZAR;
                isEnableUpdate();
            }
            else if (parameter.Equals("Delete"))
            {
                if (this.SelectTipoEmpaque != null)
                {
                    var respuesta = MessageBox.Show("Esta seguro de eliminar el registro", "Eliminar", MessageBoxButton.YesNo);
                    if (respuesta == MessageBoxResult.Yes)
                    {
                        try
                        {
                            db.TipoEmpaques.Remove(this.SelectTipoEmpaque);
                            db.SaveChanges();
                            this.TipoEmpaques.Remove(this.SelectTipoEmpaque);
                            this.accion = ACCIONT.NINGUNO;
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
