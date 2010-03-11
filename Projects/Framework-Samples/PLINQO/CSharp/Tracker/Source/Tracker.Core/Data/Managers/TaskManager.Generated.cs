﻿
//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using CodeSmith.Data.Linq;
using CodeSmith.Data.Linq.Dynamic;

namespace Tracker.Core.Data
{
    /// <summary>
    /// The manager class for Task.
    /// </summary>
    public partial class TaskManager 
        : CodeSmith.Data.EntityManagerBase<TrackerDataManager, Tracker.Core.Data.Task>
    {
        /// <summary>
        /// Initializes the <see cref="TaskManager"/> class.
        /// </summary>
        /// <param name="manager">The current manager.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public TaskManager(TrackerDataManager manager) : base(manager)
        {
            OnCreated();
        }

        /// <summary>
        /// Gets the current context.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        protected Tracker.Core.Data.TrackerDataContext Context
        {
            get { return Manager.Context; }
        }
        
        /// <summary>
        /// Gets the entity for this manager.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        protected System.Data.Linq.Table<Tracker.Core.Data.Task> Entity
        {
            get { return Manager.Context.Task; }
        }
        
        
        /// <summary>
        /// Creates the key for this entity.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static CodeSmith.Data.IEntityKey<int> CreateKey(int id)
        {
            return new CodeSmith.Data.EntityKey<int>(id);
        }
        
        /// <summary>
        /// Gets an entity by the primary key.
        /// </summary>
        /// <param name="key">The key for the entity.</param>
        /// <returns>
        /// An instance of the entity or null if not found.
        /// </returns>
        /// <remarks>
        /// This method is expecting key to be of type IEntityKey&lt;int&gt;.
        /// </remarks>
        /// <exception cref="ArgumentException">Thrown when key is not of type IEntityKey&lt;int&gt;.</exception>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public override Tracker.Core.Data.Task GetByKey(CodeSmith.Data.IEntityKey key)
        {
            if (key is CodeSmith.Data.IEntityKey<int>)
            {
                var entityKey = (CodeSmith.Data.IEntityKey<int>)key;
                return GetByKey(entityKey.Key);
            }
            else
            {
                throw new ArgumentException("Invalid key, expected key to be of type IEntityKey<int>");
            }
        }
        
        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <returns>An instance of the entity or null if not found.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public Tracker.Core.Data.Task GetByKey(int id)
        {
            if (Context.LoadOptions == null) 
                return Query.GetByKey.Invoke(Context, id);
            else
                return Entity.FirstOrDefault(t => t.Id == id);
        }
        
        /// <summary>
        /// Immediately deletes the entity by the primary key from the underlying data source with a single delete command.
        /// </summary>
        /// <returns>The number of rows deleted from the database.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public int Delete(int id)
        {
            return Entity.Delete(t => t.Id == id);
        }
        /// <summary>
        /// Gets a query by an index.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public IQueryable<Tracker.Core.Data.Task> GetByAssignedIdStatus(int? assignedId, Status status)
        {
            if (Context.LoadOptions == null) 
                return Query.GetByAssignedIdStatus.Invoke(Context, assignedId, status);
            else
                return Entity.Where(t => t.AssignedId == assignedId 
					&& t.Status == status);
        }
        /// <summary>
        /// Gets a query by an index.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public IQueryable<Tracker.Core.Data.Task> GetByStatus(Status status)
        {
            if (Context.LoadOptions == null) 
                return Query.GetByStatus.Invoke(Context, status);
            else
                return Entity.Where(t => t.Status == status);
        }
        /// <summary>
        /// Gets a query by an index.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public IQueryable<Tracker.Core.Data.Task> GetByPriority(Priority priority)
        {
            if (Context.LoadOptions == null) 
                return Query.GetByPriority.Invoke(Context, priority);
            else
                return Entity.Where(t => t.Priority == priority);
        }
        /// <summary>
        /// Gets a query by an index.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public IQueryable<Tracker.Core.Data.Task> GetByCreatedId(int createdId)
        {
            if (Context.LoadOptions == null) 
                return Query.GetByCreatedId.Invoke(Context, createdId);
            else
                return Entity.Where(t => t.CreatedId == createdId);
        }
        /// <summary>
        /// Gets a query by an index.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public IQueryable<Tracker.Core.Data.Task> GetByAssignedId(int? assignedId)
        {
            if (Context.LoadOptions == null) 
                return Query.GetByAssignedId.Invoke(Context, assignedId);
            else
                return Entity.Where(t => t.AssignedId == assignedId);
        }

        #region Extensibility Method Definitions
        /// <summary>Called when the class is created.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        partial void OnCreated();
        #endregion
        
        #region Query
        /// <summary>
        /// A private class for lazy loading static compiled queries.
        /// </summary>
        private static partial class Query
        {

            [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
            internal static readonly Func<Tracker.Core.Data.TrackerDataContext, int, Tracker.Core.Data.Task> GetByKey = 
                System.Data.Linq.CompiledQuery.Compile(
                    (Tracker.Core.Data.TrackerDataContext db, int id) => 
                        db.Task.FirstOrDefault(t => t.Id == id));

            [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
            internal static readonly Func<Tracker.Core.Data.TrackerDataContext, int?, Status, IQueryable<Tracker.Core.Data.Task>> GetByAssignedIdStatus = 
                System.Data.Linq.CompiledQuery.Compile(
                    (Tracker.Core.Data.TrackerDataContext db, int? assignedId, Status status) => 
                        db.Task.Where(t => t.AssignedId == assignedId 
							&& t.Status == status));

            [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
            internal static readonly Func<Tracker.Core.Data.TrackerDataContext, Status, IQueryable<Tracker.Core.Data.Task>> GetByStatus = 
                System.Data.Linq.CompiledQuery.Compile(
                    (Tracker.Core.Data.TrackerDataContext db, Status status) => 
                        db.Task.Where(t => t.Status == status));

            [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
            internal static readonly Func<Tracker.Core.Data.TrackerDataContext, Priority, IQueryable<Tracker.Core.Data.Task>> GetByPriority = 
                System.Data.Linq.CompiledQuery.Compile(
                    (Tracker.Core.Data.TrackerDataContext db, Priority priority) => 
                        db.Task.Where(t => t.Priority == priority));

            [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
            internal static readonly Func<Tracker.Core.Data.TrackerDataContext, int, IQueryable<Tracker.Core.Data.Task>> GetByCreatedId = 
                System.Data.Linq.CompiledQuery.Compile(
                    (Tracker.Core.Data.TrackerDataContext db, int createdId) => 
                        db.Task.Where(t => t.CreatedId == createdId));

            [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
            internal static readonly Func<Tracker.Core.Data.TrackerDataContext, int?, IQueryable<Tracker.Core.Data.Task>> GetByAssignedId = 
                System.Data.Linq.CompiledQuery.Compile(
                    (Tracker.Core.Data.TrackerDataContext db, int? assignedId) => 
                        db.Task.Where(t => t.AssignedId == assignedId));

        }
        #endregion
    }
}

