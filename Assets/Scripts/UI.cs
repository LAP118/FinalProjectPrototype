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
    protected TextMeshProUGUI TimeMessageField;
    [SerializeField]
    protected Toggle checkbox;
    [SerializeField]
    protected Button BUton;
    [SerializeField]
    private float timeywimey = 90f;

    private int _score = 0;
    

    void Start()
    {
        Timerparent();
    }

    
    void Update()                                                       //updates every frame
    {
        HideTextIntro();
        
    }

   
    public int score                                                    //makes a public value for the private score value so that the private value isn't changed
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
        Debug.Log("Gstate.state = " + Gstate.state.ToString());
        //if (Gstate.state == PlayState.GameOver)
        //{

        //}
        //else
        //{
        //    if (checkbox.isOn)
        //    {
        //        StateMessageField.text = "It's Playing";
        //        Gstate.state = PlayState.Playing;
        //    }
        //    else
        //    {
        //        StateMessageField.text = "It's Paused";
        //        Gstate.state = PlayState.Paused;
        //    }
        //}

        if (Gstate.state == PlayState.Playing)
        {
            Debug.Log("Pausing");
            Gstate.state = PlayState.Paused;
            StateMessageField.text = "It's Paused";
        }

        else if (Gstate.state == PlayState.Paused)
        {
            Debug.Log("Unpausing");
            Gstate.state = PlayState.Playing;
            StateMessageField.text = "It's Playing";
        }


    }

    protected void GameOverTextUpdate()                     //shows the game over text when the state is in the game over state
    {
        GameOverMessageField.text = "Game Over! You got " + score + " chest(s).";
        if (Gstate.state == PlayState.GameOver)
        {
            StateMessageField.text = "It's Over";
        }
    }

    protected void HideTextIntro()                          //Hides the the ui while the introtext is up
    {
        if (Time.time < 5f)
        {
            ScoreMessageField.gameObject.SetActive(false);
            StateMessageField.gameObject.SetActive(false);
            PeriodMessageField.gameObject.SetActive(false);
            checkbox.gameObject.SetActive(false);
            BUton.gameObject.SetActive(false);
            TimeMessageField.gameObject.SetActive(false);
            
        }
        if (Time.time > 5f)
        {
            ScoreMessageField.gameObject.SetActive(true);
            StateMessageField.gameObject.SetActive(true);
            PeriodMessageField.gameObject.SetActive(true);
            //checkbox.gameObject.SetActive(true);
            BUton.gameObject.SetActive(true);
            TimeMessageField.gameObject.SetActive(true);

        }
    }

    public void Showmessagechest(float DElay)               //starts the chest coroutine
    {
        StartCoroutine(GetChestMessage(DElay));
    }

    private IEnumerator GetChestMessage(float DElay)            //CoRoutine for the chest message to dissear after 2 seconds
    {
        Debug.Log("Chest Message Shown");

        ChestGetField.gameObject.SetActive(true);

        Debug.Log("messageDelay = " + DElay.ToString("F1"));

        ChestGetField.text = "You got a chest!";

        yield return new WaitForSeconds(DElay);

        ChestGetField.gameObject.SetActive(false);

        Debug.Log("Chest Message Hidden");


        yield break;
    }

    private IEnumerator Timer()                                        //Timer for the game
    {
        //if (Time.time == Time.deltaTime - 1)
        //{
        //    TimeMessageField.text = (timeywimey).ToString("F1");
        //    timeywimey = timeywimey - 1f;
        //}

        //if (timeywimey == 0)
        //{
        //    Gstate.state = PlayState.GameOver;
        //}

        while (Time.time < 5f)
        {
            yield return null;
        }


        while (timeywimey >= 0)
        {
            TimeMessageField.text = (timeywimey).ToString("F1");
            if (Gstate.state == PlayState.Playing)
            {
                timeywimey = timeywimey - Time.deltaTime;

            }
            Debug.Log(timeywimey);
            yield return null;
        }

        Gstate.state = PlayState.GameOver;

    }

    private void Timerparent()
    {
       
        
       StartCoroutine(Timer());
        
    }



}
