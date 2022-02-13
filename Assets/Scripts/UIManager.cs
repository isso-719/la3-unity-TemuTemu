using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;

    public Text comboText;
    public float timer = 0;
    public float comboTimer = 5f;
    public int combo = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score\t: " + score.ToString();
        comboText.text = "Combo\t: " + combo.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (combo > 0)
        {
            timer += Time.deltaTime;

            if (timer > comboTimer)
            {
                timer = 0;
                combo = 0;
                comboText.text = "Combo\t: " + combo.ToString();
            }
        }
    }

    public void AddPoint(int point)
    {
        timer = 0;
        combo++;
        score += point * combo;
        scoreText.text = "Score\t: " + score.ToString("#,0.###");
        comboText.text = "Combo\t: " + combo.ToString();
    }

    public void ScoreReset()
    {
        score = 0;
        combo = 0;
        timer = 0;

        scoreText.text = "Score\t: " + score.ToString("#,0.###");
        comboText.text = "Combo\t: " + combo.ToString();
    }
}
