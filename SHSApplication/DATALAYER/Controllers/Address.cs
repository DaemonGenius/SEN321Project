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
    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.Addresses")]
    public partial class Address : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _ID;

        private string _Street;

        private int _StreetNum;

        private string _Zipcode;

        private string _City;

        private string _Province;

        private string _Country;

        private EntitySet<People> _Peoples;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
        partial void OnStreetChanging(string value);
        partial void OnStreetChanged();
        partial void OnStreetNumChanging(int value);
        partial void OnStreetNumChanged();
        partial void OnZipcodeChanging(string value);
        partial void OnZipcodeChanged();
        partial void OnCityChanging(string value);
        partial void OnCityChanged();
        partial void OnProvinceChanging(string value);
        partial void OnProvinceChanged();
        partial void OnCountryChanging(string value);
        partial void OnCountryChanged();
        #endregion

        public Address()
        {
            this._Peoples = new EntitySet<People>(new Action<People>(this.attach_Peoples), new Action<People>(this.detach_Peoples));
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Street", DbType = "NVarChar(MAX)")]
        public string Street
        {
            get
            {
                return this._Street;
            }
            set
            {
                if ((this._Street != value))
                {
                    this.OnStreetChanging(value);
                    this.SendPropertyChanging();
                    this._Street = value;
                    this.SendPropertyChanged("Street");
                    this.OnStreetChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_StreetNum", DbType = "Int NOT NULL")]
        public int StreetNum
        {
            get
            {
                return this._StreetNum;
            }
            set
            {
                if ((this._StreetNum != value))
                {
                    this.OnStreetNumChanging(value);
                    this.SendPropertyChanging();
                    this._StreetNum = value;
                    this.SendPropertyChanged("StreetNum");
                    this.OnStreetNumChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Zipcode", DbType = "NVarChar(MAX)")]
        public string Zipcode
        {
            get
            {
                return this._Zipcode;
            }
            set
            {
                if ((this._Zipcode != value))
                {
                    this.OnZipcodeChanging(value);
                    this.SendPropertyChanging();
                    this._Zipcode = value;
                    this.SendPropertyChanged("Zipcode");
                    this.OnZipcodeChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_City", DbType = "NVarChar(MAX)")]
        public string City
        {
            get
            {
                return this._City;
            }
            set
            {
                if ((this._City != value))
                {
                    this.OnCityChanging(value);
                    this.SendPropertyChanging();
                    this._City = value;
                    this.SendPropertyChanged("City");
                    this.OnCityChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Province", DbType = "NVarChar(MAX)")]
        public string Province
        {
            get
            {
                return this._Province;
            }
            set
            {
                if ((this._Province != value))
                {
                    this.OnProvinceChanging(value);
                    this.SendPropertyChanging();
                    this._Province = value;
                    this.SendPropertyChanged("Province");
                    this.OnProvinceChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Country", DbType = "NVarChar(MAX)")]
        public string Country
        {
            get
            {
                return this._Country;
            }
            set
            {
                if ((this._Country != value))
                {
                    this.OnCountryChanging(value);
                    this.SendPropertyChanging();
                    this._Country = value;
                    this.SendPropertyChanged("Country");
                    this.OnCountryChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Address_People", Storage = "_Peoples", ThisKey = "ID", OtherKey = "Address_ID")]
        public EntitySet<People> Peoples
        {
            get
            {
                return this._Peoples;
            }
            set
            {
                this._Peoples.Assign(value);
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

        private void attach_Peoples(People entity)
        {
            this.SendPropertyChanging();
            entity.Address = this;
        }

        private void detach_Peoples(People entity)
        {
            this.SendPropertyChanging();
            entity.Address = null;
        }
    }
}