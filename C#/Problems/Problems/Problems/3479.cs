using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3479 : IProblem
    {

        public bool Test()
        {
            var fruits = new[] { 4, 2, 5 };
            var baskets= new[] { 3, 5, 4 };

            var expceted = 1;

            var result = NumOfUnplacedFruits(fruits, baskets);

            return result == expceted;
        }

        private int[] segTree = new int[400007];
        private int[] baskets;

        private void Build(int p, int l, int r)
        {
            if (l == r)
            {
                segTree[p] = baskets[l];
                return;
            }
            int mid = (l + r) >> 1;
            Build(p << 1, l, mid);
            Build(p << 1 | 1, mid + 1, r);
            segTree[p] = Math.Max(segTree[p << 1], segTree[p << 1 | 1]);
        }

        private int Query(int p, int l, int r, int ql, int qr)
        {
            if (ql > r || qr < l)
            {
                return int.MinValue;
            }
            if (ql <= l && r <= qr)
            {
                return segTree[p];
            }
            int mid = (l + r) >> 1;
            return Math.Max(Query(p << 1, l, mid, ql, qr),
                            Query(p << 1 | 1, mid + 1, r, ql, qr));
        }

        private void Update(int p, int l, int r, int pos, int val)
        {
            if (l == r)
            {
                segTree[p] = val;
                return;
            }
            int mid = (l + r) >> 1;
            if (pos <= mid)
            {
                Update(p << 1, l, mid, pos, val);
            }
            else
            {
                Update(p << 1 | 1, mid + 1, r, pos, val);
            }
            segTree[p] = Math.Max(segTree[p << 1], segTree[p << 1 | 1]);
        }

        public int NumOfUnplacedFruits(int[] fruits, int[] baskets)
        {
            this.baskets = baskets;
            int m = baskets.Length;
            int count = 0;
            if (m == 0)
            {
                return fruits.Length;
            }
            Array.Fill(segTree, int.MinValue);
            Build(1, 0, m - 1);
            for (int i = 0; i < fruits.Length; i++)
            {
                int l = 0, r = m - 1, res = -1;
                while (l <= r)
                {
                    int mid = (l + r) >> 1;
                    if (Query(1, 0, m - 1, 0, mid) >= fruits[i])
                    {
                        res = mid;
                        r = mid - 1;
                    }
                    else
                    {
                        l = mid + 1;
                    }
                }
                if (res != -1 && baskets[res] >= fruits[i])
                {
                    Update(1, 0, m - 1, res, int.MinValue);
                }
                else
                {
                    count++;
                }
            }
            return count;
        }
    }
}
