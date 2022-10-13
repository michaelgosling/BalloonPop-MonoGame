using System.Collections.Generic;

namespace BalloonPop.Managers;

public class ScoreManager
{
	/** Fields */
	private bool tracking;

	/** Properties */
	public List<int> HighScores { get; private set; }
	public int CurrentScore { get; private set; }


	/// <summary>
	/// Constructor
	/// </summary>
	public ScoreManager()
	{
		HighScores = new List<int>();
	}

	/// <summary>
	/// Start tracking the score
	/// </summary>
	public void StartTracking()
	{
		CurrentScore = 0;
		tracking = true;
	}

	/// <summary>
	/// Increment the score based on the number of matched balloons
	/// </summary>
	/// <param name="numMatched">Number of matched balloons</param>
	/// <returns>the current score after incrementing</returns>
	public int IncrementScore(int numMatched)
	{
		if (tracking && numMatched >= 3)
		{
			if (numMatched > 6) numMatched = 6;
			switch (numMatched)
			{
				case 4:
					CurrentScore += 150;
					break;
				case 5:
					CurrentScore += 250;
					break;
				case 6:
					CurrentScore += 400;
					break;
				default:
					CurrentScore += 100;
					break;
			}
		}
		return CurrentScore;
	}

	/// <summary>
	/// Stop tracking the score and add the score to high scores
	/// </summary>
	public void StopTracking()
	{
		tracking = false;
		HighScores.Add(CurrentScore);
	}
}