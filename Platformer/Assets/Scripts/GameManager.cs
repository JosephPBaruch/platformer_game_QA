using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public int numCoinsCollected = 0;
    public int numRubiesCollected = 0;
    public int numCoinsInLevel = 11;
    public ScoreBar scoreBar;
    string sceneName;
    [SerializeField] GameObject endScreen;
    [SerializeField] GameObject lose;
    [SerializeField] GameObject win;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        numCoinsCollected = 0;
        numRubiesCollected = 0;
        // get the current scene so we can reload it when we want to
        sceneName = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        // makes it so the user can restart the game whenever they want by pressing r
        if( Input.GetKeyDown("r") ){
            RestartGame();
        }
    }

    // Add coin value to score
    public void AddScore(int value) {
        score += value;
        numCoinsCollected += 1;
        scoreBar.UpdateScoreBar(numCoinsCollected);
        CheckEndGame();
    }

    // Ends game when all coins have been collected
    public void CheckEndGame() {
        if (numCoinsCollected == numCoinsInLevel) {
            EndGame();
        }
    }

    // Ends game
    public void EndGame() {
        endScreen.SetActive(true);
        if (numCoinsCollected == numCoinsInLevel)
        {
            win.SetActive(true) ;
        }
        else
        {
            lose.SetActive(true);
        }

        GameObject.FindWithTag("Player").SetActive(false);
        Time.timeScale = 0;
    }

    // Add coin value to score
    public void AddNumRubies() {
        Debug.Log(numRubiesCollected);
        numRubiesCollected += 1;
    }

    // get number of rubies collected
    public int GetRubies() {
        return numRubiesCollected;
    }

    // get number of coins collected
    public int GetCoins() {
        return numCoinsCollected;
    }

    // reload the scene to the original state
    public void RestartGame() {
        SceneManager.LoadScene( sceneName );
    }
}