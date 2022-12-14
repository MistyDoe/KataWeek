

internal class Program
{
	private static void Main (string[] args)
	{
		long MostPoints (int[][] questions)
		{

			var points = new long[questions.Length];
			points[points.Length - 1] = questions[questions.Length - 1][0];

			for ( int i = questions.Length - 2; i >= 0; i-- )
			{

				int nextQuestion = questions[i][1] + i + 1;

				long possiblePoints = questions[i][0];
				if ( nextQuestion < questions.Length )
					possiblePoints += points[nextQuestion];

				points[i] = Math.Max(possiblePoints, points[i + 1]);
			}

			return points[0];
		}
	}
}