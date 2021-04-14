Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports crud_m_table_core

Namespace Controllers
    Public Class tblStudentsController
        Inherits System.Web.Mvc.Controller

        Private db As New crud_m_tableEntities

        ' GET: tblStudents
        Function Index() As ActionResult
            Dim tblStudents = db.tblStudents.Include(Function(t) t.tblDepartment)
            Return View(tblStudents.ToList())
        End Function

        ' GET: tblStudents/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tblStudent As tblStudent = db.tblStudents.Find(id)
            If IsNothing(tblStudent) Then
                Return HttpNotFound()
            End If
            Return View(tblStudent)
        End Function

        ' GET: tblStudents/Create
        Function Create() As ActionResult
            ViewBag.Department_Name = New SelectList(db.tblDepartments, "ID", "DepartmentName")
            Return View()
        End Function

        ' POST: tblStudents/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="ID,Name,Gender,Age,Department_Name")> ByVal tblStudent As tblStudent) As ActionResult
            If ModelState.IsValid Then
                db.tblStudents.Add(tblStudent)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.Department_Name = New SelectList(db.tblDepartments, "ID", "DepartmentName", tblStudent.Department_Name)
            Return View(tblStudent)
        End Function

        ' GET: tblStudents/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tblStudent As tblStudent = db.tblStudents.Find(id)
            If IsNothing(tblStudent) Then
                Return HttpNotFound()
            End If
            ViewBag.Department_Name = New SelectList(db.tblDepartments, "ID", "DepartmentName", tblStudent.Department_Name)
            Return View(tblStudent)
        End Function

        ' POST: tblStudents/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="ID,Name,Gender,Age,Department_Name")> ByVal tblStudent As tblStudent) As ActionResult
            If ModelState.IsValid Then
                db.Entry(tblStudent).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.Department_Name = New SelectList(db.tblDepartments, "ID", "DepartmentName", tblStudent.Department_Name)
            Return View(tblStudent)
        End Function

        ' GET: tblStudents/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tblStudent As tblStudent = db.tblStudents.Find(id)
            If IsNothing(tblStudent) Then
                Return HttpNotFound()
            End If
            Return View(tblStudent)
        End Function

        ' POST: tblStudents/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim tblStudent As tblStudent = db.tblStudents.Find(id)
            db.tblStudents.Remove(tblStudent)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
