using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreScript : MonoBehaviour
{
    public TextMeshPro scoreText;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddScore(int scoreAux)
    {
        score += scoreAux;
        AtualizaUI();
    }

    public void AtualizaUI()
    {
        scoreText.text = "Score: " + score;
    }

}
