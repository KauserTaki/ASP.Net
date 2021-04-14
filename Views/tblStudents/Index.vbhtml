@ModelType IEnumerable(Of crud_m_table_core.tblStudent)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Gender)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Age)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.tblDepartment.DepartmentName)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Gender)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Age)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.tblDepartment.DepartmentName)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.ID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.ID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.ID })
        </td>
    </tr>
Next

</table>
