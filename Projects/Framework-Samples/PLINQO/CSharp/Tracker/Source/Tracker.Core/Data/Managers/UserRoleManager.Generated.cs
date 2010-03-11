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
    /// The manager class for UserRole.
    /// </summary>
    public partial class UserRoleManager 
        : CodeSmith.Data.EntityManagerBase<TrackerDataManager, Tracker.Core.Data.UserRole>
    {
        /// <summary>
        /// Initializes the <see cref="UserRoleManager"/> class.
        /// </summary>
        /// <param name="manager">The current manager.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public UserRoleManager(TrackerDataManager manager) : base(manager)
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
        protected System.Data.Linq.Table<Tracker.Core.Data.UserRole> Entity
        {
            get { return Manager.Context.UserRole; }
        }
        
        
        /// <summary>
        /// Creates the key for this entity.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static CodeSmith.Data.IEntityKey<int, int> CreateKey(int userId, int roleId)
        {
            return new CodeSmith.Data.EntityKey<int, int>(userId, roleId);
        }
        
        /// <summary>
        /// Gets an entity by the primary key.
        /// </summary>
        /// <param name="key">The key for the entity.</param>
        /// <returns>
        /// An instance of the entity or null if not found.
        /// </returns>
        /// <remarks>
        /// This method is expecting key to be of type IEntityKey&lt;int, int&gt;.
        /// </remarks>
        /// <exception cref="ArgumentException">Thrown when key is not of type IEntityKey&lt;int, int&gt;.</exception>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public override Tracker.Core.Data.UserRole GetByKey(CodeSmith.Data.IEntityKey key)
        {
            if (key is CodeSmith.Data.IEntityKey<int, int>)
            {
                var entityKey = (CodeSmith.Data.IEntityKey<int, int>)key;
                return GetByKey(entityKey.Key, entityKey.Key1);
            }
            else
            {
                throw new ArgumentException("Invalid key, expected key to be of type IEntityKey<int, int>");
            }
        }
        
        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        /// <returns>An instance of the entity or null if not found.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public Tracker.Core.Data.UserRole GetByKey(int userId, int roleId)
        {
            if (Context.LoadOptions == null) 
                return Query.GetByKey.Invoke(Context, userId, roleId);
            else
                return Entity.FirstOrDefault(u => u.UserId == userId 
					&& u.RoleId == roleId);
        }
        
        /// <summary>
        /// Immediately deletes the entity by the primary key from the underlying data source with a single delete command.
        /// </summary>
        /// <returns>The number of rows deleted from the database.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public int Delete(int userId, int roleId)
        {
            return Entity.Delete(u => u.UserId == userId 
					&& u.RoleId == roleId);
        }
        /// <summary>
        /// Gets a query by an index.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public IQueryable<Tracker.Core.Data.UserRole> GetByUserId(int userId)
        {
            if (Context.LoadOptions == null) 
                return Query.GetByUserId.Invoke(Context, userId);
            else
                return Entity.Where(u => u.UserId == userId);
        }
        /// <summary>
        /// Gets a query by an index.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public IQueryable<Tracker.Core.Data.UserRole> GetByRoleId(int roleId)
        {
            if (Context.LoadOptions == null) 
                return Query.GetByRoleId.Invoke(Context, roleId);
            else
                return Entity.Where(u => u.RoleId == roleId);
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
            internal static readonly Func<Tracker.Core.Data.TrackerDataContext, int, int, Tracker.Core.Data.UserRole> GetByKey = 
                System.Data.Linq.CompiledQuery.Compile(
                    (Tracker.Core.Data.TrackerDataContext db, int userId, int roleId) => 
                        db.UserRole.FirstOrDefault(u => u.UserId == userId 
							&& u.RoleId == roleId));

            [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
            internal static readonly Func<Tracker.Core.Data.TrackerDataContext, int, IQueryable<Tracker.Core.Data.UserRole>> GetByUserId = 
                System.Data.Linq.CompiledQuery.Compile(
                    (Tracker.Core.Data.TrackerDataContext db, int userId) => 
                        db.UserRole.Where(u => u.UserId == userId));

            [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
            internal static readonly Func<Tracker.Core.Data.TrackerDataContext, int, IQueryable<Tracker.Core.Data.UserRole>> GetByRoleId = 
                System.Data.Linq.CompiledQuery.Compile(
                    (Tracker.Core.Data.TrackerDataContext db, int roleId) => 
                        db.UserRole.Where(u => u.RoleId == roleId));

        }
        #endregion
    }
}

