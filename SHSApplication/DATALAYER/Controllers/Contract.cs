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
    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.Contracts")]
    public partial class Contract : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _ID;

        private string _ContractName;

        private string _Discription;

        private System.DateTime _DateExpire;

        private string _Date;

        private EntitySet<Maintenance> _Maintenances;

        private EntitySet<Transaction> _Transactions;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
        partial void OnContractNameChanging(string value);
        partial void OnContractNameChanged();
        partial void OnDiscriptionChanging(string value);
        partial void OnDiscriptionChanged();
        partial void OnDateExpireChanging(System.DateTime value);
        partial void OnDateExpireChanged();
        partial void OnDateChanging(string value);
        partial void OnDateChanged();
        #endregion

        public Contract()
        {
            this._Maintenances = new EntitySet<Maintenance>(new Action<Maintenance>(this.attach_Maintenances), new Action<Maintenance>(this.detach_Maintenances));
            this._Transactions = new EntitySet<Transaction>(new Action<Transaction>(this.attach_Transactions), new Action<Transaction>(this.detach_Transactions));
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ContractName", DbType = "NVarChar(MAX)")]
        public string ContractName
        {
            get
            {
                return this._ContractName;
            }
            set
            {
                if ((this._ContractName != value))
                {
                    this.OnContractNameChanging(value);
                    this.SendPropertyChanging();
                    this._ContractName = value;
                    this.SendPropertyChanged("ContractName");
                    this.OnContractNameChanged();
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_DateExpire", DbType = "DateTime NOT NULL")]
        public System.DateTime DateExpire
        {
            get
            {
                return this._DateExpire;
            }
            set
            {
                if ((this._DateExpire != value))
                {
                    this.OnDateExpireChanging(value);
                    this.SendPropertyChanging();
                    this._DateExpire = value;
                    this.SendPropertyChanged("DateExpire");
                    this.OnDateExpireChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Date", DbType = "NVarChar(MAX)")]
        public string Date
        {
            get
            {
                return this._Date;
            }
            set
            {
                if ((this._Date != value))
                {
                    this.OnDateChanging(value);
                    this.SendPropertyChanging();
                    this._Date = value;
                    this.SendPropertyChanged("Date");
                    this.OnDateChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Contract_Maintenance", Storage = "_Maintenances", ThisKey = "ID", OtherKey = "Contract_ID")]
        public EntitySet<Maintenance> Maintenances
        {
            get
            {
                return this._Maintenances;
            }
            set
            {
                this._Maintenances.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Contract_Transaction", Storage = "_Transactions", ThisKey = "ID", OtherKey = "Contract_ID")]
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

        private void attach_Maintenances(Maintenance entity)
        {
            this.SendPropertyChanging();
            entity.Contract = this;
        }

        private void detach_Maintenances(Maintenance entity)
        {
            this.SendPropertyChanging();
            entity.Contract = null;
        }

        private void attach_Transactions(Transaction entity)
        {
            this.SendPropertyChanging();
            entity.Contract = this;
        }

        private void detach_Transactions(Transaction entity)
        {
            this.SendPropertyChanging();
            entity.Contract = null;
        }
    }
}
