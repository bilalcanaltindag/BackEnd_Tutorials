using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankExample
{
    class Result
    {

        

            /*
             * Complete the 'maxPosPrefixes' function below.
             *
             * The function is expected to return an INTEGER.
             * The function accepts INTEGER_ARRAY arr as parameter.
             */

            public static int maxPosPrefixes(List<int> arr)
            {
                int b = 0;
                int z = 0;
                int temp;
                while (b < arr.Count)
                {
                    while (arr[z] != null)
                    {
                        if (arr[z + 1] > arr[z])
                        {
                            temp = arr[z];
                            arr[z] = arr[z + 1];
                            arr[z + 1] = temp;
                        }
                        z++;
                    }
                    z = 0;
                    b++;
                }

                List<int> tempList = new List<int>();
                tempList[0] = arr[0];

                int c = 1;
                for (int i = 0; i < arr.Count; i++)
                {
                    arr[c] = arr[c] + arr[i];
                    tempList[c] = arr[c];
                    c++;
                }

                int result = 0;
                for (int k = 0; k < tempList.Count; k++)
                {
                    if (tempList[k] > 0)
                    {
                        result = result + 1;

                    }
                }

                if (result != 0)
                {
                    for (int y = 0; y < tempList.Count; y++)
                    {
                        if (tempList[y] == 0)
                        {
                            result = result + 1;
                        }
                    }
                }

                return result;


            }

        

    }
}
