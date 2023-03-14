using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scr_score_text : MonoBehaviour
{

    public TMP_Text scoreText;
    public int scoreNumber;

    void Start()
    {
        
        scoreNumber = 0;
        scoreText.text = "Score : " + scoreNumber;

    }

  private void OnCollisionEnter(Collision collision) {

        if (collision.gameObject.name == "Coin") 
        
        {
            scoreNumber +=1;
            scoreText.text = "Score : " + scoreNumber;

        }
        
        }

}
