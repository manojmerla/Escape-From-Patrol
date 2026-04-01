using UnityEngine;
using System;

public class scoremanger : MonoBehaviour
{
    public int Score = 0;
    public static scoremanger instance;
    public event Action<int> OnScorechanged;

    void Awake()
    {
        instance = this;
    }

    public void Addscore(int value)
    {
        Score += value;
        OnScorechanged?.Invoke(Score);
    }
}