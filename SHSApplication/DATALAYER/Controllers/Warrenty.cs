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
    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.Warrenties")]
    public partial class Warrenty : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _ID;

        private string _Type;

        private string _Duration;

        private string _Discription;

        private EntitySet<SafetyProduct> _SafetyProducts;

        private EntitySet<ConvienceProduct> _ConvienceProducts;

        private EntitySet<EnergyProduct> _EnergyProducts;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
        partial void OnTypeChanging(string value);
        partial void OnTypeChanged();
        partial void OnDurationChanging(string value);
        partial void OnDurationChanged();
        partial void OnDiscriptionChanging(string value);
        partial void OnDiscriptionChanged();
        #endregion

        public Warrenty()
        {
            this._SafetyProducts = new EntitySet<SafetyProduct>(new Action<SafetyProduct>(this.attach_SafetyProducts), new Action<SafetyProduct>(this.detach_SafetyProducts));
            this._ConvienceProducts = new EntitySet<ConvienceProduct>(new Action<ConvienceProduct>(this.attach_ConvienceProducts), new Action<ConvienceProduct>(this.detach_ConvienceProducts));
            this._EnergyProducts = new EntitySet<EnergyProduct>(new Action<EnergyProduct>(this.attach_EnergyProducts), new Action<EnergyProduct>(this.detach_EnergyProducts));
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Type", DbType = "NVarChar(MAX)")]
        public string Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                if ((this._Type != value))
                {
                    this.OnTypeChanging(value);
                    this.SendPropertyChanging();
                    this._Type = value;
                    this.SendPropertyChanged("Type");
                    this.OnTypeChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Duration", DbType = "NVarChar(MAX)")]
        public string Duration
        {
            get
            {
                return this._Duration;
            }
            set
            {
                if ((this._Duration != value))
                {
                    this.OnDurationChanging(value);
                    this.SendPropertyChanging();
                    this._Duration = value;
                    this.SendPropertyChanged("Duration");
                    this.OnDurationChanged();
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

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Warrenty_SafetyProduct", Storage = "_SafetyProducts", ThisKey = "ID", OtherKey = "Warrenty_ID")]
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

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Warrenty_ConvienceProduct", Storage = "_ConvienceProducts", ThisKey = "ID", OtherKey = "Warrenty_ID")]
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

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Warrenty_EnergyProduct", Storage = "_EnergyProducts", ThisKey = "ID", OtherKey = "Warrenty_ID")]
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
            entity.Warrenty = this;
        }

        private void detach_SafetyProducts(SafetyProduct entity)
        {
            this.SendPropertyChanging();
            entity.Warrenty = null;
        }

        private void attach_ConvienceProducts(ConvienceProduct entity)
        {
            this.SendPropertyChanging();
            entity.Warrenty = this;
        }

        private void detach_ConvienceProducts(ConvienceProduct entity)
        {
            this.SendPropertyChanging();
            entity.Warrenty = null;
        }

        private void attach_EnergyProducts(EnergyProduct entity)
        {
            this.SendPropertyChanging();
            entity.Warrenty = this;
        }

        private void detach_EnergyProducts(EnergyProduct entity)
        {
            this.SendPropertyChanging();
            entity.Warrenty = null;
        }
    }
}
