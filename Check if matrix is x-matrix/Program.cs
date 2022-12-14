public class Solution
{
	public bool CheckXMatrix (int[][] grid)
	{
		for ( int i = 0; i < grid.Length; i++ )
		{

			for ( int j = 0; j < grid[i].Length; j++ )
			{
				int dia = grid[i].Length - 1 - i;

				// i==j checks left to right diagonal
				if ( i == j && grid[i][j] == 0 )
				{

					return false;
				}
				// [i][dia] checks right to left diagonal
				if ( grid[i][dia] == 0 )
				{
					return false;
				}
				// checks rest of the positions that are not in an matrixs diagonals
				if ( i != j && j != dia )
				{
					if ( grid[i][j] != 0 )
					{
						return false;
					}
				}
			}

		}
		return true;
	}
}