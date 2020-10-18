using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMan : MonoBehaviour
{
    public Text scoreText;
    private int score1;
    private int score2;

    public Text winText;
    public int MaxScore;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
    
        
    }

    // Update is called once per frame
    void Update()
    {
        if(score1 >= MaxScore)
        {
            winText.gameObject.SetActive(true);
            winText.text = "Player 1 WINS";
            ball.SetActive(false);
        }
        else if(score2 >= MaxScore)
        {
          winText.text = "Player 2 WINS";
          ball.SetActive(false);
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }

}

    public void UpdateScore(int player)
    {
       if(player == 1){
           score1 = score1 + 1;
       }
       if(player == 2)
       {
           score2 = score2 + 1;
       }

       scoreText.text = score1 + " - " + score2;
    }

}
