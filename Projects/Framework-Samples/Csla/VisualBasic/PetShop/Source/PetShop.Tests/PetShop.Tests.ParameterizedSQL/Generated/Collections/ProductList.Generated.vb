﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.3, CSLA Templates: v3.0.1.1934, CSLA Framework: v3.8.4.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'ProductList.vb.
'
'     Template: EditableChildList.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System
Imports System.Collections.Generic

Imports Csla
Imports Csla.Data

Namespace PetShop.Tests.ParameterizedSQL
    <Serializable()> _
    Public Partial Class ProductList 
        Inherits BusinessListBase(Of ProductList, Product)
    
#Region "Contructor(s)"
        Private Sub New()
            AllowNew = true
            MarkAsChild()
        End Sub
    
#End Region
    
#Region "Synchronous Factory Methods" 
    
        Friend Shared Function NewList() As ProductList
            Return DataPortal.CreateChild(Of ProductList)()
        End Function
    
        Friend Shared Function GetByProductId(ByVal productId As System.String) As ProductList 
            Dim criteria As New ProductCriteria()
            criteria.ProductId = productId
    
            Return DataPortal.FetchChild(Of ProductList)(criteria)
        End Function
    
        Friend Shared Function GetByName(ByVal name As System.String) As ProductList 
            Dim criteria As New ProductCriteria()
            criteria.Name = name
    
            Return DataPortal.FetchChild(Of ProductList)(criteria)
        End Function
    
        Friend Shared Function GetByCategoryId(ByVal categoryId As System.String) As ProductList 
            Dim criteria As New ProductCriteria()
            criteria.CategoryId = categoryId
    
            Return DataPortal.FetchChild(Of ProductList)(criteria)
        End Function
    
        Friend Shared Function GetByCategoryIdName(ByVal categoryId As System.String, ByVal name As System.String) As ProductList 
            Dim criteria As New ProductCriteria()
            criteria.CategoryId = categoryId
			criteria.Name = name
    
            Return DataPortal.FetchChild(Of ProductList)(criteria)
        End Function
    
        Friend Shared Function GetByCategoryIdProductIdName(ByVal categoryId As System.String, ByVal productId As System.String, ByVal name As System.String) As ProductList 
            Dim criteria As New ProductCriteria()
            criteria.CategoryId = categoryId
			criteria.ProductId = productId
			criteria.Name = name
    
            Return DataPortal.FetchChild(Of ProductList)(criteria)
        End Function
    
        Friend Shared Function GetAll() As ProductList
            Return DataPortal.FetchChild(Of ProductList)(New ProductCriteria())
        End Function
    
#End Region
    
#Region "Method Overrides"
    
        Protected Overrides Function AddNewCore() As Object
            Dim item As Product = PetShop.Tests.ParameterizedSQL.Product.NewProduct()

            Dim cancel As Boolean = False
            OnAddNewCore(item, cancel)
            If Not (cancel) Then
                ' Check to see if someone set the item to null in the OnAddNewCore.
                If(item Is Nothing) Then
                    item = PetShop.Tests.ParameterizedSQL.Product.NewProduct()
                End If
            ' Pass the parent value down to the child.
                Dim category As Category = CType(Me.Parent, Category)
                If Not(category Is Nothing)
                    item.CategoryId = category.CategoryId
                End If
                Add(item)
            End If

            Return item
        End Function
    
#End Region
#Region "DataPortal partial methods"
    
        Partial Private Sub OnCreating(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnCreated()
        End Sub
        Partial Private Sub OnFetching(ByVal criteria As ProductCriteria, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnFetched()
        End Sub
        Partial Private Sub OnMapping(ByVal reader As SafeDataReader, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnMapped()
        End Sub
        Partial Private Sub OnUpdating(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnUpdated()
        End Sub
        Partial Private Sub OnAddNewCore(ByVal item As Product, ByRef cancel As Boolean)
        End Sub
    
#End Region

#Region "Exists Command"

        Public Shared Function Exists(ByVal criteria As ProductCriteria) As Boolean
            Return PetShop.Tests.ParameterizedSQL.Product.Exists(criteria)
        End Function

#End Region
    End Class
End Namespace