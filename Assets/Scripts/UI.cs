using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField]
    protected Chest chest;
    [SerializeField]
    protected TextMeshProUGUI ScoreMessageField;

    private int _score = 0;


    void Start()
    {
        
    }

    
    void Update()
    {
        
    }


    public int score
    {
        get
        {
            return _score;
        }
        set
        {
            _score = value;
            ScoreMessageField.text = "Score: " + _score.ToString();
        }
    }

    





}
