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
    protected Game_State Gstate;
    [SerializeField]
    protected TextMeshProUGUI ScoreMessageField;
    [SerializeField]
    protected TextMeshProUGUI ChestGetField;
    [SerializeField]
    protected TextMeshProUGUI GameOverMessageField;
    [SerializeField]
    protected TextMeshProUGUI StateMessageField;
    [SerializeField]
    protected Toggle checkbox;

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

    private void GetChestMessage()
    {
        
       
            //ChestGetField.gameObject.SetActive(true);
            //ChestGetField.text = "You got a chest!";
      


    }

    public void Updatetext()                                           //sets the game over text to show if it's in the game over state or hide if it isn't
    {
        if (Gstate.state == PlayState.GameOver)
        {
            GameOverMessageField.gameObject.SetActive(true);
            GameOverScore();
        }
        if (Gstate.state == PlayState.Paused)
        {
            GameOverMessageField.gameObject.SetActive(false);
        }
        if (Gstate.state == PlayState.Playing)
        {
            GameOverMessageField.gameObject.SetActive(false);
        }
    }


    public void PauseClick()                                    //changes the state to paused and back to playing if the check box is toggled
    {
        if (checkbox.isOn)
        {
            StateMessageField.text = "It's Playing";
            Gstate.state = PlayState.Playing;
        }
        else
        {
            StateMessageField.text = "It's Paused";
            Gstate.state = PlayState.Paused;
        }
    }

    protected void GameOverScore()
    {
        GameOverMessageField.text = "Game Over! You got " + score + " chest(s).";
    }

}
