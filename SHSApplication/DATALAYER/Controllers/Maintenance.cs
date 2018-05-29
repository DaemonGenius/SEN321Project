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

        private string _Name;

        private System.Nullable<int> _Client_ID;

        private System.Nullable<int> _ProductSystems_ID;

        private System.Nullable<int> _TechnicianEmp_ID;

        private System.Nullable<int> _Contract_ID;

        private System.DateTime _DateStart;

        private System.DateTime _DateEnd;

        private EntityRef<Client> _Client;

        private EntityRef<Contract> _Contract;

        private EntityRef<ProductSystem> _ProductSystem;

        private EntityRef<TechnicianEmp> _TechnicianEmp;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        partial void OnClient_IDChanging(System.Nullable<int> value);
        partial void OnClient_IDChanged();
        partial void OnProductSystems_IDChanging(System.Nullable<int> value);
        partial void OnProductSystems_IDChanged();
        partial void OnTechnicianEmp_IDChanging(System.Nullable<int> value);
        partial void OnTechnicianEmp_IDChanged();
        partial void OnContract_IDChanging(System.Nullable<int> value);
        partial void OnContract_IDChanged();
        partial void OnDateStartChanging(System.DateTime value);
        partial void OnDateStartChanged();
        partial void OnDateEndChanging(System.DateTime value);
        partial void OnDateEndChanged();
        #endregion

        public Maintenance()
        {
            this._Client = default(EntityRef<Client>);
            this._Contract = default(EntityRef<Contract>);
            this._ProductSystem = default(EntityRef<ProductSystem>);
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Client_ID", DbType = "Int")]
        public System.Nullable<int> Client_ID
        {
            get
            {
                return this._Client_ID;
            }
            set
            {
                if ((this._Client_ID != value))
                {
                    if (this._Client.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnClient_IDChanging(value);
                    this.SendPropertyChanging();
                    this._Client_ID = value;
                    this.SendPropertyChanged("Client_ID");
                    this.OnClient_IDChanged();
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_DateStart", DbType = "DateTime NOT NULL")]
        public System.DateTime DateStart
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_DateEnd", DbType = "DateTime NOT NULL")]
        public System.DateTime DateEnd
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

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Client_Maintenance", Storage = "_Client", ThisKey = "Client_ID", OtherKey = "ID", IsForeignKey = true)]
        public Client Client
        {
            get
            {
                return this._Client.Entity;
            }
            set
            {
                Client previousValue = this._Client.Entity;
                if (((previousValue != value)
                            || (this._Client.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Client.Entity = null;
                        previousValue.Maintenances.Remove(this);
                    }
                    this._Client.Entity = value;
                    if ((value != null))
                    {
                        value.Maintenances.Add(this);
                        this._Client_ID = value.ID;
                    }
                    else
                    {
                        this._Client_ID = default(Nullable<int>);
                    }
                    this.SendPropertyChanged("Client");
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

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "ProductSystem_Maintenance", Storage = "_ProductSystem", ThisKey = "ProductSystems_ID", OtherKey = "ID", IsForeignKey = true)]
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
                        previousValue.Maintenances.Remove(this);
                    }
                    this._ProductSystem.Entity = value;
                    if ((value != null))
                    {
                        value.Maintenances.Add(this);
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

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "TechnicianEmp_Maintenance", Storage = "_TechnicianEmp", ThisKey = "TechnicianEmp_ID", OtherKey = "ID", IsForeignKey = true)]
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
                        previousValue.Maintenances.Remove(this);
                    }
                    this._TechnicianEmp.Entity = value;
                    if ((value != null))
                    {
                        value.Maintenances.Add(this);
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
