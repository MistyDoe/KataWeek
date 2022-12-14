public static class TimeFormat
{
	public static string GetReadableTime (int seconds)
	{
		int hours = seconds / 3600;
		var left = seconds - (hours * 3600);
		int mins = left / 60;
		var sec = left - (mins * 60);
		string res = $"{hours:D2}:{mins:D2}:{sec:D2}";

		return res;

	}
}