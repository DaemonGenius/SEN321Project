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
    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.Admins")]
    public partial class Admin : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _ID;

        private System.Nullable<int> _Messaging_ID;

        private System.Nullable<int> _person_ID;

        private EntityRef<People> _People;

        private EntityRef<Messaging> _Messaging;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
        partial void OnMessaging_IDChanging(System.Nullable<int> value);
        partial void OnMessaging_IDChanged();
        partial void Onperson_IDChanging(System.Nullable<int> value);
        partial void Onperson_IDChanged();
        #endregion

        public Admin()
        {
            this._People = default(EntityRef<People>);
            this._Messaging = default(EntityRef<Messaging>);
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Messaging_ID", DbType = "Int")]
        public System.Nullable<int> Messaging_ID
        {
            get
            {
                return this._Messaging_ID;
            }
            set
            {
                if ((this._Messaging_ID != value))
                {
                    if (this._Messaging.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnMessaging_IDChanging(value);
                    this.SendPropertyChanging();
                    this._Messaging_ID = value;
                    this.SendPropertyChanged("Messaging_ID");
                    this.OnMessaging_IDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_person_ID", DbType = "Int")]
        public System.Nullable<int> person_ID
        {
            get
            {
                return this._person_ID;
            }
            set
            {
                if ((this._person_ID != value))
                {
                    if (this._People.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.Onperson_IDChanging(value);
                    this.SendPropertyChanging();
                    this._person_ID = value;
                    this.SendPropertyChanged("person_ID");
                    this.Onperson_IDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "People_Admin", Storage = "_People", ThisKey = "person_ID", OtherKey = "ID", IsForeignKey = true)]
        public People People
        {
            get
            {
                return this._People.Entity;
            }
            set
            {
                People previousValue = this._People.Entity;
                if (((previousValue != value)
                            || (this._People.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._People.Entity = null;
                        previousValue.Admins.Remove(this);
                    }
                    this._People.Entity = value;
                    if ((value != null))
                    {
                        value.Admins.Add(this);
                        this._person_ID = value.ID;
                    }
                    else
                    {
                        this._person_ID = default(Nullable<int>);
                    }
                    this.SendPropertyChanged("People");
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Messaging_Admin", Storage = "_Messaging", ThisKey = "Messaging_ID", OtherKey = "ID", IsForeignKey = true)]
        public Messaging Messaging
        {
            get
            {
                return this._Messaging.Entity;
            }
            set
            {
                Messaging previousValue = this._Messaging.Entity;
                if (((previousValue != value)
                            || (this._Messaging.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Messaging.Entity = null;
                        previousValue.Admins.Remove(this);
                    }
                    this._Messaging.Entity = value;
                    if ((value != null))
                    {
                        value.Admins.Add(this);
                        this._Messaging_ID = value.ID;
                    }
                    else
                    {
                        this._Messaging_ID = default(Nullable<int>);
                    }
                    this.SendPropertyChanged("Messaging");
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
