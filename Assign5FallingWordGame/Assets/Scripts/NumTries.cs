using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NumTries : MonoBehaviour
{
   public Text triesText;
    public static int tries = 5;

    void Update()
    {
        if (tries == 0)
        {
            SceneManager.LoadScene(2);
        }
        else
        {
            triesText.text = tries.ToString();

        }
    }
}
