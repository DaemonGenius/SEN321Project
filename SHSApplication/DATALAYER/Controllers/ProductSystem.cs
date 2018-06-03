using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATALAYER.Controllers
{
    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.ProductSystems")]
    public partial class ProductSystem : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _ID;

        private string _Name;

        private double _Price;

        private System.Nullable<int> _Cart_ID;

        private EntitySet<Maintenance> _Maintenances;

        private EntitySet<SysConProduct> _SysConProducts;

        private EntitySet<SysEneProduct> _SysEneProducts;

        private EntitySet<SysSafProduct> _SysSafProducts;

        private EntityRef<Cart> _Cart;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        partial void OnPriceChanging(double value);
        partial void OnPriceChanged();
        partial void OnCart_IDChanging(System.Nullable<int> value);
        partial void OnCart_IDChanged();
        #endregion

        public ProductSystem()
        {
            this._Maintenances = new EntitySet<Maintenance>(new Action<Maintenance>(this.attach_Maintenances), new Action<Maintenance>(this.detach_Maintenances));
            this._SysConProducts = new EntitySet<SysConProduct>(new Action<SysConProduct>(this.attach_SysConProducts), new Action<SysConProduct>(this.detach_SysConProducts));
            this._SysEneProducts = new EntitySet<SysEneProduct>(new Action<SysEneProduct>(this.attach_SysEneProducts), new Action<SysEneProduct>(this.detach_SysEneProducts));
            this._SysSafProducts = new EntitySet<SysSafProduct>(new Action<SysSafProduct>(this.attach_SysSafProducts), new Action<SysSafProduct>(this.detach_SysSafProducts));
            this._Cart = default(EntityRef<Cart>);
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ID", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                if ((this._ID != value))
                {
                    this.OnIDChanging(value);
                    this.SendPropertyChanging();
                    this._ID = value;
                    this.SendPropertyChanged("ID");
                    this.OnIDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Name", DbType = "NVarChar(MAX)")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                if ((this._Name != value))
                {
                    this.OnNameChanging(value);
                    this.SendPropertyChanging();
                    this._Name = value;
                    this.SendPropertyChanged("Name");
                    this.OnNameChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Price", DbType = "Float NOT NULL")]
        public double Price
        {
            get
            {
                return this._Price;
            }
            set
            {
                if ((this._Price != value))
                {
                    this.OnPriceChanging(value);
                    this.SendPropertyChanging();
                    this._Price = value;
                    this.SendPropertyChanged("Price");
                    this.OnPriceChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Cart_ID", DbType = "Int")]
        public System.Nullable<int> Cart_ID
        {
            get
            {
                return this._Cart_ID;
            }
            set
            {
                if ((this._Cart_ID != value))
                {
                    if (this._Cart.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnCart_IDChanging(value);
                    this.SendPropertyChanging();
                    this._Cart_ID = value;
                    this.SendPropertyChanged("Cart_ID");
                    this.OnCart_IDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "ProductSystem_Maintenance", Storage = "_Maintenances", ThisKey = "ID", OtherKey = "ProductSystems_ID")]
        public EntitySet<Maintenance> Maintenances
        {
            get
            {
                return this._Maintenances;
            }
            set
            {
                this._Maintenances.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "ProductSystem_SysConProduct", Storage = "_SysConProducts", ThisKey = "ID", OtherKey = "ProductSystems_ID")]
        public EntitySet<SysConProduct> SysConProducts
        {
            get
            {
                return this._SysConProducts;
            }
            set
            {
                this._SysConProducts.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "ProductSystem_SysEneProduct", Storage = "_SysEneProducts", ThisKey = "ID", OtherKey = "ProductSystems_ID")]
        public EntitySet<SysEneProduct> SysEneProducts
        {
            get
            {
                return this._SysEneProducts;
            }
            set
            {
                this._SysEneProducts.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "ProductSystem_SysSafProduct", Storage = "_SysSafProducts", ThisKey = "ID", OtherKey = "ProductSystems_ID")]
        public EntitySet<SysSafProduct> SysSafProducts
        {
            get
            {
                return this._SysSafProducts;
            }
            set
            {
                this._SysSafProducts.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Cart_ProductSystem", Storage = "_Cart", ThisKey = "Cart_ID", OtherKey = "ID", IsForeignKey = true)]
        public Cart Cart
        {
            get
            {
                return this._Cart.Entity;
            }
            set
            {
                Cart previousValue = this._Cart.Entity;
                if (((previousValue != value)
                            || (this._Cart.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Cart.Entity = null;
                        previousValue.ProductSystems.Remove(this);
                    }
                    this._Cart.Entity = value;
                    if ((value != null))
                    {
                        value.ProductSystems.Add(this);
                        this._Cart_ID = value.ID;
                    }
                    else
                    {
                        this._Cart_ID = default(Nullable<int>);
                    }
                    this.SendPropertyChanged("Cart");
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void attach_Maintenances(Maintenance entity)
        {
            this.SendPropertyChanging();
            entity.ProductSystem = this;
        }

        private void detach_Maintenances(Maintenance entity)
        {
            this.SendPropertyChanging();
            entity.ProductSystem = null;
        }

        private void attach_SysConProducts(SysConProduct entity)
        {
            this.SendPropertyChanging();
            entity.ProductSystem = this;
        }

        private void detach_SysConProducts(SysConProduct entity)
        {
            this.SendPropertyChanging();
            entity.ProductSystem = null;
        }

        private void attach_SysEneProducts(SysEneProduct entity)
        {
            this.SendPropertyChanging();
            entity.ProductSystem = this;
        }

        private void detach_SysEneProducts(SysEneProduct entity)
        {
            this.SendPropertyChanging();
            entity.ProductSystem = null;
        }

        private void attach_SysSafProducts(SysSafProduct entity)
        {
            this.SendPropertyChanging();
            entity.ProductSystem = this;
        }

        private void detach_SysSafProducts(SysSafProduct entity)
        {
            this.SendPropertyChanging();
            entity.ProductSystem = null;
        }
    }
}
