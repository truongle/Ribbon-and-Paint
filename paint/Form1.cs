using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint
{
    public enum ShapeMode
    {
        LINE,
        RECTANGLE,
        ELIPSE,
    }
    public partial class Form1 : Form
    {
        private Point _p1;
        private Point _p2;
        private bool _IsDown;
        private Bitmap _bitmap;
        private Graphics _grs;
        private ShapeMode _currShapeMode;
        public Form1()
        {
            InitializeComponent();
            this.MouseDown += Form1_MouseDown;
            this.MouseMove += Form1_MouseMove;
            this.MouseUp += Form1_MouseUp;
            this.Paint += Form1_Paint;
            _bitmap = new Bitmap(this.Width, this.Height);
            _grs = Graphics.FromImage(_bitmap);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (_IsDown)
            {
                Pen pen = new Pen(Color.Red, (float)2);
                int dx = _p2.X - _p1.X;
                int dy = _p2.Y - _p1.Y;
                switch (_currShapeMode)
                {
                    case ShapeMode.LINE:
                        e.Graphics.DrawLine(pen, _p1, _p2);
                        break;
                    case ShapeMode.RECTANGLE:
                        e.Graphics.DrawRectangle(pen, _p1.X, _p1.Y,dx,dy);
                        break;
                    case ShapeMode.ELIPSE:
                        e.Graphics.DrawEllipse(pen, _p1.X, _p1.Y, dx, dy);
                        break;
                    default:
                        MessageBox.Show("Lỗi");
                        break;
                }
            }
        }
        void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            _IsDown = false;
            Pen pen = new Pen(Color.Red, (float)2);
                int dx = _p2.X - _p1.X;
                int dy = _p2.Y - _p1.Y;
                switch (_currShapeMode)
                {
                    case ShapeMode.LINE:
                        _grs.DrawLine(pen, _p1, _p2);
                        break;
                    case ShapeMode.RECTANGLE:
                        _grs.DrawRectangle(pen, _p1.X, _p1.Y, dx, dy);
                        break;
                    case ShapeMode.ELIPSE:
                        _grs.DrawEllipse(pen, _p1.X, _p1.Y, dx, dy);
                        break;
                    default:
                        MessageBox.Show("Lỗi");
                        break;
                        
                }
                this.BackgroundImage = (Bitmap)_bitmap.Clone();
        }

        void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_IsDown)
            {
                _p2 = new Point(e.Location.X, e.Location.Y);
                this.Refresh();
            }
        }

        void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            _IsDown = true;
            _p1 = new Point(e.Location.X, e.Location.Y);
        }

        private void btn_drawline_Click(object sender, EventArgs e)
        {
            _currShapeMode = ShapeMode.LINE;
        }

        private void btn_drawRec_Click(object sender, EventArgs e)
        {
            _currShapeMode = ShapeMode.RECTANGLE;
        }

        private void btn_DrawEclipse_Click(object sender, EventArgs e)
        {
            _currShapeMode = ShapeMode.ELIPSE;
        }
    }
}
