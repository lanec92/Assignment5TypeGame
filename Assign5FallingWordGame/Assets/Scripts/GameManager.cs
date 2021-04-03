using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

   public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
        Debug.Log("Game Saved!");
    }
    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        Debug.Log("Loaded Game w/" + data.currScore + " " + data.currTries);
        Score.score = data.currScore;
        NumTries.tries = data.currTries;
        WordDisplay.fallSpeed = data.currSpeed;

    }

    public void SaveAsJSON()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        string json = JsonUtility.ToJson(data);
        Debug.Log("Saving as JSON: " + json);
    }
}
