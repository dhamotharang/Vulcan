﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using LinqConnect template.
// Code is generated on: 9/19/2017 10:27:27 AM
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using Devart.Data.Linq;
using Devart.Data.Linq.Mapping;
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Linq.Expressions;

namespace Vulcan.IMetal.Context.Orders
{

    /// <summary>
    /// There are no comments for Vulcan.IMetal.Context.Orders.SalesChargeType in the schema.
    /// </summary>
    [Table(Name = @"public.sales_charge_types")]
    public partial class SalesChargeType : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);
        #pragma warning disable 0649

        private int _Id;

        private System.Nullable<int> _Version;

        private System.Nullable<System.DateTime> _Cdate;

        private System.Nullable<int> _CuserId;

        private System.Nullable<System.DateTime> _Mdate;

        private System.Nullable<int> _MuserId;

        private string _Status;

        private string _Code;

        private string _Description;
        #pragma warning restore 0649

        private EntitySet<SalesCharge> _SalesCharge;
    
        #region Extensibility Method Definitions

        partial void OnLoaded();
        partial void OnValidate(ChangeAction action);
        partial void OnCreated();
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        partial void OnVersionChanging(System.Nullable<int> value);
        partial void OnVersionChanged();
        partial void OnCdateChanging(System.Nullable<System.DateTime> value);
        partial void OnCdateChanged();
        partial void OnCuserIdChanging(System.Nullable<int> value);
        partial void OnCuserIdChanged();
        partial void OnMdateChanging(System.Nullable<System.DateTime> value);
        partial void OnMdateChanged();
        partial void OnMuserIdChanging(System.Nullable<int> value);
        partial void OnMuserIdChanged();
        partial void OnStatusChanging(string value);
        partial void OnStatusChanged();
        partial void OnCodeChanging(string value);
        partial void OnCodeChanged();
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        #endregion

        public SalesChargeType()
        {
            this._SalesCharge = new EntitySet<SalesCharge>(new Action<SalesCharge>(this.attach_SalesCharge), new Action<SalesCharge>(this.detach_SalesCharge));
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for Id in the schema.
        /// </summary>
        [Column(Name = @"id", Storage = "_Id", AutoSync = AutoSync.OnInsert, CanBeNull = false, DbType = "SERIAL NOT NULL", IsDbGenerated = true, IsPrimaryKey = true)]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                if (this._Id != value)
                {
                    this.OnIdChanging(value);
                    this.SendPropertyChanging("Id");
                    this._Id = value;
                    this.SendPropertyChanged("Id");
                    this.OnIdChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Version in the schema.
        /// </summary>
        [Column(Name = @"""version""", Storage = "_Version", DbType = "INT4", UpdateCheck = UpdateCheck.Never)]
        public System.Nullable<int> Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                if (this._Version != value)
                {
                    this.OnVersionChanging(value);
                    this.SendPropertyChanging("Version");
                    this._Version = value;
                    this.SendPropertyChanged("Version");
                    this.OnVersionChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Cdate in the schema.
        /// </summary>
        [Column(Name = @"cdate", Storage = "_Cdate", DbType = "TIMESTAMPTZ", UpdateCheck = UpdateCheck.Never)]
        public System.Nullable<System.DateTime> Cdate
        {
            get
            {
                return this._Cdate;
            }
            set
            {
                if (this._Cdate != value)
                {
                    this.OnCdateChanging(value);
                    this.SendPropertyChanging("Cdate");
                    this._Cdate = value;
                    this.SendPropertyChanged("Cdate");
                    this.OnCdateChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for CuserId in the schema.
        /// </summary>
        [Column(Name = @"cuser_id", Storage = "_CuserId", DbType = "INT4", UpdateCheck = UpdateCheck.Never)]
        public System.Nullable<int> CuserId
        {
            get
            {
                return this._CuserId;
            }
            set
            {
                if (this._CuserId != value)
                {
                    this.OnCuserIdChanging(value);
                    this.SendPropertyChanging("CuserId");
                    this._CuserId = value;
                    this.SendPropertyChanged("CuserId");
                    this.OnCuserIdChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Mdate in the schema.
        /// </summary>
        [Column(Name = @"mdate", Storage = "_Mdate", DbType = "TIMESTAMPTZ", UpdateCheck = UpdateCheck.Never)]
        public System.Nullable<System.DateTime> Mdate
        {
            get
            {
                return this._Mdate;
            }
            set
            {
                if (this._Mdate != value)
                {
                    this.OnMdateChanging(value);
                    this.SendPropertyChanging("Mdate");
                    this._Mdate = value;
                    this.SendPropertyChanged("Mdate");
                    this.OnMdateChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for MuserId in the schema.
        /// </summary>
        [Column(Name = @"muser_id", Storage = "_MuserId", DbType = "INT4", UpdateCheck = UpdateCheck.Never)]
        public System.Nullable<int> MuserId
        {
            get
            {
                return this._MuserId;
            }
            set
            {
                if (this._MuserId != value)
                {
                    this.OnMuserIdChanging(value);
                    this.SendPropertyChanging("MuserId");
                    this._MuserId = value;
                    this.SendPropertyChanged("MuserId");
                    this.OnMuserIdChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Status in the schema.
        /// </summary>
        [Column(Name = @"status", Storage = "_Status", DbType = "CHAR(1)", UpdateCheck = UpdateCheck.Never)]
        public string Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                if (this._Status != value)
                {
                    this.OnStatusChanging(value);
                    this.SendPropertyChanging("Status");
                    this._Status = value;
                    this.SendPropertyChanged("Status");
                    this.OnStatusChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Code in the schema.
        /// </summary>
        [Column(Name = @"code", Storage = "_Code", DbType = "VARCHAR(3)", UpdateCheck = UpdateCheck.Never)]
        public string Code
        {
            get
            {
                return this._Code;
            }
            set
            {
                if (this._Code != value)
                {
                    this.OnCodeChanging(value);
                    this.SendPropertyChanging("Code");
                    this._Code = value;
                    this.SendPropertyChanged("Code");
                    this.OnCodeChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Description in the schema.
        /// </summary>
        [Column(Name = @"description", Storage = "_Description", DbType = "VARCHAR(255)", UpdateCheck = UpdateCheck.Never)]
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                if (this._Description != value)
                {
                    this.OnDescriptionChanging(value);
                    this.SendPropertyChanging("Description");
                    this._Description = value;
                    this.SendPropertyChanged("Description");
                    this.OnDescriptionChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for SalesCharge in the schema.
        /// </summary>
        [Devart.Data.Linq.Mapping.Association(Name="SalesChargeType_SalesCharge", Storage="_SalesCharge", ThisKey="Id", OtherKey="SalesChargeTypeId", DeleteRule="NO ACTION")]
        public EntitySet<SalesCharge> SalesCharge
        {
            get
            {
                return this._SalesCharge;
            }
            set
            {
                this._SalesCharge.Assign(value);
            }
        }
   
        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
		        var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanging(System.String propertyName) 
        {    
		        var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, new PropertyChangingEventArgs(propertyName));
        }

        protected virtual void SendPropertyChanged(System.String propertyName)
        {    
		        var handler = this.PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        private void attach_SalesCharge(SalesCharge entity)
        {
            this.SendPropertyChanging("SalesCharge");
            entity.SalesChargeType = this;
        }
    
        private void detach_SalesCharge(SalesCharge entity)
        {
            this.SendPropertyChanging("SalesCharge");
            entity.SalesChargeType = null;
        }
    }

}