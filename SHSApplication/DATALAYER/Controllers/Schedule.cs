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
    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.Schedules")]
    public partial class Schedule : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _ID;

        private System.DateTime _InsDateStart;

        private System.DateTime _MainDateStart;

        private System.Nullable<int> _TechnicianEmp_ID;

        private EntityRef<TechnicianEmp> _TechnicianEmp;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
        partial void OnInsDateStartChanging(System.DateTime value);
        partial void OnInsDateStartChanged();
        partial void OnMainDateStartChanging(System.DateTime value);
        partial void OnMainDateStartChanged();
        partial void OnTechnicianEmp_IDChanging(System.Nullable<int> value);
        partial void OnTechnicianEmp_IDChanged();
        #endregion

        public Schedule()
        {
            this._TechnicianEmp = default(EntityRef<TechnicianEmp>);
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_InsDateStart", DbType = "DateTime NOT NULL")]
        public System.DateTime InsDateStart
        {
            get
            {
                return this._InsDateStart;
            }
            set
            {
                if ((this._InsDateStart != value))
                {
                    this.OnInsDateStartChanging(value);
                    this.SendPropertyChanging();
                    this._InsDateStart = value;
                    this.SendPropertyChanged("InsDateStart");
                    this.OnInsDateStartChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_MainDateStart", DbType = "DateTime NOT NULL")]
        public System.DateTime MainDateStart
        {
            get
            {
                return this._MainDateStart;
            }
            set
            {
                if ((this._MainDateStart != value))
                {
                    this.OnMainDateStartChanging(value);
                    this.SendPropertyChanging();
                    this._MainDateStart = value;
                    this.SendPropertyChanged("MainDateStart");
                    this.OnMainDateStartChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_TechnicianEmp_ID", DbType = "Int")]
        public System.Nullable<int> TechnicianEmp_ID
        {
            get
            {
                return this._TechnicianEmp_ID;
            }
            set
            {
                if ((this._TechnicianEmp_ID != value))
                {
                    if (this._TechnicianEmp.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnTechnicianEmp_IDChanging(value);
                    this.SendPropertyChanging();
                    this._TechnicianEmp_ID = value;
                    this.SendPropertyChanged("TechnicianEmp_ID");
                    this.OnTechnicianEmp_IDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "TechnicianEmp_Schedule", Storage = "_TechnicianEmp", ThisKey = "TechnicianEmp_ID", OtherKey = "ID", IsForeignKey = true)]
        public TechnicianEmp TechnicianEmp
        {
            get
            {
                return this._TechnicianEmp.Entity;
            }
            set
            {
                TechnicianEmp previousValue = this._TechnicianEmp.Entity;
                if (((previousValue != value)
                            || (this._TechnicianEmp.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._TechnicianEmp.Entity = null;
                        previousValue.Schedules.Remove(this);
                    }
                    this._TechnicianEmp.Entity = value;
                    if ((value != null))
                    {
                        value.Schedules.Add(this);
                        this._TechnicianEmp_ID = value.ID;
                    }
                    else
                    {
                        this._TechnicianEmp_ID = default(Nullable<int>);
                    }
                    this.SendPropertyChanged("TechnicianEmp");
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
