using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    void Update()
    {
        float value = (float) Math.Round(player.position.z, 0);
        scoreText.text = value.ToString() + " m";
    }
}
