'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class tblDepartment
    Public Property ID As Integer
    Public Property DepartmentName As String
    Public Property Location As String
    Public Property DepartmentHead As String

    Public Overridable Property tblStudents As ICollection(Of tblStudent) = New HashSet(Of tblStudent)

End Class
