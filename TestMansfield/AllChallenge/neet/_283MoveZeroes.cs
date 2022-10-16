public class _283MoveZeroes
{
    public void MoveZeroes(int[] nums)
    {

        if (nums.Length <= 1) return;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] != 0 && nums[i] == 0)
                    {
                        nums[i] = nums[j];
                        nums[j] = 0;
                    }
                }
            }
        }

        Console.WriteLine(string.Join(",", nums));

    }

    public void MoveZeroesDoublePoints(int[] nums)
    {

        if (nums.Length == 1) return;

        int p1 = 0, p2 = 1;
        while (p2 < nums.Length)
        {
            if (nums[p1] == 0 && nums[p2] != 0)
            {
                nums[p1] = nums[p2];
                nums[p2] = 0;
            }
            
            if (nums[p1] != 0) p1++;

            p2++;
        }
    }
}