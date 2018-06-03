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
    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.SysSafProducts")]
    public partial class SysSafProduct : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _ID;

        private System.Nullable<int> _ProductSystems_ID;

        private System.Nullable<int> _SafetyProducts_ID;

        private EntityRef<ProductSystem> _ProductSystem;

        private EntityRef<SafetyProduct> _SafetyProduct;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
        partial void OnProductSystems_IDChanging(System.Nullable<int> value);
        partial void OnProductSystems_IDChanged();
        partial void OnSafetyProducts_IDChanging(System.Nullable<int> value);
        partial void OnSafetyProducts_IDChanged();
        #endregion

        public SysSafProduct()
        {
            this._ProductSystem = default(EntityRef<ProductSystem>);
            this._SafetyProduct = default(EntityRef<SafetyProduct>);
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_SafetyProducts_ID", DbType = "Int")]
        public System.Nullable<int> SafetyProducts_ID
        {
            get
            {
                return this._SafetyProducts_ID;
            }
            set
            {
                if ((this._SafetyProducts_ID != value))
                {
                    if (this._SafetyProduct.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnSafetyProducts_IDChanging(value);
                    this.SendPropertyChanging();
                    this._SafetyProducts_ID = value;
                    this.SendPropertyChanged("SafetyProducts_ID");
                    this.OnSafetyProducts_IDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "ProductSystem_SysSafProduct", Storage = "_ProductSystem", ThisKey = "ProductSystems_ID", OtherKey = "ID", IsForeignKey = true)]
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
                        previousValue.SysSafProducts.Remove(this);
                    }
                    this._ProductSystem.Entity = value;
                    if ((value != null))
                    {
                        value.SysSafProducts.Add(this);
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

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "SafetyProduct_SysSafProduct", Storage = "_SafetyProduct", ThisKey = "SafetyProducts_ID", OtherKey = "ID", IsForeignKey = true)]
        public SafetyProduct SafetyProduct
        {
            get
            {
                return this._SafetyProduct.Entity;
            }
            set
            {
                SafetyProduct previousValue = this._SafetyProduct.Entity;
                if (((previousValue != value)
                            || (this._SafetyProduct.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._SafetyProduct.Entity = null;
                        previousValue.SysSafProducts.Remove(this);
                    }
                    this._SafetyProduct.Entity = value;
                    if ((value != null))
                    {
                        value.SysSafProducts.Add(this);
                        this._SafetyProducts_ID = value.ID;
                    }
                    else
                    {
                        this._SafetyProducts_ID = default(Nullable<int>);
                    }
                    this.SendPropertyChanged("SafetyProduct");
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
