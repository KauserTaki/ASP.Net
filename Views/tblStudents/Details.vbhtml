@ModelType crud_m_table_core.tblStudent
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>tblStudent</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Gender)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Gender)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Age)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Age)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.tblDepartment.DepartmentName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.tblDepartment.DepartmentName)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.ID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
