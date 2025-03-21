using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCAD17MenteeGroup
{
    public static class DutchFlag
    {
        // Given an array nums with n objects colored red(0), white(1), or blue(2), sort them
        public static int[] Solution(int[] givenData)
        {
            // given array being empty- []
            if (givenData.Length == 0)
            {
                return [];
            }

            int zeroPointer = 0;
            int onePointer = 0;
            int twoPointer = givenData.Length - 1;
            // [1,1,2,0,1,1]
            while (onePointer < twoPointer)
            {
                if (givenData[onePointer] == 0)
                {
                    var temp = givenData[zeroPointer];
                    givenData[zeroPointer] = givenData[onePointer];
                    givenData[onePointer] = temp;
                    zeroPointer++;
                    onePointer++;
                }
                else if (givenData[onePointer] == 1)
                {
                    onePointer++;
                }
                else
                {
                    var temp = givenData[onePointer];
                    givenData[onePointer] = givenData[twoPointer];
                    givenData[twoPointer] = temp;
                    twoPointer--;
                }
            }

            return givenData;
        }
    }
}
