using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    public TextMeshProUGUI scoreDisplay;
    public Player player;
    public TextMeshProUGUI highScore;
    public TextMeshProUGUI highFinalScore;

    private void Start()
    {
        highScore.text = PlayerPrefs.GetInt("Highscore", 0).ToString();
        highFinalScore.text = "highscore: " + PlayerPrefs.GetInt("Highscore", 0).ToString();
    }

    void Update()
    {
        int healthNu = player.GetComponent<Player>().health;
        scoreDisplay.text = score.ToString();

        if (Input.GetKeyDown(KeyCode.R))
        {
            Reset();
        }
    }
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if ((player.health > 0) && (other.CompareTag("obstacle"))){ 
        score++;
        Destroy(other.gameObject);
            if (score > PlayerPrefs.GetInt("Highscore", 0))
            {
                PlayerPrefs.SetInt("Highscore", score);
                highScore.text = score.ToString();
                highFinalScore.text = "highscore: " + highScore.text;
                
            }
        }
    
    }

    public void Reset()
    {
        PlayerPrefs.DeleteKey("Highscore");
        highScore.text = "0";
        highFinalScore.text = "highscore: " + highScore.text;
    }



    // Update is called once per frame

}
