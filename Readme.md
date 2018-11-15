<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication73/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication73/Form1.vb))
* [Program.cs](./CS/WindowsApplication73/Program.cs) (VB: [Program.vb](./VB/WindowsApplication73/Program.vb))
<!-- default file list end -->
# How to provide a new row with initial values immediately after the user activates a grid cell


<p>The GridView provides the InitNewRow event to populate a new row with default values. However, this event is fired only when the user starts editing a grid cell. To force the InitNewRow to fire, handle the GridView.ShownEditor event, and mark the view’s active editor as modified.</p>

<br/>


