'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.3, CSLA Templates: v3.0.1.1934, CSLA Framework: v3.8.4.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Item.cs'.
'
'     Template: ObjectFactory.DataAccess.ParameterizedSQL.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

#Region "Imports declarations"

Imports System
Imports System.Data
Imports System.Data.SqlClient

Imports Csla
Imports Csla.Data
Imports Csla.Server

Imports PetShop.Tests.OF.ParameterizedSQL

#End Region

Namespace PetShop.Tests.OF.ParameterizedSQL.DAL
    Public Partial Class ItemFactory
        Inherits ObjectFactory
    
#Region "Create"
    
        ''' <summary>
        ''' Creates New Item with default values.
        ''' </summary>
        ''' <Returns>New Item.</Returns>
        <RunLocal()> _
        Public Function Create() As Item
            Dim item As Item = CType(Activator.CreateInstance(GetType(Item), True), Item)
    
            Dim cancel As Boolean = False
            OnCreating(cancel)
            If (cancel) Then
                Return item
            End If
    
            Using BypassPropertyChecks(item)
                ' Default values.
    
                item.ProductId = "BN"
    
                CheckRules(item)
                MarkNew(item)
            End Using
    
            OnCreated()
    
            Return item
        End Function
    
        ''' <summary>
        ''' Creates New Item with default values.
        ''' </summary>
        ''' <Returns>New Item.</Returns>
        <RunLocal()> _
        Private Function Create(ByVal criteria As ItemCriteria) As  Item
            Dim item As Item = CType(Activator.CreateInstance(GetType(Item), True), Item)
    
            Dim cancel As Boolean = False
            OnCreating(cancel)
            If (cancel) Then
                Return item
            End If
    
            Dim resource As Item = Fetch(criteria)
    
            Using BypassPropertyChecks(item)
                item.ListPrice = resource.ListPrice
                item.UnitCost = resource.UnitCost
                item.Status = resource.Status
                item.Name = resource.Name
                item.Image = resource.Image
            End Using
    
            CheckRules(item)
            MarkNew(item)
    
            OnCreated()
    
            Return item
        End Function
    
#End Region
    
#Region "Fetch
    
        ''' <summary>
        ''' Fetch Item.
        ''' </summary>
        ''' <param name="criteria">The criteria.</param>
        ''' <Returns></Returns>
        Public Function Fetch(ByVal criteria As ItemCriteria) As Item
            Dim item As Item = Nothing
            
            Dim cancel As Boolean = False
            OnFetching(criteria, cancel)
            If (cancel) Then
                Return item
            End If
    
            Dim commandText As String = String.Format("SELECT [ItemId], [ProductId], [ListPrice], [UnitCost], [Supplier], [Status], [Name], [Image] FROM [dbo].[Item] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                    Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                        If reader.Read() Then
                            item = Map(reader)
                        Else
                            Throw New Exception(String.Format("The record was not found in 'Item' using the following criteria: {0}.", criteria))
                        End If
                    End Using
                End Using
            End Using
    
            MarkOld(item)
    
            OnFetched()
    
            Return item
        End Function
    
#End Region
    
#Region "Insert"
    
        Private Sub DoInsert(ByRef item As Item, ByVal stopProccessingChildren As Boolean)
            ' Don't update If the item isn't dirty.
            If Not (item.IsDirty) Then
                Return
            End If
    
            Dim cancel As Boolean = False
            OnInserting(cancel)
            If (cancel) Then
                Return
            End If
    
            Const commandText As String = "INSERT INTO [dbo].[Item] ([ItemId], [ProductId], [ListPrice], [UnitCost], [Supplier], [Status], [Name], [Image]) VALUES (@p_ItemId, @p_ProductId, @p_ListPrice, @p_UnitCost, @p_Supplier, @p_Status, @p_Name, @p_Image)"
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddWithValue("@p_ItemId", item.ItemId)
				command.Parameters.AddWithValue("@p_ProductId", item.ProductId)
				command.Parameters.AddWithValue("@p_ListPrice", ADOHelper.NullCheck(item.ListPrice))
				command.Parameters.AddWithValue("@p_UnitCost", ADOHelper.NullCheck(item.UnitCost))
				command.Parameters.AddWithValue("@p_Supplier", ADOHelper.NullCheck(item.Supplier))
				command.Parameters.AddWithValue("@p_Status", ADOHelper.NullCheck(item.Status))
				command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(item.Name))
				command.Parameters.AddWithValue("@p_Image", ADOHelper.NullCheck(item.Image))
    
                    Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                        If reader.Read() Then
    
                        End If
                    End Using
                End Using
            End Using
    
            item.OriginalItemId = item.ItemId
    
            MarkOld(item)
            CheckRules(item)
            
            If Not (stopProccessingChildren) Then
                ' Update Child Items.
                Update_Product_ProductMember_ProductId(item)
                Update_Supplier_SupplierMember_Supplier(item)
            End If
    
            OnInserted()
        End Sub
    
#End Region
    
#Region "Update"
    
        <Transactional(TransactionalTypes.TransactionScope)> _
        Public Function Update(ByVal item As Item) As Item
            Return Update(item, false)
        End Function
    
        Public Function Update(ByVal item As Item, ByVal stopProccessingChildren as Boolean) As Item
            If(item.IsDeleted) Then
                DoDelete(item)
                MarkNew(item)
            Else If(item.IsNew) Then
                DoInsert(item, stopProccessingChildren)
            Else
            DoUpdate(item, stopProccessingChildren)
            End If
    
            Return item
        End Function
    
        Private Sub DoUpdate(ByRef item As Item, ByVal stopProccessingChildren As Boolean)
            Dim cancel As Boolean = False
            OnUpdating(cancel)
            If (cancel) Then
                Return
            End If
            
            ' Don't update If the item isn't dirty.
            If (item.IsDirty) Then
    
                If Not item.OriginalItemId = item.ItemId Then
                    ' Insert new child.
                    Dim temp As Item = CType(Activator.CreateInstance(GetType(Item), True), Item)
                    temp.ItemId = item.ItemId
			temp.ProductId = item.ProductId
			temp.ListPrice = item.ListPrice.Value
			temp.UnitCost = item.UnitCost.Value
			temp.Supplier = item.Supplier.Value
			temp.Status = item.Status
			temp.Name = item.Name
			temp.Image = item.Image
                    temp = temp.Save()
    
                    ' Mark child lists as dirty. This code may need to be updated to one-to-one relationships.
                    ' Update Child Items.
                    Update_Product_ProductMember_ProductId(item)
                    Update_Supplier_SupplierMember_Supplier(item)
        
                    ' Delete the old.
                    Dim criteria As New ItemCriteria()
                    criteria.ItemId = item.OriginalItemId
                    Delete(criteria)
        
                    ' Mark the original as the new one.
                    item.OriginalItemId = item.ItemId
                    MarkOld(item)
                    CheckRules(item)
    
                    OnUpdated()
            
                    Return
                End If
    
                Const commandText As String = "UPDATE [dbo].[Item]  SET [ItemId] = @p_ItemId, [ProductId] = @p_ProductId, [ListPrice] = @p_ListPrice, [UnitCost] = @p_UnitCost, [Supplier] = @p_Supplier, [Status] = @p_Status, [Name] = @p_Name, [Image] = @p_Image WHERE [ItemId] = @p_ItemId; SELECT [ItemId] FROM [dbo].[Item] WHERE [ItemId] = @p_OriginalItemId"
                Using connection As New SqlConnection(ADOHelper.ConnectionString)
                    connection.Open()
                    Using command As New SqlCommand(commandText, connection)
                        command.Parameters.AddWithValue("@p_OriginalItemId", item.OriginalItemId)
				command.Parameters.AddWithValue("@p_ItemId", item.ItemId)
				command.Parameters.AddWithValue("@p_ProductId", item.ProductId)
				command.Parameters.AddWithValue("@p_ListPrice", ADOHelper.NullCheck(item.ListPrice))
				command.Parameters.AddWithValue("@p_UnitCost", ADOHelper.NullCheck(item.UnitCost))
				command.Parameters.AddWithValue("@p_Supplier", ADOHelper.NullCheck(item.Supplier))
				command.Parameters.AddWithValue("@p_Status", ADOHelper.NullCheck(item.Status))
				command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(item.Name))
				command.Parameters.AddWithValue("@p_Image", ADOHelper.NullCheck(item.Image))
    
                        'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                        Dim result As Integer = command.ExecuteNonQuery()
                        If (result = 0) Then
                            throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                        End If
                    End Using
                End Using
            End If
    
            item.OriginalItemId = item.ItemId
    
            MarkOld(item)
            CheckRules(item)
    
            If Not (stopProccessingChildren) Then
                ' Update Child Items.
                Update_Product_ProductMember_ProductId(item)
                Update_Supplier_SupplierMember_Supplier(item)
            End If
    
            OnUpdated()
        End Sub
    
#End Region
    
#Region "Delete"
    
        <Transactional(TransactionalTypes.TransactionScope)> _
        Public Sub Delete(ByVal criteria As ItemCriteria)
            ' Note: this call to delete is for immediate deletion and doesn't keep track of any entity state.
            DoDelete(criteria)
        End Sub
    
        Protected Sub DoDelete(ByRef item As Item)
            ' If we're not dirty then don't update the database.
            If Not (item.IsDirty) Then
                Return
            End If
    
            ' If we're New then don't call delete.
            If (item.IsNew) Then
                Return
            End If
    
            Dim criteria As New ItemCriteria()
    criteria.ItemId = item.ItemId
            DoDelete(criteria)
    
            MarkNew(item)
        End Sub
    
        ''' <summary>
        ''' This call to delete is for immediate deletion and doesn't keep track of any entity state.
        ''' </summary>
        ''' <param name="criteria">The Criteria.</param>
        Private Sub DoDelete(ByVal criteria As ItemCriteria)
            Dim cancel As Boolean = False
            OnDeleting(criteria, cancel)
            If (cancel) Then
                Return
            End If
    
            Dim commandText As String = String.Format("DELETE FROM [dbo].[Item] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
    
                    'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    Dim result As Integer = command.ExecuteNonQuery()
                    If (result = 0) Then
                        throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                    End If
                End Using
            End Using
    
            OnDeleted()
        End Sub
    
#End Region
    
#Region "Helper Methods"
    
        Public Function Map(ByVal reader As SafeDataReader) As Item
            Dim item As Item = CType(Activator.CreateInstance(GetType(Item), True), Item)
            Using BypassPropertyChecks(item)
                item.ItemId = reader.GetString("ItemId")
                item.OriginalItemId = reader.GetString("ItemId")
                item.ProductId = reader.GetString("ProductId")
                item.ListPrice = If(reader.IsDBNull("ListPrice"), Nothing, reader.GetDecimal("ListPrice"))
                item.UnitCost = If(reader.IsDBNull("UnitCost"), Nothing, reader.GetDecimal("UnitCost"))
                item.Supplier = If(reader.IsDBNull("Supplier"), Nothing, reader.GetInt32("Supplier"))
                item.Status = reader.GetString("Status")
                item.Name = reader.GetString("Name")
                item.Image = reader.GetString("Image")
            End Using
                MarkOld(item)
    
            Return item
        End Function
    
        'AssociatedManyToOne
        Private Shared Sub  Update_Product_ProductMember_ProductId(ByRef item As Item)
    		item.ProductMember.ProductId = item.ProductId
    
            Dim factory As New ProductFactory
            factory.Update(item.ProductMember, True)
        End Sub
        'AssociatedManyToOne
        Private Shared Sub  Update_Supplier_SupplierMember_Supplier(ByRef item As Item)
    		item.SupplierMember.SuppId = item.Supplier.Value
    
            Dim factory As New SupplierFactory
            factory.Update(item.SupplierMember, True)
        End Sub
    
#End Region
    
#Region "DataPortal partial methods"
    
        Partial Private Sub OnCreating(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnCreated()
        End Sub
        Partial Private Sub OnFetching(ByVal criteria As ItemCriteria, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnFetched()
        End Sub
        Partial Private Sub OnMapping(ByVal reader As SafeDataReader, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnMapped()
        End Sub
        Partial Private Sub OnInserting(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnInserted()
        End Sub
        Partial Private Sub OnUpdating(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnUpdated()
        End Sub
        Partial Private Sub OnSelfDeleting(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnSelfDeleted()
        End Sub
        Partial Private Sub OnDeleting(ByVal criteria As ItemCriteria, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnDeleted()
        End Sub
        Private Partial Sub OnChildLoading(ByVal childProperty As Csla.Core.IPropertyInfo, ByRef cancel As Boolean)
        End Sub
    
#End Region
    End Class
End Namespace