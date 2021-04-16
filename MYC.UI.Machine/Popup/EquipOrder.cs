using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYC.UI.Machine.Popup
{
    public partial class EquipOrder : Form
    {
        public EquipOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics doc = CreateGraphics();
            /*
            Graphics myGraphics = CreateGraphics();
            Size s = PlDoc.Size;
            int x = Location.X + PlDoc.Location.X + 8;
            int y = Location.Y + PlDoc.Location.Y + 24;

            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(x, y, 0, 0, s);

            
            */

            preView.Document = printDocument;
            preView.Width = 800;
            preView.Height = 600;
            preView.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Pen Boldpen = new Pen(Color.FromArgb(128, 128, 128), 2);
            Pen pen = new Pen(Color.FromArgb(128, 128, 128), 1);
            
            Font font14 = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(129)));

            StringFormat TextMiddle = new StringFormat();
            TextMiddle.Alignment = StringAlignment.Center;
            TextMiddle.LineAlignment = StringAlignment.Center;

            //회사 로고
            e.Graphics.DrawImage(Properties.Resources.ci_1, new Rectangle(new Point(670, 3), new Size(72, 38)));

            //문서 Title
            e.Graphics.DrawString("발주요청서", new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(129))), Brushes.Black, new Rectangle(new Point(3, 73), new Size(794, 38)), TextMiddle);

            //결제 창
            e.Graphics.DrawRectangle(Boldpen, new Rectangle(464, 151, 280, 96));
            e.Graphics.DrawString("결재", font14, Brushes.Black, new Rectangle(new Point(464, 151), new Size(70, 96)), TextMiddle);
            e.Graphics.DrawLine(Boldpen, new Point(533, 151), new Point(533, 247));
            e.Graphics.DrawLine(pen, new Point(534, 185), new Point(742, 185));
            e.Graphics.DrawString("담당", font14, Brushes.Black, new Rectangle(new Point(534, 151), new Size(70, 35)), TextMiddle);
            e.Graphics.DrawLine(pen, new Point(603, 151), new Point(603, 247));
            e.Graphics.DrawLine(pen, new Point(671, 151), new Point(671, 247));
            e.Graphics.DrawString("대표", font14, Brushes.Black, new Rectangle(new Point(672, 151), new Size(70, 35)), TextMiddle);
            

        }
    }
}
