using DevExpress.XtraGrid.Views.Tile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TileView_ManualThumbs {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        List<Texture> textures;

        private void Form1_Load(object sender, EventArgs e) {
            InitData();

            gridControl1.DataSource = textures;
            tileView1.OptionsTiles.ItemSize = new Size(90, 40);
            tileView1.GetThumbnailImage += TileView1_GetThumbnailImage;
            // Specify a column that provides information on images to render.
            tileView1.ColumnSet.BackgroundImageColumn = colName;
            tileView1.OptionsImageLoad.RandomShow = true;
            tileView1.OptionsImageLoad.LoadThumbnailImagesFromDataSource = false;
            // Enable async image load.
            tileView1.OptionsImageLoad.AsyncLoad = true;
        }

        private void TileView1_GetThumbnailImage(object sender, DevExpress.Utils.ThumbnailImageEventArgs e) {
            string colorName = textures[e.DataSourceIndex].Name;
            e.ThumbnailImage = GetImage(e.DesiredThumbnailSize, colorName);
        }

        private Image GetImage(Size imageSize, string colorName) {
            //Generate a thumbnail
            Bitmap image = new Bitmap(imageSize.Width, imageSize.Height);
            using(Graphics graphics = Graphics.FromImage(image)) {
                Color tileColor = Color.FromName(colorName);
                GraphicsUnit grUnit = GraphicsUnit.Pixel;
                RectangleF imageRect = image.GetBounds(ref grUnit);
                using(LinearGradientBrush brush = new LinearGradientBrush(imageRect, Color.White, Color.White, 45, false)) {
                    ColorBlend cblend = new ColorBlend(4);
                    cblend.Colors = new Color[4] { Color.White, tileColor, tileColor, Color.White };
                    cblend.Positions = new float[4] { 0f, 0.5f, 0.7f, 1f };
                    brush.InterpolationColors = cblend;
                    graphics.FillRectangle(brush, imageRect);
                }
            }
            return image;
        }

        private void InitData() {
            textures = new List<Texture>();
            System.Array colorsArray = Enum.GetNames(typeof(KnownColor));
            foreach(var colorName in colorsArray ) {
                textures.Add(new Texture(colorName.ToString()));
            }
        }
    }

    public class Texture { 
        public Texture(string name) {
            this.Name = name;
        }
        public string Name { get; set; }
    }
}
