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
    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.Billinginfoes")]
    public partial class Billinginfoe : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _ID;

        private string _CardName;

        private string _CardNum;

        private string _CardCVV;

        private string _CardExpireDate;

        private string _CardType;

        private System.Nullable<int> _Person_ID;

        private EntityRef<People> _People;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
        partial void OnCardNameChanging(string value);
        partial void OnCardNameChanged();
        partial void OnCardNumChanging(string value);
        partial void OnCardNumChanged();
        partial void OnCardCVVChanging(string value);
        partial void OnCardCVVChanged();
        partial void OnCardExpireDateChanging(string value);
        partial void OnCardExpireDateChanged();
        partial void OnCardTypeChanging(string value);
        partial void OnCardTypeChanged();
        partial void OnPerson_IDChanging(System.Nullable<int> value);
        partial void OnPerson_IDChanged();
        #endregion

        public Billinginfoe()
        {
            this._People = default(EntityRef<People>);
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CardName", DbType = "NVarChar(MAX)")]
        public string CardName
        {
            get
            {
                return this._CardName;
            }
            set
            {
                if ((this._CardName != value))
                {
                    this.OnCardNameChanging(value);
                    this.SendPropertyChanging();
                    this._CardName = value;
                    this.SendPropertyChanged("CardName");
                    this.OnCardNameChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CardNum", DbType = "NVarChar(MAX)")]
        public string CardNum
        {
            get
            {
                return this._CardNum;
            }
            set
            {
                if ((this._CardNum != value))
                {
                    this.OnCardNumChanging(value);
                    this.SendPropertyChanging();
                    this._CardNum = value;
                    this.SendPropertyChanged("CardNum");
                    this.OnCardNumChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CardCVV", DbType = "NVarChar(MAX)")]
        public string CardCVV
        {
            get
            {
                return this._CardCVV;
            }
            set
            {
                if ((this._CardCVV != value))
                {
                    this.OnCardCVVChanging(value);
                    this.SendPropertyChanging();
                    this._CardCVV = value;
                    this.SendPropertyChanged("CardCVV");
                    this.OnCardCVVChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CardExpireDate", DbType = "NVarChar(MAX)")]
        public string CardExpireDate
        {
            get
            {
                return this._CardExpireDate;
            }
            set
            {
                if ((this._CardExpireDate != value))
                {
                    this.OnCardExpireDateChanging(value);
                    this.SendPropertyChanging();
                    this._CardExpireDate = value;
                    this.SendPropertyChanged("CardExpireDate");
                    this.OnCardExpireDateChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CardType", DbType = "NVarChar(MAX)")]
        public string CardType
        {
            get
            {
                return this._CardType;
            }
            set
            {
                if ((this._CardType != value))
                {
                    this.OnCardTypeChanging(value);
                    this.SendPropertyChanging();
                    this._CardType = value;
                    this.SendPropertyChanged("CardType");
                    this.OnCardTypeChanged();
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

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "People_Billinginfoe", Storage = "_People", ThisKey = "Person_ID", OtherKey = "ID", IsForeignKey = true)]
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
                        previousValue.Billinginfoes.Remove(this);
                    }
                    this._People.Entity = value;
                    if ((value != null))
                    {
                        value.Billinginfoes.Add(this);
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
