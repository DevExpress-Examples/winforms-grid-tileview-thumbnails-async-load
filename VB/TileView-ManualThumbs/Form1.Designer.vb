Namespace TileView_ManualThumbs

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim tableColumnDefinition1 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tableRowDefinition1 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tileViewItemElement1 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Me.colName = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.textureBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.tileView1 = New DevExpress.XtraGrid.Views.Tile.TileView()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textureBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tileView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' colName
            ' 
            Me.colName.FieldName = "Name"
            Me.colName.Name = "colName"
            Me.colName.Visible = True
            Me.colName.VisibleIndex = 0
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.textureBindingSource
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.tileView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(445, 291)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.tileView1})
            ' 
            ' textureBindingSource
            ' 
            Me.textureBindingSource.DataSource = GetType(TileView_ManualThumbs.Texture)
            ' 
            ' tileView1
            ' 
            Me.tileView1.Appearance.ItemNormal.Font = New System.Drawing.Font("Segoe UI", 7F)
            Me.tileView1.Appearance.ItemNormal.Options.UseFont = True
            Me.tileView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colName})
            Me.tileView1.GridControl = Me.gridControl1
            Me.tileView1.Name = "tileView1"
            Me.tileView1.OptionsTiles.ColumnCount = -1
            Me.tileView1.OptionsTiles.ItemPadding = New System.Windows.Forms.Padding(0)
            Me.tileView1.OptionsTiles.RowCount = -1
            Me.tileView1.TileColumns.Add(tableColumnDefinition1)
            Me.tileView1.TileRows.Add(tableRowDefinition1)
            tileViewItemElement1.Column = Me.colName
            tileViewItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement1.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
            tileViewItemElement1.Text = "colName"
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            Me.tileView1.TileTemplate.Add(tileViewItemElement1)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(445, 291)
            Me.Controls.Add(Me.gridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textureBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tileView1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private tileView1 As DevExpress.XtraGrid.Views.Tile.TileView

        Private textureBindingSource As System.Windows.Forms.BindingSource

        Private colName As DevExpress.XtraGrid.Columns.TileViewColumn
    End Class
End Namespace
