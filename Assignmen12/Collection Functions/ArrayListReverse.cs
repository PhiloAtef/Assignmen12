﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmen12.ReverseArrayList
{
    internal class ArrayListReverse
    {
        public static void ReverseArrayList(ArrayList list)
        {
            int left = 0;
            int right = list.Count - 1;

            while (left < right)
            {
                var temp = list[left];
                list[left] = list[right];
                list[right] = temp;
                left++;
                right--;
            }
        }
    }
}