<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128628953/17.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T529326)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/TileView-ManualThumbs/Form1.cs) (VB: [Form1.vb](./VB/TileView-ManualThumbs/Form1.vb))
<!-- default file list end -->
# How to: Generate thumbnails and display them asynchronously in TileView


This example shows how to manually generate custom tile background images (thumbnails) in Tile View and display them asynchronously. <br><br>The TileView is bound to a list that contains texture names. We need to create custom background thumbnails for all tiles based on corresponding texture names, and display these images asynchronously.<br>Thumbnails are generated using the GetThumbnailImage event. The async image load is enabled with the AsyncLoad setting.<br><br><br>

<br/>


