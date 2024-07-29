using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CollecterScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score;

    void IncreaseScore() {
        score++;
        scoreText.text = "Score : "+ score;
    }

   void OnTriggerEnter2D(Collider2D target){
    if(target.tag=="Bomb"){
        IncreaseScore();
        target.gameObject.SetActive(false);
    }
   }
}
