using Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CommonStatistic
{
    public class BasicStatistic
    {
        // Get medium number
        public static T GetMediumElement<T>(List<T> list, IComparer<T> comparer = null)
        {
            if (comparer == null)
            {
                comparer = Comparer<T>.Default;
            }

            var element = GetKthSmallestElement(list, list.Count / 2, comparer);

            return element;
        }

        // Get Kth small number
        public static T GetKthSmallestElement<T>(List<T> list, int k, IComparer<T> comparer = null)
        {
            if (comparer == null)
            {
                comparer = Comparer<T>.Default;
            }

            var lo = 0; var hi = list.Count - 1;
            while (lo < hi)
            {
                var pivot = Partition(list, lo, hi, comparer);
                if (pivot == k - 1)
                {
                    break;
                }
                if (pivot < k - 1)
                {
                    lo = pivot + 1;
                }
                else
                {
                    hi = pivot - 1;
                }
            }

            return list[k - 1];
        }


        // Get Kth large number
        public static T GetKthLargestElement<T>(List<T> list, int k, IComparer<T> comparer = null)
        {
            if (comparer == null)
            {
                comparer = Comparer<T>.Default;
            }

            var element = GetKthSmallestElement(list, list.Count + 1 - k, comparer);

            return element;
        }

        private static int Partition<T>(IList<T> list, int lo, int hi, IComparer<T> comparer)
        {
            var part = list[lo];
            while (lo < hi)
            {
                while (lo < hi && comparer.Compare(list[hi], part) < 0)
                {
                    hi--;
                }
                list[lo] = list[hi];
                while (lo < hi && comparer.Compare(list[lo], part) >= 0)
                {
                    lo++;
                }
                list[hi] = list[lo];
            }
            list[lo] = part;

            return lo;
        }
    }
}
