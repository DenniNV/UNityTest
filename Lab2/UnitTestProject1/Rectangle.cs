using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    class Rectangle
    {
        private double[] _cordinateX = new double[4];
        private double[] _cordinateY = new double[4];
        private double _sideAB;
        private double _sideAD;

        public double Diagonal()
        {
                for (int i = 0; i < _cordinateX.Length; i++)
                {
                    if(_cordinateX[i] < 0 || _cordinateY[i] < 0)
                    {
                        throw new ArgumentOutOfRangeException("Невозможно построить прямоугольник");
                    }
                }
            _sideAB = _cordinateY[0] - _cordinateY[1];
            _sideAD = _cordinateX[0] - _cordinateX[3];
            var result = Math.Pow(_sideAB, 2.0) + Math.Pow(_sideAD, 2.0);
            return Math.Sqrt(result);
        }

        public Rectangle(double[] cordinateX , double[] cordinateY)
        {
            _cordinateX = cordinateX;
            _cordinateY = cordinateY;
        }

    }
}
