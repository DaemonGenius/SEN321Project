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

        private int _Cart_ID;

        private EntitySet<SafetyProduct> _SafetyProducts;

        private EntitySet<ConvienceProduct> _ConvienceProducts;

        private EntitySet<EnergyProduct> _EnergyProducts;

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
        partial void OnCart_IDChanging(int value);
        partial void OnCart_IDChanged();
        #endregion

        public ProductSystem()
        {
            this._SafetyProducts = new EntitySet<SafetyProduct>(new Action<SafetyProduct>(this.attach_SafetyProducts), new Action<SafetyProduct>(this.detach_SafetyProducts));
            this._ConvienceProducts = new EntitySet<ConvienceProduct>(new Action<ConvienceProduct>(this.attach_ConvienceProducts), new Action<ConvienceProduct>(this.detach_ConvienceProducts));
            this._EnergyProducts = new EntitySet<EnergyProduct>(new Action<EnergyProduct>(this.attach_EnergyProducts), new Action<EnergyProduct>(this.detach_EnergyProducts));
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Name", DbType = "NVarChar(MAX) NOT NULL", CanBeNull = false)]
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Cart_ID", DbType = "Int NOT NULL")]
        public int Cart_ID
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

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "ProductSystem_SafetyProduct", Storage = "_SafetyProducts", ThisKey = "ID", OtherKey = "ProductSystems_ID")]
        public EntitySet<SafetyProduct> SafetyProducts
        {
            get
            {
                return this._SafetyProducts;
            }
            set
            {
                this._SafetyProducts.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "ProductSystem_ConvienceProduct", Storage = "_ConvienceProducts", ThisKey = "ID", OtherKey = "ProductSystems_ID")]
        public EntitySet<ConvienceProduct> ConvienceProducts
        {
            get
            {
                return this._ConvienceProducts;
            }
            set
            {
                this._ConvienceProducts.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "ProductSystem_EnergyProduct", Storage = "_EnergyProducts", ThisKey = "ID", OtherKey = "ProductSystems_ID")]
        public EntitySet<EnergyProduct> EnergyProducts
        {
            get
            {
                return this._EnergyProducts;
            }
            set
            {
                this._EnergyProducts.Assign(value);
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
                        this._Cart_ID = default(int);
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

        private void attach_SafetyProducts(SafetyProduct entity)
        {
            this.SendPropertyChanging();
            entity.ProductSystem = this;
        }

        private void detach_SafetyProducts(SafetyProduct entity)
        {
            this.SendPropertyChanging();
            entity.ProductSystem = null;
        }

        private void attach_ConvienceProducts(ConvienceProduct entity)
        {
            this.SendPropertyChanging();
            entity.ProductSystem = this;
        }

        private void detach_ConvienceProducts(ConvienceProduct entity)
        {
            this.SendPropertyChanging();
            entity.ProductSystem = null;
        }

        private void attach_EnergyProducts(EnergyProduct entity)
        {
            this.SendPropertyChanging();
            entity.ProductSystem = this;
        }

        private void detach_EnergyProducts(EnergyProduct entity)
        {
            this.SendPropertyChanging();
            entity.ProductSystem = null;
        }
    }
}
