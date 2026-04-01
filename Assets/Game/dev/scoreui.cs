using UnityEngine;
using TMPro;

public class scoreui : MonoBehaviour
{
    public TextMeshProUGUI scoretext;

    void OnEnable()
    {
        if (scoremanger.instance != null)
            scoremanger.instance.OnScorechanged += UpdateScore;
    }

    void OnDisable()
    {
        if (scoremanger.instance != null)
            scoremanger.instance.OnScorechanged -= UpdateScore;
    }

    public void UpdateScore(int score)
    {
        scoretext.text = "Score: " + score;
    }
}