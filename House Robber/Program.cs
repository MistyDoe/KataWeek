public class Solution
{
	public int Rob (int[] nums)
	{
		if ( nums == null || nums.Length == 0 )
		{
			return 0;
		}

		var firstPrev = 0;
		var secondPrev = 0;
		var current = 0;

		for ( var i = 0; i < nums.Length; i++ )
		{
			secondPrev = firstPrev;
			firstPrev = current;
			current = Math.Max(firstPrev, secondPrev + nums[i]);
		}

		return current;

	}
}