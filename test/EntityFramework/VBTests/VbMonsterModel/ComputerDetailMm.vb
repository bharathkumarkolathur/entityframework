'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class ComputerDetailMm
    Public Property ComputerDetailId As Integer
    Public Property Manufacturer As String
    Public Property Model As String
    Public Property Serial As String
    Public Property Specifications As String
    Public Property PurchaseDate As Date

    Public Property Dimensions As DimensionsMm = New DimensionsMm

    Public Overridable Property Computer As ComputerMm

End Class
