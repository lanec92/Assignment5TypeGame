using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NumTries : MonoBehaviour
{
   public Text triesText;
    public GameObject endText;
    public GameObject wordPrfab;
    public static int tries = 5;

    void Update()
    {
        if (tries <= 0)
        {
            triesText.text = 0.ToString();
            endText.SetActive(true);
            Time.timeScale = 0f;
            DeleteAllObj();
        }
        else
        {
            triesText.text = tries.ToString();
            endText.SetActive(false);


        }
    }

    public void DeleteAllObj()
    {
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Word");
        foreach (GameObject target in gameObjects)
        {
            GameObject.Destroy(target);
        }
        {

        }
    }
}
