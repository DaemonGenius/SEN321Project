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
    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.Maintenances")]
    public partial class Maintenance : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _ID;

        private string _DateStart;

        private string _DateEnd;

        private System.Nullable<int> _Contract_ID;

        private string _Name;

        private EntityRef<Contract> _Contract;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
        partial void OnDateStartChanging(string value);
        partial void OnDateStartChanged();
        partial void OnDateEndChanging(string value);
        partial void OnDateEndChanged();
        partial void OnContract_IDChanging(System.Nullable<int> value);
        partial void OnContract_IDChanged();
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        #endregion

        public Maintenance()
        {
            this._Contract = default(EntityRef<Contract>);
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_DateStart", DbType = "NVarChar(MAX)")]
        public string DateStart
        {
            get
            {
                return this._DateStart;
            }
            set
            {
                if ((this._DateStart != value))
                {
                    this.OnDateStartChanging(value);
                    this.SendPropertyChanging();
                    this._DateStart = value;
                    this.SendPropertyChanged("DateStart");
                    this.OnDateStartChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_DateEnd", DbType = "NVarChar(MAX)")]
        public string DateEnd
        {
            get
            {
                return this._DateEnd;
            }
            set
            {
                if ((this._DateEnd != value))
                {
                    this.OnDateEndChanging(value);
                    this.SendPropertyChanging();
                    this._DateEnd = value;
                    this.SendPropertyChanged("DateEnd");
                    this.OnDateEndChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Contract_ID", DbType = "Int")]
        public System.Nullable<int> Contract_ID
        {
            get
            {
                return this._Contract_ID;
            }
            set
            {
                if ((this._Contract_ID != value))
                {
                    if (this._Contract.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnContract_IDChanging(value);
                    this.SendPropertyChanging();
                    this._Contract_ID = value;
                    this.SendPropertyChanged("Contract_ID");
                    this.OnContract_IDChanged();
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

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Contract_Maintenance", Storage = "_Contract", ThisKey = "Contract_ID", OtherKey = "ID", IsForeignKey = true)]
        public Contract Contract
        {
            get
            {
                return this._Contract.Entity;
            }
            set
            {
                Contract previousValue = this._Contract.Entity;
                if (((previousValue != value)
                            || (this._Contract.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Contract.Entity = null;
                        previousValue.Maintenances.Remove(this);
                    }
                    this._Contract.Entity = value;
                    if ((value != null))
                    {
                        value.Maintenances.Add(this);
                        this._Contract_ID = value.ID;
                    }
                    else
                    {
                        this._Contract_ID = default(Nullable<int>);
                    }
                    this.SendPropertyChanged("Contract");
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
