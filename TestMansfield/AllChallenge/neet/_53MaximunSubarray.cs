public class _53MaximunSubarray
{

    public int MaxSubArray(int[] nums)
    {

        int temp = -100000;
        int sum = 0;

        if (nums.Length == 1)
            return nums[0];

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            if (sum > temp)
                temp = sum;       

            if (sum < 0)
                sum = 0;
        }


        //Console.WriteLine(temp);
        return temp;
    }

    // public int MaxSubArray(int[] nums)
    // {

    //     int temp = -100000;
    //     int window = 1;
    //     for (int i = window; i <= nums.Length; i++)
    //     {
    //         //Console.WriteLine($"win{i}");
    //         for (int j = 0; j < nums.Length; j++)
    //         {               
    //             int sum = 0;
    //             for( int w = j; (w < j + i && w < nums.Length ); w++){                    
    //                 sum += nums[w];
    //             }
    //            //Console.WriteLine($"+{j}-{j+i-1} sum{sum}");                

    //             if ( sum> temp)
    //                 temp = sum;
    //         }
    //     }

    //     //Console.WriteLine(temp);
    //     return temp;
    // }
}