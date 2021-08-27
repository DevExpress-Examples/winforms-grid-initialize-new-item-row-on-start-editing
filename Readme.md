<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128630891/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1146)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication73/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication73/Form1.vb))
* [Program.cs](./CS/WindowsApplication73/Program.cs) (VB: [Program.vb](./VB/WindowsApplication73/Program.vb))
<!-- default file list end -->
# How to provide a new row with initial values immediately after the user activates a grid cell


<p>The GridView provides the InitNewRow event to populate a new row with default values. However, this event is fired only when the user starts editing a grid cell. To force the InitNewRow to fire, handle the GridView.ShownEditor event, and mark the view’s active editor as modified.</p>

<br/>


