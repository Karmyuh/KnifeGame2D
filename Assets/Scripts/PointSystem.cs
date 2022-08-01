using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PointSystem : MonoBehaviour
{
    public static int scoreValue = 0;
    
    public TextMeshProUGUI _scoreText;

    private void Start()
    {
        _scoreText = GetComponent<TextMeshProUGUI>();
        
    }

    private void Update()
    {
        _scoreText.text = "Score: " + scoreValue;
    }

}
