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
    /// The class representing the dbo.Audit table.
    /// </summary>
    [System.Data.Linq.Mapping.Table(Name="dbo.Audit")]
    [System.Runtime.Serialization.DataContract(IsReference = true)]
    [System.ComponentModel.DataAnnotations.ScaffoldTable(true)]
    [System.ComponentModel.DataAnnotations.MetadataType(typeof(Metadata))]
    [System.Data.Services.Common.DataServiceKey("Id")]
    [System.Diagnostics.DebuggerDisplay("Id: {Id}")]
    public partial class Audit
        : LinqEntityBase, ICloneable, Tracker.Core.Data.Interfaces.IAudit  
    {
        #region Static Constructor
        /// <summary>
        /// Initializes the <see cref="Audit"/> class.
        /// </summary>
        static Audit()
        {
            AddSharedRules();
        }
        #endregion

        #region Default Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Audit"/> class.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        public Audit()
        {
            Initialize();
        }

        private void Initialize()
        {
            _task = default(System.Data.Linq.EntityRef<Task>);
            _user = default(System.Data.Linq.EntityRef<User>);
            OnCreated();
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

        private System.DateTime _createdDate;

        /// <summary>
        /// Gets or sets the CreatedDate column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "CreatedDate", Storage = "_createdDate", DbType = "datetime NOT NULL", CanBeNull = false, UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.Runtime.Serialization.DataMember(Order = 2)]
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

        private System.DateTime _date;

        /// <summary>
        /// Gets or sets the Date column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Date", Storage = "_date", DbType = "datetime NOT NULL", CanBeNull = false, UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.Runtime.Serialization.DataMember(Order = 3)]
        public System.DateTime Date
        {
            get { return _date; }
            set
            {
                if (_date != value)
                {
                    OnDateChanging(value);
                    SendPropertyChanging("Date");
                    _date = value;
                    SendPropertyChanged("Date");
                    OnDateChanged();
                }
            }
        }

        private string _username;

        /// <summary>
        /// Gets or sets the Username column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Username", Storage = "_username", DbType = "nvarchar(50) NOT NULL", CanBeNull = false, UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        [System.Runtime.Serialization.DataMember(Order = 4)]
        public string Username
        {
            get { return _username; }
            set
            {
                if (_username != value)
                {
                    OnUsernameChanging(value);
                    SendPropertyChanging("Username");
                    _username = value;
                    SendPropertyChanged("Username");
                    OnUsernameChanged();
                }
            }
        }

        private string _content;

        /// <summary>
        /// Gets or sets the Content column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Content", Storage = "_content", DbType = "varchar(MAX) NOT NULL", CanBeNull = false, UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.Runtime.Serialization.DataMember(Order = 5)]
        public string Content
        {
            get { return _content; }
            set
            {
                if (_content != value)
                {
                    OnContentChanging(value);
                    SendPropertyChanging("Content");
                    _content = value;
                    SendPropertyChanged("Content");
                    OnContentChanged();
                }
            }
        }

        private System.Data.Linq.Binary _rowVersion = default(System.Data.Linq.Binary);

        /// <summary>
        /// Gets the RowVersion column value.
        /// </summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Data.Linq.Mapping.Column(Name = "RowVersion", Storage = "_rowVersion", DbType = "timestamp NOT NULL", IsDbGenerated = true, IsVersion = true, CanBeNull = false, UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.Runtime.Serialization.DataMember(Order = 6)]
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

        private Nullable<int> _userId;

        /// <summary>
        /// Gets or sets the UserId column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "UserId", Storage = "_userId", DbType = "int", UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.Runtime.Serialization.DataMember(Order = 7)]
        public Nullable<int> UserId
        {
            get { return _userId; }
            set
            {
                if (_userId != value)
                {
                    if (_user.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    OnUserIdChanging(value);
                    SendPropertyChanging("UserId");
                    _userId = value;
                    SendPropertyChanged("UserId");
                    OnUserIdChanged();
                }
            }
        }

        private Nullable<int> _taskId;

        /// <summary>
        /// Gets or sets the TaskId column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "TaskId", Storage = "_taskId", DbType = "int", UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.Runtime.Serialization.DataMember(Order = 8)]
        public Nullable<int> TaskId
        {
            get { return _taskId; }
            set
            {
                if (_taskId != value)
                {
                    if (_task.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    OnTaskIdChanging(value);
                    SendPropertyChanging("TaskId");
                    _taskId = value;
                    SendPropertyChanged("TaskId");
                    OnTaskIdChanged();
                }
            }
        }

        private string _myxml;

        /// <summary>
        /// Gets or sets the myxml column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "myxml", Storage = "_myxml", DbType = "xml", UpdateCheck = System.Data.Linq.Mapping.UpdateCheck.Never)]
        [System.Runtime.Serialization.DataMember(Order = 9)]
        public string Myxml
        {
            get { return _myxml; }
            set
            {
                if (_myxml != value)
                {
                    OnMyxmlChanging(value);
                    SendPropertyChanging("Myxml");
                    _myxml = value;
                    SendPropertyChanged("Myxml");
                    OnMyxmlChanged();
                }
            }
        }
        #endregion

        #region Association Mapped Properties

        private System.Data.Linq.EntityRef<Task> _task;

        /// <summary>
        /// Gets or sets the <see cref="Task"/> association.
        /// </summary>
        [System.Data.Linq.Mapping.Association(Name = "Task_Audit", Storage = "_task", ThisKey = "TaskId", OtherKey = "Id", IsUnique = true, IsForeignKey = true)]
        [System.Runtime.Serialization.DataMember(Order = 10, EmitDefaultValue = false)]
        public Task Task
        {
            get { return (serializing && !_task.HasLoadedOrAssignedValue) ? null : _task.Entity; }
            set
            {
                Task previousValue = _task.Entity;
                if (previousValue != value || _task.HasLoadedOrAssignedValue == false)
                {
                    OnTaskChanging(value);
                    SendPropertyChanging("Task");
                    if (previousValue != null)
                    {
                        _task.Entity = null;
                        previousValue.AuditList.Remove(this);
                    }
                    _task.Entity = value;
                    if (value != null)
                    {
                        value.AuditList.Add(this);
                        _taskId = value.Id;
                    }
                    else
                    {
                        _taskId = default(Nullable<int>);
                    }
                    SendPropertyChanged("Task");
                    OnTaskChanged();
                }
            }
        }
        

        private System.Data.Linq.EntityRef<User> _user;

        /// <summary>
        /// Gets or sets the <see cref="User"/> association.
        /// </summary>
        [System.Data.Linq.Mapping.Association(Name = "User_Audit", Storage = "_user", ThisKey = "UserId", OtherKey = "Id", IsUnique = true, IsForeignKey = true)]
        [System.Runtime.Serialization.DataMember(Order = 11, EmitDefaultValue = false)]
        public User User
        {
            get { return (serializing && !_user.HasLoadedOrAssignedValue) ? null : _user.Entity; }
            set
            {
                User previousValue = _user.Entity;
                if (previousValue != value || _user.HasLoadedOrAssignedValue == false)
                {
                    OnUserChanging(value);
                    SendPropertyChanging("User");
                    if (previousValue != null)
                    {
                        _user.Entity = null;
                        previousValue.AuditList.Remove(this);
                    }
                    _user.Entity = value;
                    if (value != null)
                    {
                        value.AuditList.Add(this);
                        _userId = value.Id;
                    }
                    else
                    {
                        _userId = default(Nullable<int>);
                    }
                    SendPropertyChanged("User");
                    OnUserChanged();
                }
            }
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
        /// <summary>Called when <see cref="CreatedDate"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnCreatedDateChanging(System.DateTime value);
        /// <summary>Called after <see cref="CreatedDate"/> has Changed.</summary>
        partial void OnCreatedDateChanged();
        /// <summary>Called when <see cref="Date"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnDateChanging(System.DateTime value);
        /// <summary>Called after <see cref="Date"/> has Changed.</summary>
        partial void OnDateChanged();
        /// <summary>Called when <see cref="Username"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnUsernameChanging(string value);
        /// <summary>Called after <see cref="Username"/> has Changed.</summary>
        partial void OnUsernameChanged();
        /// <summary>Called when <see cref="Content"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnContentChanging(string value);
        /// <summary>Called after <see cref="Content"/> has Changed.</summary>
        partial void OnContentChanged();
        /// <summary>Called when <see cref="RowVersion"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnRowVersionChanging(System.Data.Linq.Binary value);
        /// <summary>Called after <see cref="RowVersion"/> has Changed.</summary>
        partial void OnRowVersionChanged();
        /// <summary>Called when <see cref="UserId"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnUserIdChanging(Nullable<int> value);
        /// <summary>Called after <see cref="UserId"/> has Changed.</summary>
        partial void OnUserIdChanged();
        /// <summary>Called when <see cref="TaskId"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnTaskIdChanging(Nullable<int> value);
        /// <summary>Called after <see cref="TaskId"/> has Changed.</summary>
        partial void OnTaskIdChanged();
        /// <summary>Called when <see cref="Myxml"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnMyxmlChanging(string value);
        /// <summary>Called after <see cref="Myxml"/> has Changed.</summary>
        partial void OnMyxmlChanged();
        /// <summary>Called when <see cref="Task"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnTaskChanging(Task value);
        /// <summary>Called after <see cref="Task"/> has Changed.</summary>
        partial void OnTaskChanged();
        /// <summary>Called when <see cref="User"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        partial void OnUserChanging(User value);
        /// <summary>Called after <see cref="User"/> has Changed.</summary>
        partial void OnUserChanged();

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

        /// <summary>
        /// Deserializes an instance of <see cref="Audit"/> from XML.
        /// </summary>
        /// <param name="xml">The XML string representing a <see cref="Audit"/> instance.</param>
        /// <returns>An instance of <see cref="Audit"/> that is deserialized from the XML string.</returns>
        public static Audit FromXml(string xml)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(Audit));

            using (var sr = new System.IO.StringReader(xml))
            using (var reader = System.Xml.XmlReader.Create(sr))
            {
                return deserializer.ReadObject(reader) as Audit;
            }
        }

        /// <summary>
        /// Deserializes an instance of <see cref="Audit"/> from a byte array.
        /// </summary>
        /// <param name="buffer">The byte array representing a <see cref="Audit"/> instance.</param>
        /// <returns>An instance of <see cref="Audit"/> that is deserialized from the byte array.</returns>
        public static Audit FromBinary(byte[] buffer)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(Audit));

            using (var ms = new System.IO.MemoryStream(buffer))
            using (var reader = System.Xml.XmlDictionaryReader.CreateBinaryReader(ms, System.Xml.XmlDictionaryReaderQuotas.Max))
            {
                return deserializer.ReadObject(reader) as Audit;
            }
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
        public Audit Clone()
        {
            return (Audit)((ICloneable)this).Clone();
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
            _task = Detach(_task);
            _user = Detach(_user);
        }
        #endregion
    }
}

