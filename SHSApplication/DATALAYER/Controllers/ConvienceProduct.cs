﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATALAYER.Controllers
{
    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.ConvienceProducts")]
    public partial class ConvienceProduct : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _ID;

        private string _Name;

        private string _Discription;

        private double _Price;

        private System.Nullable<int> _Warrenty_ID;

        private EntitySet<SysConProduct> _SysConProducts;

        private EntityRef<Warrenty> _Warrenty;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        partial void OnDiscriptionChanging(string value);
        partial void OnDiscriptionChanged();
        partial void OnPriceChanging(double value);
        partial void OnPriceChanged();
        partial void OnWarrenty_IDChanging(System.Nullable<int> value);
        partial void OnWarrenty_IDChanged();
        #endregion

        public ConvienceProduct()
        {
            this._SysConProducts = new EntitySet<SysConProduct>(new Action<SysConProduct>(this.attach_SysConProducts), new Action<SysConProduct>(this.detach_SysConProducts));
            this._Warrenty = default(EntityRef<Warrenty>);
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Discription", DbType = "NVarChar(MAX)")]
        public string Discription
        {
            get
            {
                return this._Discription;
            }
            set
            {
                if ((this._Discription != value))
                {
                    this.OnDiscriptionChanging(value);
                    this.SendPropertyChanging();
                    this._Discription = value;
                    this.SendPropertyChanged("Discription");
                    this.OnDiscriptionChanged();
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Warrenty_ID", DbType = "Int")]
        public System.Nullable<int> Warrenty_ID
        {
            get
            {
                return this._Warrenty_ID;
            }
            set
            {
                if ((this._Warrenty_ID != value))
                {
                    if (this._Warrenty.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnWarrenty_IDChanging(value);
                    this.SendPropertyChanging();
                    this._Warrenty_ID = value;
                    this.SendPropertyChanged("Warrenty_ID");
                    this.OnWarrenty_IDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "ConvienceProduct_SysConProduct", Storage = "_SysConProducts", ThisKey = "ID", OtherKey = "ConvienceProducts_ID")]
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

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Warrenty_ConvienceProduct", Storage = "_Warrenty", ThisKey = "Warrenty_ID", OtherKey = "ID", IsForeignKey = true)]
        public Warrenty Warrenty
        {
            get
            {
                return this._Warrenty.Entity;
            }
            set
            {
                Warrenty previousValue = this._Warrenty.Entity;
                if (((previousValue != value)
                            || (this._Warrenty.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Warrenty.Entity = null;
                        previousValue.ConvienceProducts.Remove(this);
                    }
                    this._Warrenty.Entity = value;
                    if ((value != null))
                    {
                        value.ConvienceProducts.Add(this);
                        this._Warrenty_ID = value.ID;
                    }
                    else
                    {
                        this._Warrenty_ID = default(Nullable<int>);
                    }
                    this.SendPropertyChanged("Warrenty");
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

        private void attach_SysConProducts(SysConProduct entity)
        {
            this.SendPropertyChanging();
            entity.ConvienceProduct = this;
        }

        private void detach_SysConProducts(SysConProduct entity)
        {
            this.SendPropertyChanging();
            entity.ConvienceProduct = null;
        }
    }
}
