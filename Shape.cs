using System;
using System.Collections.Generic;
using System.Text;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Shape
    {
        private Color _color;
        private float _x;
        private float _y;
        private float _Width;
        private float _height;
        public Shape()
        {
            _color = Color.Green;
            _x = 0;
            _y = 0;
            _Width = 100;
            _height = 100;
        }

        public void Draw()
        {
            SplashKit.FillRectangle(_color, _x, _y, _Width, _height);
        }
        public Color color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }
        public float X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }
        public float Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }


        public float Width
        {
            get
            {
                return _Width;
            }
            set
            {
                _Width = value;
            }
        }
        public float Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }
        public bool IsAt(Point2D pt)
        {
            Rectangle shape = new Rectangle(_x, _y, _Width, _height);
            return SplashKit.PointInRectangle(pt, shape);
        }

    }
   
    

}
