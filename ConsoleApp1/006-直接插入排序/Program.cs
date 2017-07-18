using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_直接插入排序
{
    class Program
    {
        static void InsertSort(int[] dataArray)
        {
            for (int i = 0; i < dataArray.Length; i++)
            {
                int iValue = dataArray[i];
                bool isInsert = false;
                //拿到i位置的元素，跟前面所有的元素作比较
                //如果法线比i大，就让它向后移动
                for (int j = i-1; j >=0; j--)
                {
                    if (dataArray[j] > iValue)
                    {
                        dataArray[j + 1] = dataArray[j];
                    }
                    else
                    {
                        //法线一个比i小的值，就不移动了
                        dataArray[j+1] = iValue;
                        isInsert = true;
                        break;
                    }
                }
                if (isInsert == false)
                {
                    dataArray[0] = iValue;
                }
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
