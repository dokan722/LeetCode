using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Problems.Problems._3408;

namespace Problems.Problems
{
    public class _3484 : IProblem
    {
        public bool Test()
        {
            var spreadshit = new Spreadsheet(3);
            if (spreadshit.GetValue("=5+7") != 12)
                return false;
            spreadshit.SetCell("A1", 10);
            if (spreadshit.GetValue("=A1+6") != 16)
                return false;
            spreadshit.SetCell("B2", 15);
            if (spreadshit.GetValue("=A1+B2") != 25)
                return false;
            spreadshit.ResetCell("A1");
            if (spreadshit.GetValue("=A1+B2") != 15)
                return false;

            return true;
        }

        public class Spreadsheet
        {
            private Dictionary<string, int> _cells;
            public Spreadsheet(int rows)
            {
                _cells = new();
            }

            public void SetCell(string cell, int value)
            {
                _cells[cell] = value;
            }

            public void ResetCell(string cell)
            {
                _cells.Remove(cell);
            }

            public int GetValue(string formula)
            {
                var parts = formula.Substring(1).Split('+');
                return GetCellValue(parts[0]) + GetCellValue(parts[1]);
            }

            private int GetCellValue(string cell)
            {
                if (int.TryParse(cell, out int result))
                    return result;
                if (_cells.TryGetValue(cell, out var value))
                    return value;
                return 0;
            }
        }

    }
}
