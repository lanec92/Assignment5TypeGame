using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SendHighScore : MonoBehaviour
{
    public InputField playername;
    public Button button;
    public static string playernamestr;

    public void setPlayerName ()
    {
        Debug.Log("playerName is :" + playername.text);
        playernamestr = playername.text;
    }
    public void sendData()
    {
        if(playernamestr == "")
        {
            button.interactable = false;
        }
        HighScoreTable.AddHighscoreEntry(Score.score, playernamestr);
        SceneManager.LoadScene(2);
    }
}
