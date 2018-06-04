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
    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.Carts")]
    public partial class Cart : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _ID;

        private double _TotalPrice;

        private EntitySet<Transaction> _Transactions;

        private EntitySet<ProductSystem> _ProductSystems;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
        partial void OnTotalPriceChanging(double value);
        partial void OnTotalPriceChanged();
        #endregion

        public Cart()
        {
            this._Transactions = new EntitySet<Transaction>(new Action<Transaction>(this.attach_Transactions), new Action<Transaction>(this.detach_Transactions));
            this._ProductSystems = new EntitySet<ProductSystem>(new Action<ProductSystem>(this.attach_ProductSystems), new Action<ProductSystem>(this.detach_ProductSystems));
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_TotalPrice", DbType = "Float NOT NULL")]
        public double TotalPrice
        {
            get
            {
                return this._TotalPrice;
            }
            set
            {
                if ((this._TotalPrice != value))
                {
                    this.OnTotalPriceChanging(value);
                    this.SendPropertyChanging();
                    this._TotalPrice = value;
                    this.SendPropertyChanged("TotalPrice");
                    this.OnTotalPriceChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Cart_Transaction", Storage = "_Transactions", ThisKey = "ID", OtherKey = "Cart_ID")]
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

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Cart_ProductSystem", Storage = "_ProductSystems", ThisKey = "ID", OtherKey = "Cart_ID")]
        public EntitySet<ProductSystem> ProductSystems
        {
            get
            {
                return this._ProductSystems;
            }
            set
            {
                this._ProductSystems.Assign(value);
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
            entity.Cart = this;
        }

        private void detach_Transactions(Transaction entity)
        {
            this.SendPropertyChanging();
            entity.Cart = null;
        }

        private void attach_ProductSystems(ProductSystem entity)
        {
            this.SendPropertyChanging();
            entity.Cart = this;
        }

        private void detach_ProductSystems(ProductSystem entity)
        {
            this.SendPropertyChanging();
            entity.Cart = null;
        }
    }
}
