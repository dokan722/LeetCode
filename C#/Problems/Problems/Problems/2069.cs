using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2069 : IProblem
    {
        public bool Test()
        {
            Robot robot = new Robot(6, 3);
            robot.Step(2);
            robot.Step(2);
            if (!Utils.Compare1DArrays(new[] {4, 0}, robot.GetPos()))
                return false;
            if (robot.GetDir() != "East")
                return false;
            robot.Step(2);
            robot.Step(1);
            robot.Step(4);
            if (!Utils.Compare1DArrays(new[] { 1, 2 }, robot.GetPos()))
                return false;
            if (robot.GetDir() != "West")
                return false;

            return true;
        }

        protected class Robot
        {
            private int _w;
            private int _h;
            private int _t;
            private int _th;
            private int _c = 0;
            private bool _moved = false;
            public Robot(int width, int height)
            {
                _w = width - 1;
                _h = height - 1;
                _t = 2 * _w + 2 * _h;
                _th = _t / 2;
            }

            public void Step(int num)
            {
                _moved = true;
                num %= _t;
                _c = (_c + num) % _t;
            }

            public int[] GetPos()
            {
                if (_c <= _th)
                    return new[] { Math.Min(_c, _w), Math.Max(0, _c - _w) };
                else
                    return new[] { Math.Max(_w - (_c - _th), 0), Math.Min(_t - _c, _h) };
            }

            public string GetDir()
            {
                if (_moved && _c == 0)
                    return "South";
                else if (_c <= _w)
                    return "East";
                else if (_c <= _th)
                    return "North";
                else if (_c <= _th + _w)
                    return "West";
                else
                    return "South";
            }
        }
    }
}
