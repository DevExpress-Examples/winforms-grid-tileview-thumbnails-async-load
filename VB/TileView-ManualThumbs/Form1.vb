Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Namespace TileView_ManualThumbs

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private textures As List(Of Texture)

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            InitData()
            gridControl1.DataSource = textures
            tileView1.OptionsTiles.ItemSize = New Size(90, 40)
            AddHandler tileView1.GetThumbnailImage, AddressOf TileView1_GetThumbnailImage
            ' Specify a column that provides information on images to render.
            tileView1.ColumnSet.BackgroundImageColumn = colName
            tileView1.OptionsImageLoad.RandomShow = True
            tileView1.OptionsImageLoad.LoadThumbnailImagesFromDataSource = False
            ' Enable async image load.
            tileView1.OptionsImageLoad.AsyncLoad = True
        End Sub

        Private Sub TileView1_GetThumbnailImage(ByVal sender As Object, ByVal e As DevExpress.Utils.ThumbnailImageEventArgs)
            Dim colorName As String = textures(e.DataSourceIndex).Name
            e.ThumbnailImage = GetImage(e.DesiredThumbnailSize, colorName)
        End Sub

        Private Function GetImage(ByVal imageSize As Size, ByVal colorName As String) As Image
            'Generate a thumbnail
            Dim image As Bitmap = New Bitmap(imageSize.Width, imageSize.Height)
            Using graphics As Graphics = Graphics.FromImage(image)
                Dim tileColor As Color = Color.FromName(colorName)
                Dim grUnit As GraphicsUnit = GraphicsUnit.Pixel
                Dim imageRect As RectangleF = image.GetBounds(grUnit)
                Using brush As LinearGradientBrush = New LinearGradientBrush(imageRect, Color.White, Color.White, 45, False)
                    Dim cblend As ColorBlend = New ColorBlend(4)
                    cblend.Colors = New Color(3) {Color.White, tileColor, tileColor, Color.White}
                    cblend.Positions = New Single(3) {0F, 0.5F, 0.7F, 1F}
                    brush.InterpolationColors = cblend
                    graphics.FillRectangle(brush, imageRect)
                End Using
            End Using

            Return image
        End Function

        Private Sub InitData()
            textures = New List(Of Texture)()
            Dim colorsArray As Array = [Enum].GetNames(GetType(KnownColor))
            For Each colorName In colorsArray
                textures.Add(New Texture(colorName.ToString()))
            Next
        End Sub
    End Class

    Public Class Texture

        Public Sub New(ByVal name As String)
            Me.Name = name
        End Sub

        Public Property Name As String
    End Class
End Namespace
