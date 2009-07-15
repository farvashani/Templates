﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Linq;

namespace Tracker.Core.Data
{
    /// <summary>
    /// The class representing the dbo.Status table.
    /// </summary>
    [System.Data.Linq.Mapping.Table(Name="dbo.Status")]
    [System.Runtime.Serialization.DataContract(IsReference = true)]
    [System.ComponentModel.DataAnnotations.ScaffoldTable(true)]
    [System.ComponentModel.DataAnnotations.MetadataType(typeof(Metadata))]
    [System.Data.Services.Common.DataServiceKey("Id")]
    [System.Diagnostics.DebuggerDisplay("Id: {Id}")]
    public partial class Status
        : LinqEntityBase, ICloneable
    {
        #region Static Constructor
        /// <summary>
        /// Initializes the <see cref="Status"/> class.
        /// </summary>
        static Status()
        {
            CodeSmith.Data.Rules.RuleManager.AddShared<Status>();
            AddSharedRules();
        }
        #endregion

        #region Default Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Status"/> class.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        public Status()
        {
            OnCreated();
            Initialize();
        }

        private void Initialize()
        {
            _taskList = new System.Data.Linq.EntitySet<Task>(OnTaskListAdd, OnTaskListRemove);
        }
        #endregion

        #region Column Mapped Properties

        private int _id = default(int);

        /// <summary>
        /// Gets the Id column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Id", Storage = "_id", DbType = "int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false, UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.Runtime.Serialization.DataMember(Order = 1)]
        public int Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    OnIdChanging(value);
                    SendPropertyChanging("Id");
                    _id = value;
                    SendPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }

        private string _name;

        /// <summary>
        /// Gets or sets the Name column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Name", Storage = "_name", DbType = "nvarchar(50) NOT NULL", CanBeNull = false, UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        [System.Runtime.Serialization.DataMember(Order = 2)]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    OnNameChanging(value);
                    SendPropertyChanging("Name");
                    _name = value;
                    SendPropertyChanged("Name");
                    OnNameChanged();
                }
            }
        }

        private string _description;

        /// <summary>
        /// Gets or sets the Description column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Description", Storage = "_description", DbType = "nvarchar(150)", UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.ComponentModel.DataAnnotations.StringLength(150)]
        [System.Runtime.Serialization.DataMember(Order = 3)]
        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    OnDescriptionChanging(value);
                    SendPropertyChanging("Description");
                    _description = value;
                    SendPropertyChanged("Description");
                    OnDescriptionChanged();
                }
            }
        }

        private int _order;

        /// <summary>
        /// Gets or sets the Order column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Order", Storage = "_order", DbType = "int NOT NULL", CanBeNull = false, UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.Runtime.Serialization.DataMember(Order = 4)]
        public int Order
        {
            get { return _order; }
            set
            {
                if (_order != value)
                {
                    OnOrderChanging(value);
                    SendPropertyChanging("Order");
                    _order = value;
                    SendPropertyChanged("Order");
                    OnOrderChanged();
                }
            }
        }

        private System.DateTime _createdDate;

        /// <summary>
        /// Gets or sets the CreatedDate column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "CreatedDate", Storage = "_createdDate", DbType = "datetime NOT NULL", CanBeNull = false, UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.Runtime.Serialization.DataMember(Order = 5)]
        public System.DateTime CreatedDate
        {
            get { return _createdDate; }
            set
            {
                if (_createdDate != value)
                {
                    OnCreatedDateChanging(value);
                    SendPropertyChanging("CreatedDate");
                    _createdDate = value;
                    SendPropertyChanged("CreatedDate");
                    OnCreatedDateChanged();
                }
            }
        }

        private System.DateTime _modifiedDate;

        /// <summary>
        /// Gets or sets the ModifiedDate column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "ModifiedDate", Storage = "_modifiedDate", DbType = "datetime NOT NULL", CanBeNull = false, UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.Runtime.Serialization.DataMember(Order = 6)]
        public System.DateTime ModifiedDate
        {
            get { return _modifiedDate; }
            set
            {
                if (_modifiedDate != value)
                {
                    OnModifiedDateChanging(value);
                    SendPropertyChanging("ModifiedDate");
                    _modifiedDate = value;
                    SendPropertyChanged("ModifiedDate");
                    OnModifiedDateChanged();
                }
            }
        }

        private System.Data.Linq.Binary _rowVersion = default(System.Data.Linq.Binary);

        /// <summary>
        /// Gets the RowVersion column value.
        /// </summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Data.Linq.Mapping.Column(Name = "RowVersion", Storage = "_rowVersion", DbType = "timestamp NOT NULL", IsDbGenerated = true, IsVersion = true, CanBeNull = false, UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.Runtime.Serialization.DataMember(Order = 7)]
        public System.Data.Linq.Binary RowVersion
        {
            get { return _rowVersion; }
            set
            {
                if (_rowVersion != value)
                {
                    OnRowVersionChanging(value);
                    SendPropertyChanging("RowVersion");
                    _rowVersion = value;
                    SendPropertyChanged("RowVersion");
                    OnRowVersionChanged();
                }
            }
        }
        #endregion

        #region Association Mapped Properties

        private System.Data.Linq.EntitySet<Task> _taskList;

        /// <summary>
        /// Gets or sets the Task association.
        /// </summary>
        [System.Data.Linq.Mapping.Association(Name = "Status_Task", Storage = "_taskList", ThisKey = "Id", OtherKey = "StatusId")]
        [System.Runtime.Serialization.DataMember(Order=8, EmitDefaultValue=false)]
        public System.Data.Linq.EntitySet<Task> TaskList
        {
            get { return (serializing && !_taskList.HasLoadedOrAssignedValues) ? null : _taskList; }
            set { _taskList.Assign(value); }
        }

        [System.Diagnostics.DebuggerNonUserCode]
        private void OnTaskListAdd(Task entity)
        {
            SendPropertyChanging(null);
            entity.Status = this;
            SendPropertyChanged(null);
        }

        [System.Diagnostics.DebuggerNonUserCode]
        private void OnTaskListRemove(Task entity)
        {
            SendPropertyChanging(null);
            entity.Status = null;
            SendPropertyChanged(null);
        }
        #endregion

        #region Extensibility Method Definitions
        /// <summary>Called by the static constructor to add shared rules.</summary>
        static partial void AddSharedRules();
        /// <summary>Called when this instance is loaded.</summary>
        partial void OnLoaded();
        /// <summary>Called when this instance is being saved.</summary>
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        /// <summary>Called when this instance is created.</summary>
        partial void OnCreated();
        /// <summary>Called when <see cref="Id"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnIdChanging(int value);
        /// <summary>Called after <see cref="Id"/> has Changed.</summary>
        partial void OnIdChanged();
        /// <summary>Called when <see cref="Name"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnNameChanging(string value);
        /// <summary>Called after <see cref="Name"/> has Changed.</summary>
        partial void OnNameChanged();
        /// <summary>Called when <see cref="Description"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnDescriptionChanging(string value);
        /// <summary>Called after <see cref="Description"/> has Changed.</summary>
        partial void OnDescriptionChanged();
        /// <summary>Called when <see cref="Order"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnOrderChanging(int value);
        /// <summary>Called after <see cref="Order"/> has Changed.</summary>
        partial void OnOrderChanged();
        /// <summary>Called when <see cref="CreatedDate"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnCreatedDateChanging(System.DateTime value);
        /// <summary>Called after <see cref="CreatedDate"/> has Changed.</summary>
        partial void OnCreatedDateChanged();
        /// <summary>Called when <see cref="ModifiedDate"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnModifiedDateChanging(System.DateTime value);
        /// <summary>Called after <see cref="ModifiedDate"/> has Changed.</summary>
        partial void OnModifiedDateChanged();
        /// <summary>Called when <see cref="RowVersion"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnRowVersionChanging(System.Data.Linq.Binary value);
        /// <summary>Called after <see cref="RowVersion"/> has Changed.</summary>
        partial void OnRowVersionChanged();

        #endregion

        #region Serialization
        private bool serializing;

        /// <summary>
        /// Called when serializing.
        /// </summary>
        /// <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        [System.Runtime.Serialization.OnSerializing]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public void OnSerializing(System.Runtime.Serialization.StreamingContext context) {
            serializing = true;
        }

        /// <summary>
        /// Called when serialized.
        /// </summary>
        /// <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        [System.Runtime.Serialization.OnSerialized]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public void OnSerialized(System.Runtime.Serialization.StreamingContext context) {
            serializing = false;
        }

        /// <summary>
        /// Called when deserializing.
        /// </summary>
        /// <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        [System.Runtime.Serialization.OnDeserializing]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public void OnDeserializing(System.Runtime.Serialization.StreamingContext context) {
            Initialize();
        }
        #endregion

        #region Clone
        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>
        /// A new object that is a copy of this instance.
        /// </returns>
        object ICloneable.Clone()
        {
            var serializer = new System.Runtime.Serialization.DataContractSerializer(GetType());
            using (var ms = new System.IO.MemoryStream())
            {
                serializer.WriteObject(ms, this);
                ms.Position = 0;
                return serializer.ReadObject(ms);
            }
        }

        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>
        /// A new object that is a copy of this instance.
        /// </returns>
        /// <remarks>
        /// Only loaded <see cref="T:System.Data.Linq.EntityRef`1"/> and <see cref="T:System.Data.Linq.EntitySet`1" /> child accessions will be cloned.
        /// </remarks>
        public Status Clone()
        {
            return (Status)((ICloneable)this).Clone();
        }
        #endregion

        #region Detach Methods
        /// <summary>
        /// Detach this instance from the <see cref="System.Data.Linq.DataContext"/>.
        /// </summary>
        /// <remarks>
        /// Detaching the entity will stop all lazy loading and allow it to be added to another <see cref="System.Data.Linq.DataContext"/>.
        /// </remarks>
        public override void Detach()
        {
            if (!IsAttached())
                return;

            base.Detach();
            _taskList = Detach(_taskList, OnTaskListAdd, OnTaskListRemove);
        }
        #endregion
    }
}

