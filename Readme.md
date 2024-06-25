<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1146)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication73/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication73/Form1.vb))
* [Program.cs](./CS/WindowsApplication73/Program.cs) (VB: [Program.vb](./VB/WindowsApplication73/Program.vb))
<!-- default file list end -->
# How to provide a new row with initial values immediately after the user activates a grid cell


<p>The GridView provides the InitNewRow event to populate a new row with default values. However, this event is fired only when the user starts editing a grid cell. To force the InitNewRow to fire, handle the GridView.ShownEditor event, and mark the view’s active editor as modified.</p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-initialize-new-item-row-on-start-editing&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-initialize-new-item-row-on-start-editing&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
