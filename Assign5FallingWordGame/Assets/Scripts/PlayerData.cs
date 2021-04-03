using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int currScore;
    public int currTries;
    public float currSpeed;

    public PlayerData(GameManager gm)
    {
        currTries = NumTries.tries;
        currScore = Score.score;
        currSpeed = WordDisplay.fallSpeed;

    }
}