<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128628953/17.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T529326)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Data Grid - Create thumbnails and load them asynchronously in a TileView

This example shows how to generate background images (thumbnails) for tiles in a [TileView]() and load them asynchronously.

![WinForms Data Grid - Create thumbnails and load them asynchronously in a TileView](https://raw.githubusercontent.com/DevExpress-Examples/how-to-generate-thumbnails-and-display-them-asynchronously-in-tileview-t529326/17.1.3%2B/media/winforms-grid-tileview-async-image-load.png)

In this example:

The `TileView` is bound to a list that contains texture names. We created custom background thumbnails for all tiles based on corresponding texture names, and display these images asynchronously. The [AsyncLoad](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Tile.TileViewOptionsImageLoad.AsyncLoad) setting enables async tile loading.

```csharp
private void Form1_Load(object sender, EventArgs e) {
    InitData();
    gridControl1.DataSource = textures;
    tileView1.OptionsTiles.ItemSize = new Size(90, 40);
    tileView1.GetThumbnailImage += TileView1_GetThumbnailImage;
    // Specifies a column that contains information on tile images.
    tileView1.ColumnSet.BackgroundImageColumn = colName;
    tileView1.OptionsImageLoad.RandomShow = true;
    tileView1.OptionsImageLoad.LoadThumbnailImagesFromDataSource = false;
    // Enables async image load.
    tileView1.OptionsImageLoad.AsyncLoad = true;
}
```

Thumbnails are generated within the [GetThumbnailImage](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Tile.TileView.GetThumbnailImage) event.

```csharp
private void TileView1_GetThumbnailImage(object sender, DevExpress.Utils.ThumbnailImageEventArgs e) {
    string colorName = textures[e.DataSourceIndex].Name;
    e.ThumbnailImage = GetImage(e.DesiredThumbnailSize, colorName);
}
```


## Files to Review

* [Form1.cs](./CS/TileView-ManualThumbs/Form1.cs) (VB: [Form1.vb](./VB/TileView-ManualThumbs/Form1.vb))
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-tileview-thumbnails-async-load&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-tileview-thumbnails-async-load&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
