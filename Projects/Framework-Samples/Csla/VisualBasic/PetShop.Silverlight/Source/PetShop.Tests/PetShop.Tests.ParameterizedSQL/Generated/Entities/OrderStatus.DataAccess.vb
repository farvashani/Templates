﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.3, CSLA Templates: v3.0.1.1934, CSLA Framework: v4.0.0.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'OrderStatus.vb.
'
'     Template: EditableChild.DataAccess.ParameterizedSQL.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System
Imports System.Data
Imports System.Data.SqlClient

Imports Csla
Imports Csla.Data

Namespace PetShop.Tests.ParameterizedSQL
    Public Partial Class OrderStatus
        <RunLocal()> _
        Protected Overrides Sub Child_Create()
            Dim cancel As Boolean = False
            OnChildCreating(cancel)
            If (cancel) Then
                Return
            End If
    
            BusinessRules.CheckRules()
    
            OnChildCreated()
        End Sub
        
        Private Sub Child_Fetch(ByVal criteria As OrderStatusCriteria)
            Dim cancel As Boolean = False
            OnChildFetching(criteria, cancel)
            If (cancel) Then
                Return
            End If
    
            Dim commandText As String = String.Format("SELECT [OrderId], [LineNum], [Timestamp], [Status] FROM [dbo].[OrderStatus] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                    Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                        If reader.Read() Then
                            Map(reader)
                        Else
                            Throw New Exception(String.Format("The record was not found in 'OrderStatus' using the following criteria: {0}.", criteria))
                        End If
                    End Using
                End Using
            End Using
    
            OnChildFetched()
        End Sub
    
#Region "Child_Insert"
    
        Private Sub Child_Insert(ByVal connection as SqlConnection)
            Dim cancel As Boolean = False
            OnChildInserting(connection, cancel)
            If (cancel) Then
                Return
            End If
    
            If Not (connection.State = ConnectionState.Open) Then connection.Open()
            Const commandText As String = "INSERT INTO [dbo].[OrderStatus] ([OrderId], [LineNum], [Timestamp], [Status]) VALUES (@p_OrderId, @p_LineNum, @p_Timestamp, @p_Status)"
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@p_OrderId", Me.OrderId)
				command.Parameters.AddWithValue("@p_LineNum", Me.LineNum)
				command.Parameters.AddWithValue("@p_Timestamp", Me.Timestamp)
				command.Parameters.AddWithValue("@p_Status", Me.Status)
    
                'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                Dim result As Integer = command.ExecuteNonQuery()
                If (result = 0) Then
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                End If
            End Using
    
        ' Update non-identity primary key value.
        LoadProperty(_originalOrderIdProperty, Me.OrderId)
    
        ' Update non-identity primary key value.
        LoadProperty(_originalLineNumProperty, Me.LineNum)
    
            FieldManager.UpdateChildren(Me, connection)
    
            OnChildInserted()
        End Sub
    
        Private Sub Child_Insert(ByVal order As Order, ByVal connection As SqlConnection)
            Dim cancel As Boolean = False
            OnChildInserting(connection, cancel)
            If (cancel) Then
                Return
            End If
    
            If Not (connection.State = ConnectionState.Open) Then connection.Open()
            Const commandText As String = "INSERT INTO [dbo].[OrderStatus] ([OrderId], [LineNum], [Timestamp], [Status]) VALUES (@p_OrderId, @p_LineNum, @p_Timestamp, @p_Status)"
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@p_OrderId", If(Not(order Is Nothing), order.OrderId, Me.OrderId))
				command.Parameters.AddWithValue("@p_LineNum", Me.LineNum)
				command.Parameters.AddWithValue("@p_Timestamp", Me.Timestamp)
				command.Parameters.AddWithValue("@p_Status", Me.Status)
    
                'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                Dim result As Integer = command.ExecuteNonQuery()
                If (result = 0) Then
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                End If
            End Using
    
        ' Update non-identity primary key value.
        LoadProperty(_originalOrderIdProperty, Me.OrderId)
    
        ' Update non-identity primary key value.
        LoadProperty(_originalLineNumProperty, Me.LineNum)
    
            ' A child relationship exists on this Business Object but its type is not a child type (E.G. EditableChild). 
            ' TODO: Please override OnChildInserted() and insert this child manually.
            'FieldManager.UpdateChildren(Me, connection)
    
            OnChildInserted()
        End Sub
    
    
#End Region
    
#Region "Child_Update"
    
        Private Sub Child_Update(ByVal connection as SqlConnection)
            Dim cancel As Boolean = False
            OnChildUpdating(connection, cancel)
            If (cancel) Then
                Return
            End If
    
            If Not connection.State = ConnectionState.Open Then connection.Open()
            Const commandText As String = "UPDATE [dbo].[OrderStatus]  SET [OrderId] = @p_OrderId, [LineNum] = @p_LineNum, [Timestamp] = @p_Timestamp, [Status] = @p_Status WHERE [OrderId] = @p_OriginalOrderId AND [LineNum] = @p_OriginalLineNum; SELECT [OrderId], [LineNum] FROM [dbo].[OrderStatus] WHERE [OrderId] = @p_OriginalOrderId AND [LineNum] = @p_OriginalLineNum"
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@p_OriginalOrderId", Me.OriginalOrderId)
				command.Parameters.AddWithValue("@p_OrderId", Me.OrderId)
				command.Parameters.AddWithValue("@p_OriginalLineNum", Me.OriginalLineNum)
				command.Parameters.AddWithValue("@p_LineNum", Me.LineNum)
				command.Parameters.AddWithValue("@p_Timestamp", Me.Timestamp)
				command.Parameters.AddWithValue("@p_Status", Me.Status)
    
                'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                Dim result As Integer = command.ExecuteNonQuery()
                If (result = 0) Then
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                End If
    
                ' Update non-identity primary key value.
                LoadProperty(_originalOrderIdProperty, Me.OrderId)
                ' Update non-identity primary key value.
                LoadProperty(_originalLineNumProperty, Me.LineNum)
            End Using
            FieldManager.UpdateChildren(Me, connection)
    
            OnChildUpdated()
        End Sub
    
        Private Sub Child_Update(ByVal order As Order, ByVal connection As SqlConnection)
            Dim cancel As Boolean = False
            OnChildUpdating(connection, cancel)
            If (cancel) Then
                Return
            End If
    
            If Not connection.State = ConnectionState.Open Then connection.Open()
            Const commandText As String = "UPDATE [dbo].[OrderStatus]  SET [OrderId] = @p_OrderId, [LineNum] = @p_LineNum, [Timestamp] = @p_Timestamp, [Status] = @p_Status WHERE [OrderId] = @p_OriginalOrderId AND [LineNum] = @p_OriginalLineNum; SELECT [OrderId], [LineNum] FROM [dbo].[OrderStatus] WHERE [OrderId] = @p_OriginalOrderId AND [LineNum] = @p_OriginalLineNum"
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@p_OriginalOrderId", If(Not(order Is Nothing), order.OrderId, Me.OriginalOrderId))
				command.Parameters.AddWithValue("@p_OrderId", If(Not(order Is Nothing), order.OrderId, Me.OrderId))
				command.Parameters.AddWithValue("@p_OriginalLineNum", Me.OriginalLineNum)
				command.Parameters.AddWithValue("@p_LineNum", Me.LineNum)
				command.Parameters.AddWithValue("@p_Timestamp", Me.Timestamp)
				command.Parameters.AddWithValue("@p_Status", Me.Status)
    
                'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                Dim result As Integer = command.ExecuteNonQuery()
                If (result = 0) Then
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                End If
    
                ' Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
                If(Not IsNothing(order) AndAlso Not order.OrderId = Me.OrderId) Then
                    LoadProperty(_orderIdProperty, order.OrderId)
                End If
    
                ' Update non-identity primary key value.
                LoadProperty(_originalOrderIdProperty, Me.OrderId)
                ' Update non-identity primary key value.
                LoadProperty(_originalLineNumProperty, Me.LineNum)
            End Using
            ' A child relationship exists on this Business Object but its type is not a child type (E.G. EditableChild). 
            ' TODO: Please override OnChildUpdated() and update this child manually.
            'FieldManager.UpdateChildren(Me, connection)
    
            OnChildUpdated()
        End Sub
    
    
#End Region
    
    Private Sub Child_DeleteSelf(ByVal connection as SqlConnection)
            Dim cancel As Boolean = False
            OnChildSelfDeleting(connection, cancel)
            If (cancel) Then
                Return
            End If
        
            DataPortal_Delete(New OrderStatusCriteria (OrderId, LineNum), connection)
        
            OnChildSelfDeleted()
        End Sub
        
        Protected Shadows Sub DataPortal_Delete(ByVal criteria As OrderStatusCriteria, ByVal connection as SqlConnection)
            Dim cancel As Boolean = False
            OnDeleting(criteria, connection, cancel)
            If (cancel) Then
                Return
            End If
    
        Dim commandText As String = String.Format("DELETE FROM [dbo].[OrderStatus] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
        Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
    
                'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                Dim result As Integer = command.ExecuteNonQuery()
                If result = 0 Then
                    Throw New DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                End If
    
            End Using
    
        OnDeleted()
        End Sub
        
        Private Sub Map(ByVal reader As SafeDataReader)
            Dim cancel As Boolean = False
            OnMapping(reader, cancel)
            If (cancel) Then
                Return
            End If
    
            Using(BypassPropertyChecks)
                LoadProperty(_orderIdProperty, reader.Item("OrderId"))
                LoadProperty(_originalOrderIdProperty, reader.Item("OrderId"))
                LoadProperty(_lineNumProperty, reader.Item("LineNum"))
                LoadProperty(_originalLineNumProperty, reader.Item("LineNum"))
                LoadProperty(_timestampProperty, reader.Item("Timestamp"))
                LoadProperty(_statusProperty, reader.Item("Status"))
            End Using
    
            OnMapped()
    
            MarkAsChild()
            MarkOld()
        End Sub
    End Class
End Namespace
