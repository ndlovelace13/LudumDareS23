using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class gameState : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Camera endgameCam;
    [SerializeField] GameObject ingameCanvas;
    [SerializeField] GameObject endgameCanvas;
    [SerializeField] GameObject gameTimer;
    [SerializeField] TMPro.TMP_Text finalScoreText;
    public double score;
    public bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        score = player.GetComponent<pizzaActivation>().score;
        if (gameOver)
            endgame();
    }

    void endgame()
    {
        player.SetActive(false);
        endgameCam.enabled = true;
        endgameCanvas.SetActive(true);
        finalScoreText.text = "Your Payday: $" + score;
        GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag("pepperoni");
        foreach (GameObject gameObject in gameObjectArray)
        {
            gameObject.SetActive(false);
        }
    }
}
