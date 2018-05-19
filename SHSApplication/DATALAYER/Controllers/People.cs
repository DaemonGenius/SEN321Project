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
    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.People")]
    public partial class People : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _ID;

        private string _FirstName;

        private string _LastName;

        private string _EmailAddress;

        private string _Password;

        private string _SSID;

        private string _DOB;

        private string _CellNumber;

        private System.Nullable<int> _Address_ID;

        private string _Department;

        private string _Gender;

        private EntitySet<Billinginfoe> _Billinginfoes;

        private EntityRef<Address> _Address;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
        partial void OnFirstNameChanging(string value);
        partial void OnFirstNameChanged();
        partial void OnLastNameChanging(string value);
        partial void OnLastNameChanged();
        partial void OnEmailAddressChanging(string value);
        partial void OnEmailAddressChanged();
        partial void OnPasswordChanging(string value);
        partial void OnPasswordChanged();
        partial void OnSSIDChanging(string value);
        partial void OnSSIDChanged();
        partial void OnDOBChanging(string value);
        partial void OnDOBChanged();
        partial void OnCellNumberChanging(string value);
        partial void OnCellNumberChanged();
        partial void OnAddress_IDChanging(System.Nullable<int> value);
        partial void OnAddress_IDChanged();
        partial void OnDepartmentChanging(string value);
        partial void OnDepartmentChanged();
        partial void OnGenderChanging(string value);
        partial void OnGenderChanged();
        #endregion

        public People()
        {
            this._Billinginfoes = new EntitySet<Billinginfoe>(new Action<Billinginfoe>(this.attach_Billinginfoes), new Action<Billinginfoe>(this.detach_Billinginfoes));
            this._Address = default(EntityRef<Address>);
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_FirstName", DbType = "NVarChar(MAX)")]
        public string FirstName
        {
            get
            {
                return this._FirstName;
            }
            set
            {
                if ((this._FirstName != value))
                {
                    this.OnFirstNameChanging(value);
                    this.SendPropertyChanging();
                    this._FirstName = value;
                    this.SendPropertyChanged("FirstName");
                    this.OnFirstNameChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_LastName", DbType = "NVarChar(MAX)")]
        public string LastName
        {
            get
            {
                return this._LastName;
            }
            set
            {
                if ((this._LastName != value))
                {
                    this.OnLastNameChanging(value);
                    this.SendPropertyChanging();
                    this._LastName = value;
                    this.SendPropertyChanged("LastName");
                    this.OnLastNameChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_EmailAddress", DbType = "NVarChar(MAX)")]
        public string EmailAddress
        {
            get
            {
                return this._EmailAddress;
            }
            set
            {
                if ((this._EmailAddress != value))
                {
                    this.OnEmailAddressChanging(value);
                    this.SendPropertyChanging();
                    this._EmailAddress = value;
                    this.SendPropertyChanged("EmailAddress");
                    this.OnEmailAddressChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Password", DbType = "NVarChar(MAX)")]
        public string Password
        {
            get
            {
                return this._Password;
            }
            set
            {
                if ((this._Password != value))
                {
                    this.OnPasswordChanging(value);
                    this.SendPropertyChanging();
                    this._Password = value;
                    this.SendPropertyChanged("Password");
                    this.OnPasswordChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_SSID", DbType = "NVarChar(MAX)")]
        public string SSID
        {
            get
            {
                return this._SSID;
            }
            set
            {
                if ((this._SSID != value))
                {
                    this.OnSSIDChanging(value);
                    this.SendPropertyChanging();
                    this._SSID = value;
                    this.SendPropertyChanged("SSID");
                    this.OnSSIDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_DOB", DbType = "NVarChar(MAX)")]
        public string DOB
        {
            get
            {
                return this._DOB;
            }
            set
            {
                if ((this._DOB != value))
                {
                    this.OnDOBChanging(value);
                    this.SendPropertyChanging();
                    this._DOB = value;
                    this.SendPropertyChanged("DOB");
                    this.OnDOBChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CellNumber", DbType = "NVarChar(MAX)")]
        public string CellNumber
        {
            get
            {
                return this._CellNumber;
            }
            set
            {
                if ((this._CellNumber != value))
                {
                    this.OnCellNumberChanging(value);
                    this.SendPropertyChanging();
                    this._CellNumber = value;
                    this.SendPropertyChanged("CellNumber");
                    this.OnCellNumberChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Address_ID", DbType = "Int")]
        public System.Nullable<int> Address_ID
        {
            get
            {
                return this._Address_ID;
            }
            set
            {
                if ((this._Address_ID != value))
                {
                    if (this._Address.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnAddress_IDChanging(value);
                    this.SendPropertyChanging();
                    this._Address_ID = value;
                    this.SendPropertyChanged("Address_ID");
                    this.OnAddress_IDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Department", DbType = "NVarChar(MAX)")]
        public string Department
        {
            get
            {
                return this._Department;
            }
            set
            {
                if ((this._Department != value))
                {
                    this.OnDepartmentChanging(value);
                    this.SendPropertyChanging();
                    this._Department = value;
                    this.SendPropertyChanged("Department");
                    this.OnDepartmentChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Gender", DbType = "NVarChar(MAX)")]
        public string Gender
        {
            get
            {
                return this._Gender;
            }
            set
            {
                if ((this._Gender != value))
                {
                    this.OnGenderChanging(value);
                    this.SendPropertyChanging();
                    this._Gender = value;
                    this.SendPropertyChanged("Gender");
                    this.OnGenderChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "People_Billinginfoe", Storage = "_Billinginfoes", ThisKey = "ID", OtherKey = "Person_ID")]
        public EntitySet<Billinginfoe> Billinginfoes
        {
            get
            {
                return this._Billinginfoes;
            }
            set
            {
                this._Billinginfoes.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Address_People", Storage = "_Address", ThisKey = "Address_ID", OtherKey = "ID", IsForeignKey = true)]
        public Address Address
        {
            get
            {
                return this._Address.Entity;
            }
            set
            {
                Address previousValue = this._Address.Entity;
                if (((previousValue != value)
                            || (this._Address.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Address.Entity = null;
                        previousValue.Peoples.Remove(this);
                    }
                    this._Address.Entity = value;
                    if ((value != null))
                    {
                        value.Peoples.Add(this);
                        this._Address_ID = value.ID;
                    }
                    else
                    {
                        this._Address_ID = default(Nullable<int>);
                    }
                    this.SendPropertyChanged("Address");
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

        private void attach_Billinginfoes(Billinginfoe entity)
        {
            this.SendPropertyChanging();
            entity.People = this;
        }

        private void detach_Billinginfoes(Billinginfoe entity)
        {
            this.SendPropertyChanging();
            entity.People = null;
        }
    }
}

