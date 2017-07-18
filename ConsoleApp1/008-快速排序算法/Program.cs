using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_快速排序算法
{
    class Program { 
    /// <summary>
    /// 对数组，从left到right做排序
    /// </summary>
    /// <param name="dataArray">排序数组</param>
    /// <param name="left">要排序数据的开始索引</param>
    /// <param name="right">结束索引</param>
        static void QuickSort(int[] dataArray,int left,int right){
        if (left < right)
        {
            int x = dataArray[left];//基准数，把比它小或者等于它的放左边。。。
            int i = left;
            int j = right;

                //从后往前作比较（右向左）,i
            while (true&&i<j)
            {
                while (true && i < j)
                {
                    if (dataArray[j] <= x)
                    {
                        dataArray[i] = dataArray[j];
                        break;
                    }
                    else
                    {
                        j--;
                    }
                }
                //从前往后（）j
                while (true && i < j)
                {
                    if (dataArray[i] > x)
                    {
                        dataArray[j] = dataArray[i];
                            break;
                    }
                    else
                    {
                        i++;
                    }
                }
                }
                //跳出循环现在x==j
            dataArray[i] = x;
            QuickSort(dataArray,left,i-1);
            QuickSort(dataArray,i+1,right);

        }
        else
        {
            
        }
    }
        static void Main(string[] args)
        {
        }
    }
}
