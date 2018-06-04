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
    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.Messagings")]
    public partial class Messaging : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _ID;

        private string _subject;

        private string _Sender;

        private string _Receiver;

        private string _Msg;

        private System.DateTime _Log;

        private EntitySet<Admin> _Admins;

        private EntitySet<Client> _Clients;

        private EntitySet<TechnicianEmp> _TechnicianEmps;

        private EntitySet<Sale_Emp> _Sale_Emps;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
        partial void OnsubjectChanging(string value);
        partial void OnsubjectChanged();
        partial void OnSenderChanging(string value);
        partial void OnSenderChanged();
        partial void OnReceiverChanging(string value);
        partial void OnReceiverChanged();
        partial void OnMsgChanging(string value);
        partial void OnMsgChanged();
        partial void OnLogChanging(System.DateTime value);
        partial void OnLogChanged();
        #endregion

        public Messaging()
        {
            this._Admins = new EntitySet<Admin>(new Action<Admin>(this.attach_Admins), new Action<Admin>(this.detach_Admins));
            this._Clients = new EntitySet<Client>(new Action<Client>(this.attach_Clients), new Action<Client>(this.detach_Clients));
            this._TechnicianEmps = new EntitySet<TechnicianEmp>(new Action<TechnicianEmp>(this.attach_TechnicianEmps), new Action<TechnicianEmp>(this.detach_TechnicianEmps));
            this._Sale_Emps = new EntitySet<Sale_Emp>(new Action<Sale_Emp>(this.attach_Sale_Emps), new Action<Sale_Emp>(this.detach_Sale_Emps));
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_subject", DbType = "NVarChar(MAX)")]
        public string subject
        {
            get
            {
                return this._subject;
            }
            set
            {
                if ((this._subject != value))
                {
                    this.OnsubjectChanging(value);
                    this.SendPropertyChanging();
                    this._subject = value;
                    this.SendPropertyChanged("subject");
                    this.OnsubjectChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Sender", DbType = "NVarChar(MAX)")]
        public string Sender
        {
            get
            {
                return this._Sender;
            }
            set
            {
                if ((this._Sender != value))
                {
                    this.OnSenderChanging(value);
                    this.SendPropertyChanging();
                    this._Sender = value;
                    this.SendPropertyChanged("Sender");
                    this.OnSenderChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Receiver", DbType = "NVarChar(MAX)")]
        public string Receiver
        {
            get
            {
                return this._Receiver;
            }
            set
            {
                if ((this._Receiver != value))
                {
                    this.OnReceiverChanging(value);
                    this.SendPropertyChanging();
                    this._Receiver = value;
                    this.SendPropertyChanged("Receiver");
                    this.OnReceiverChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Msg", DbType = "NVarChar(MAX)")]
        public string Msg
        {
            get
            {
                return this._Msg;
            }
            set
            {
                if ((this._Msg != value))
                {
                    this.OnMsgChanging(value);
                    this.SendPropertyChanging();
                    this._Msg = value;
                    this.SendPropertyChanged("Msg");
                    this.OnMsgChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Name = "[Log]", Storage = "_Log", DbType = "DateTime NOT NULL")]
        public System.DateTime Log
        {
            get
            {
                return this._Log;
            }
            set
            {
                if ((this._Log != value))
                {
                    this.OnLogChanging(value);
                    this.SendPropertyChanging();
                    this._Log = value;
                    this.SendPropertyChanged("Log");
                    this.OnLogChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Messaging_Admin", Storage = "_Admins", ThisKey = "ID", OtherKey = "Messaging_ID")]
        public EntitySet<Admin> Admins
        {
            get
            {
                return this._Admins;
            }
            set
            {
                this._Admins.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Messaging_Client", Storage = "_Clients", ThisKey = "ID", OtherKey = "Messaging_ID")]
        public EntitySet<Client> Clients
        {
            get
            {
                return this._Clients;
            }
            set
            {
                this._Clients.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Messaging_TechnicianEmp", Storage = "_TechnicianEmps", ThisKey = "ID", OtherKey = "Messaging_ID")]
        public EntitySet<TechnicianEmp> TechnicianEmps
        {
            get
            {
                return this._TechnicianEmps;
            }
            set
            {
                this._TechnicianEmps.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Messaging_Sale_Emp", Storage = "_Sale_Emps", ThisKey = "ID", OtherKey = "Messaging_ID")]
        public EntitySet<Sale_Emp> Sale_Emps
        {
            get
            {
                return this._Sale_Emps;
            }
            set
            {
                this._Sale_Emps.Assign(value);
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

        private void attach_Admins(Admin entity)
        {
            this.SendPropertyChanging();
            entity.Messaging = this;
        }

        private void detach_Admins(Admin entity)
        {
            this.SendPropertyChanging();
            entity.Messaging = null;
        }

        private void attach_Clients(Client entity)
        {
            this.SendPropertyChanging();
            entity.Messaging = this;
        }

        private void detach_Clients(Client entity)
        {
            this.SendPropertyChanging();
            entity.Messaging = null;
        }

        private void attach_TechnicianEmps(TechnicianEmp entity)
        {
            this.SendPropertyChanging();
            entity.Messaging = this;
        }

        private void detach_TechnicianEmps(TechnicianEmp entity)
        {
            this.SendPropertyChanging();
            entity.Messaging = null;
        }

        private void attach_Sale_Emps(Sale_Emp entity)
        {
            this.SendPropertyChanging();
            entity.Messaging = this;
        }

        private void detach_Sale_Emps(Sale_Emp entity)
        {
            this.SendPropertyChanging();
            entity.Messaging = null;
        }
    }
}
