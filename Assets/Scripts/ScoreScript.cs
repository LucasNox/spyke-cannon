using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreScript : MonoBehaviour
{
    public TMP_Text scoreText;
    public int score;
    public int scoreAux = 10;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddScore()
    {
        score += scoreAux;
        AtualizaUI();
    }

    public void AtualizaUI()
    {
        scoreText.text = "Score: " + score;
    }

}
