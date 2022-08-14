using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static int _score;
    TextMeshProUGUI _scoreText;
  
    void Start()
    {
        _scoreText = GetComponent<TextMeshProUGUI>();

    }
    void Update()
    {
        _scoreText.text = "" + _score;
    }
}
