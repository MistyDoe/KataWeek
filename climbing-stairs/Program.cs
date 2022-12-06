

public class Solution
{
	public int ClimbStairs (int n)
	{
		Dictionary<int, int> dict = new Dictionary<int, int>();
		if ( n < 0 )
			return 0;
		if ( n == 0 || n == 1 )
			return 1;
		if ( dict.ContainsKey(n) )
			return dict[n];
		dict[n] = ClimbStairs(n - 1) + ClimbStairs(n - 2);
		return dict[n];
	}

}
