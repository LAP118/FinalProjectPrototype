using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum PlayState
{

    Playing,
    Paused,
    GameOver

}


public class Game_State : MonoBehaviour
{

    [SerializeField]
    protected PlayState _state;
    [SerializeField]
    protected Chest chest;
    [SerializeField]
    protected UI ui;
    [SerializeField]
    protected PlayerController player;
    [SerializeField]
    protected EndGame endgame;
    [SerializeField]
    protected Timeshift Shift;


    private void Update()                     //This section is basically making three choices of states for the game to be in
    {
        switch (_state)
        {
            case PlayState.Playing:
                state_playing();
                break;

            case PlayState.Paused:
                state_paused();
                break;

            case PlayState.GameOver:
                state_gameOver();
                break;

        }
        ui.Updatetext();
    }

    protected void state_playing()              //this is the function to tell the game to be in the playing state
    {
        Debug.Log("Playing");
       

        Shift.PastPress();
        Shift.PresentPress();
        Shift.FuturePress();
    }

    protected void state_paused()              //this is the function to tell the game to be in the paused state
    {
        Debug.Log("Paused");
        
    }

    protected void state_gameOver()              //this is the function to tell the game to be in the Game over state
    {
        Debug.Log("Game Over");


    }

    public PlayState state                      //Makes a bulic value for the private thing so that the private thing isn't changed
    {
        get
        {
            return _state;
        }
        set
        {
            if (value == PlayState.Paused)
            {
                Debug.LogWarning("Paws");
            }
            _state = value;
        }
    }
}
