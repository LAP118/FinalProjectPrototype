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
    public TextMeshProUGUI ChestGetField;
    [SerializeField]
    protected TextMeshProUGUI GameOverMessageField;
    [SerializeField]
    protected TextMeshProUGUI StateMessageField;
    [SerializeField]
    public TextMeshProUGUI PeriodMessageField;
    [SerializeField]
    protected Toggle checkbox;
    [SerializeField]
    protected Button BUton;


    private int _score = 0;


    void Start()
    {
        
    }

    
    void Update()
    {
        HideTextIntro();
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

   

    public void Updatetext()                                           //sets the game over text to show if it's in the game over state or hide if it isn't
    {
        if (Gstate.state == PlayState.GameOver)
        {
            GameOverMessageField.gameObject.SetActive(true);
            GameOverTextUpdate();
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
        if (Time.time < 5f)
        {
            return;
        }

        if (Gstate.state == PlayState.GameOver)
        {
            
        }
        else
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
        
    }

    protected void GameOverTextUpdate()
    {
        GameOverMessageField.text = "Game Over! You got " + score + " chest(s).";
        if (Gstate.state == PlayState.GameOver)
        {
            StateMessageField.text = "It's Over";
        }
    }

    protected void HideTextIntro()
    {
        if (Time.time < 5f)
        {
            ScoreMessageField.gameObject.SetActive(false);
            StateMessageField.gameObject.SetActive(false);
            PeriodMessageField.gameObject.SetActive(false);
            checkbox.gameObject.SetActive(false);
            BUton.gameObject.SetActive(false);
            
        }
        if (Time.time > 5f)
        {
            ScoreMessageField.gameObject.SetActive(true);
            StateMessageField.gameObject.SetActive(true);
            PeriodMessageField.gameObject.SetActive(true);
            checkbox.gameObject.SetActive(true);
            BUton.gameObject.SetActive(true);

        }
    }
    


}
