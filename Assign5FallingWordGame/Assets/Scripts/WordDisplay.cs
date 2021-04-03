﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{
    public Text text;
    public static float fallSpeed = 50;

    public void SetWord(string word)
    {
        text.text = word;
    }

    public void RemoveLetter()
    {
        text.text = text.text.Remove(0, 1);
        text.color = Color.red;
    }

    public void RemoveWord()
    {
        Destroy(gameObject);
        Score.score++;
    }
    public void AdjustSpeed(float newSpeed)
    {
        fallSpeed = newSpeed;
    }

    void Update()
    {
        transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        NumTries.tries--;
        SetWord(text.text);
    }
}
