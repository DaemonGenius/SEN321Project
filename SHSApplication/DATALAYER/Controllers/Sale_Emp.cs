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
    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.Sale_Emp")]
    public partial class Sale_Emp : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _ID;

        private System.Nullable<int> _Person_ID;

        private System.Nullable<int> _Messaging_ID;

        private EntitySet<Transaction> _Transactions;

        private EntityRef<People> _People;

        private EntityRef<Messaging> _Messaging;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
        partial void OnPerson_IDChanging(System.Nullable<int> value);
        partial void OnPerson_IDChanged();
        partial void OnMessaging_IDChanging(System.Nullable<int> value);
        partial void OnMessaging_IDChanged();
        #endregion

        public Sale_Emp()
        {
            this._Transactions = new EntitySet<Transaction>(new Action<Transaction>(this.attach_Transactions), new Action<Transaction>(this.detach_Transactions));
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Person_ID", DbType = "Int")]
        public System.Nullable<int> Person_ID
        {
            get
            {
                return this._Person_ID;
            }
            set
            {
                if ((this._Person_ID != value))
                {
                    if (this._People.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnPerson_IDChanging(value);
                    this.SendPropertyChanging();
                    this._Person_ID = value;
                    this.SendPropertyChanged("Person_ID");
                    this.OnPerson_IDChanged();
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

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Sale_Emp_Transaction", Storage = "_Transactions", ThisKey = "ID", OtherKey = "SaleEmp_ID")]
        public EntitySet<Transaction> Transactions
        {
            get
            {
                return this._Transactions;
            }
            set
            {
                this._Transactions.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "People_Sale_Emp", Storage = "_People", ThisKey = "Person_ID", OtherKey = "ID", IsForeignKey = true)]
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
                        previousValue.Sale_Emps.Remove(this);
                    }
                    this._People.Entity = value;
                    if ((value != null))
                    {
                        value.Sale_Emps.Add(this);
                        this._Person_ID = value.ID;
                    }
                    else
                    {
                        this._Person_ID = default(Nullable<int>);
                    }
                    this.SendPropertyChanged("People");
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Messaging_Sale_Emp", Storage = "_Messaging", ThisKey = "Messaging_ID", OtherKey = "ID", IsForeignKey = true)]
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
                        previousValue.Sale_Emps.Remove(this);
                    }
                    this._Messaging.Entity = value;
                    if ((value != null))
                    {
                        value.Sale_Emps.Add(this);
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

        private void attach_Transactions(Transaction entity)
        {
            this.SendPropertyChanging();
            entity.Sale_Emp = this;
        }

        private void detach_Transactions(Transaction entity)
        {
            this.SendPropertyChanging();
            entity.Sale_Emp = null;
        }
    }
}
