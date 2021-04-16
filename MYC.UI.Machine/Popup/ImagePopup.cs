using System.Drawing;
using System.Windows.Forms;

namespace MYC.UI.Machine.Popup
{
    public partial class ImagePopup : Form
    {
        public Image ImgLink { get; set; }
        public string Title { get; set; }

        public ImagePopup()
        {
            InitializeComponent();
        }

        private void ImagePopup_Load(object sender, System.EventArgs e)
        {
            Text = Title;
            PicImg.Image = ImgLink;
        }
    }
}
