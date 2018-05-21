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
    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.Transactions")]
    public partial class Transaction : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _ID;

        private System.Nullable<int> _Cart_ID;

        private System.Nullable<int> _Client_ID;

        private System.Nullable<int> _Contract_ID;

        private System.Nullable<int> _SaleEmp_ID;

        private System.Nullable<int> _TechnicianEmp_ID;

        private EntityRef<Client> _Client;

        private EntityRef<Contract> _Contract;

        private EntityRef<Sale_Emp> _Sale_Emp;

        private EntityRef<TechnicianEmp> _TechnicianEmp;

        private EntityRef<Cart> _Cart;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
        partial void OnCart_IDChanging(System.Nullable<int> value);
        partial void OnCart_IDChanged();
        partial void OnClient_IDChanging(System.Nullable<int> value);
        partial void OnClient_IDChanged();
        partial void OnContract_IDChanging(System.Nullable<int> value);
        partial void OnContract_IDChanged();
        partial void OnSaleEmp_IDChanging(System.Nullable<int> value);
        partial void OnSaleEmp_IDChanged();
        partial void OnTechnicianEmp_IDChanging(System.Nullable<int> value);
        partial void OnTechnicianEmp_IDChanged();
        #endregion

        public Transaction()
        {
            this._Client = default(EntityRef<Client>);
            this._Contract = default(EntityRef<Contract>);
            this._Sale_Emp = default(EntityRef<Sale_Emp>);
            this._TechnicianEmp = default(EntityRef<TechnicianEmp>);
            this._Cart = default(EntityRef<Cart>);
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Cart_ID", DbType = "Int")]
        public System.Nullable<int> Cart_ID
        {
            get
            {
                return this._Cart_ID;
            }
            set
            {
                if ((this._Cart_ID != value))
                {
                    if (this._Cart.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnCart_IDChanging(value);
                    this.SendPropertyChanging();
                    this._Cart_ID = value;
                    this.SendPropertyChanged("Cart_ID");
                    this.OnCart_IDChanged();
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_SaleEmp_ID", DbType = "Int")]
        public System.Nullable<int> SaleEmp_ID
        {
            get
            {
                return this._SaleEmp_ID;
            }
            set
            {
                if ((this._SaleEmp_ID != value))
                {
                    if (this._Sale_Emp.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnSaleEmp_IDChanging(value);
                    this.SendPropertyChanging();
                    this._SaleEmp_ID = value;
                    this.SendPropertyChanged("SaleEmp_ID");
                    this.OnSaleEmp_IDChanged();
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

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Client_Transaction", Storage = "_Client", ThisKey = "Client_ID", OtherKey = "ID", IsForeignKey = true)]
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
                        previousValue.Transactions.Remove(this);
                    }
                    this._Client.Entity = value;
                    if ((value != null))
                    {
                        value.Transactions.Add(this);
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

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Contract_Transaction", Storage = "_Contract", ThisKey = "Contract_ID", OtherKey = "ID", IsForeignKey = true)]
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
                        previousValue.Transactions.Remove(this);
                    }
                    this._Contract.Entity = value;
                    if ((value != null))
                    {
                        value.Transactions.Add(this);
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

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Sale_Emp_Transaction", Storage = "_Sale_Emp", ThisKey = "SaleEmp_ID", OtherKey = "ID", IsForeignKey = true)]
        public Sale_Emp Sale_Emp
        {
            get
            {
                return this._Sale_Emp.Entity;
            }
            set
            {
                Sale_Emp previousValue = this._Sale_Emp.Entity;
                if (((previousValue != value)
                            || (this._Sale_Emp.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Sale_Emp.Entity = null;
                        previousValue.Transactions.Remove(this);
                    }
                    this._Sale_Emp.Entity = value;
                    if ((value != null))
                    {
                        value.Transactions.Add(this);
                        this._SaleEmp_ID = value.ID;
                    }
                    else
                    {
                        this._SaleEmp_ID = default(Nullable<int>);
                    }
                    this.SendPropertyChanged("Sale_Emp");
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "TechnicianEmp_Transaction", Storage = "_TechnicianEmp", ThisKey = "TechnicianEmp_ID", OtherKey = "ID", IsForeignKey = true)]
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
                        previousValue.Transactions.Remove(this);
                    }
                    this._TechnicianEmp.Entity = value;
                    if ((value != null))
                    {
                        value.Transactions.Add(this);
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

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Cart_Transaction", Storage = "_Cart", ThisKey = "Cart_ID", OtherKey = "ID", IsForeignKey = true)]
        public Cart Cart
        {
            get
            {
                return this._Cart.Entity;
            }
            set
            {
                Cart previousValue = this._Cart.Entity;
                if (((previousValue != value)
                            || (this._Cart.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Cart.Entity = null;
                        previousValue.Transactions.Remove(this);
                    }
                    this._Cart.Entity = value;
                    if ((value != null))
                    {
                        value.Transactions.Add(this);
                        this._Cart_ID = value.ID;
                    }
                    else
                    {
                        this._Cart_ID = default(Nullable<int>);
                    }
                    this.SendPropertyChanged("Cart");
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
