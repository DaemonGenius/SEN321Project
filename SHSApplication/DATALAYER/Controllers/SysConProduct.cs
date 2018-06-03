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
    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.SysConProducts")]
    public partial class SysConProduct : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _ID;

        private System.Nullable<int> _ProductSystems_ID;

        private System.Nullable<int> _ConvienceProducts_ID;

        private EntityRef<ConvienceProduct> _ConvienceProduct;

        private EntityRef<ProductSystem> _ProductSystem;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
        partial void OnProductSystems_IDChanging(System.Nullable<int> value);
        partial void OnProductSystems_IDChanged();
        partial void OnConvienceProducts_IDChanging(System.Nullable<int> value);
        partial void OnConvienceProducts_IDChanged();
        #endregion

        public SysConProduct()
        {
            this._ConvienceProduct = default(EntityRef<ConvienceProduct>);
            this._ProductSystem = default(EntityRef<ProductSystem>);
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ProductSystems_ID", DbType = "Int")]
        public System.Nullable<int> ProductSystems_ID
        {
            get
            {
                return this._ProductSystems_ID;
            }
            set
            {
                if ((this._ProductSystems_ID != value))
                {
                    if (this._ProductSystem.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnProductSystems_IDChanging(value);
                    this.SendPropertyChanging();
                    this._ProductSystems_ID = value;
                    this.SendPropertyChanged("ProductSystems_ID");
                    this.OnProductSystems_IDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ConvienceProducts_ID", DbType = "Int")]
        public System.Nullable<int> ConvienceProducts_ID
        {
            get
            {
                return this._ConvienceProducts_ID;
            }
            set
            {
                if ((this._ConvienceProducts_ID != value))
                {
                    if (this._ConvienceProduct.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnConvienceProducts_IDChanging(value);
                    this.SendPropertyChanging();
                    this._ConvienceProducts_ID = value;
                    this.SendPropertyChanged("ConvienceProducts_ID");
                    this.OnConvienceProducts_IDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "ConvienceProduct_SysConProduct", Storage = "_ConvienceProduct", ThisKey = "ConvienceProducts_ID", OtherKey = "ID", IsForeignKey = true)]
        public ConvienceProduct ConvienceProduct
        {
            get
            {
                return this._ConvienceProduct.Entity;
            }
            set
            {
                ConvienceProduct previousValue = this._ConvienceProduct.Entity;
                if (((previousValue != value)
                            || (this._ConvienceProduct.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._ConvienceProduct.Entity = null;
                        previousValue.SysConProducts.Remove(this);
                    }
                    this._ConvienceProduct.Entity = value;
                    if ((value != null))
                    {
                        value.SysConProducts.Add(this);
                        this._ConvienceProducts_ID = value.ID;
                    }
                    else
                    {
                        this._ConvienceProducts_ID = default(Nullable<int>);
                    }
                    this.SendPropertyChanged("ConvienceProduct");
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "ProductSystem_SysConProduct", Storage = "_ProductSystem", ThisKey = "ProductSystems_ID", OtherKey = "ID", IsForeignKey = true)]
        public ProductSystem ProductSystem
        {
            get
            {
                return this._ProductSystem.Entity;
            }
            set
            {
                ProductSystem previousValue = this._ProductSystem.Entity;
                if (((previousValue != value)
                            || (this._ProductSystem.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._ProductSystem.Entity = null;
                        previousValue.SysConProducts.Remove(this);
                    }
                    this._ProductSystem.Entity = value;
                    if ((value != null))
                    {
                        value.SysConProducts.Add(this);
                        this._ProductSystems_ID = value.ID;
                    }
                    else
                    {
                        this._ProductSystems_ID = default(Nullable<int>);
                    }
                    this.SendPropertyChanged("ProductSystem");
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
    }
}
