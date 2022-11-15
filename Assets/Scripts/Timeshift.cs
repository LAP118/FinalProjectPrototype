using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timeshift : MonoBehaviour
{

    [SerializeField]
    protected Game_State Gstate;
    [SerializeField]
    protected UI ui;
    [SerializeField]
    protected GameObject Past;
    [SerializeField]
    protected GameObject Present;
    [SerializeField]
    protected GameObject Future;



    // Start is called before the first frame update
    void Start()
    {
        Past.SetActive(false);
        Present.SetActive(true);
        Future.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))                          //if 1 is pressed it goes to the past
        {
            PastPress();
        }
        
        if (Input.GetKeyDown("2"))                          //if 2 is pressed it goes to the present
        {
            PresentPress();
        }
        
        if (Input.GetKeyDown("3"))                          //if 3 is pressed it goes to the future
        {
            FuturePress();
        }

        
    }


    public void PastPress()                                 //doesn't work during the intro period but it enables the past and disables the present and future
    {
        if (Time.time < 5f)
        {
            return;
        }

        if (Gstate.state == PlayState.Playing)
        {
            Past.SetActive(true);
            Present.SetActive(false);
            Future.SetActive(false);
            ui.PeriodMessageField.text = "Past";
        }
       
    }

    public void PresentPress()                                 //doesn't work during the intro period but it enables the present and disables the past and future
    {
        if (Time.time < 5f)
        {
            return;
        }

        if (Gstate.state == PlayState.Playing)
        {
            Past.SetActive(false);
            Present.SetActive(true);
            Future.SetActive(false);
            ui.PeriodMessageField.text = "Present";
        }

    }

    public void FuturePress()                                 //doesn't work during the intro period but it enables the future and disables the present and past
    {
        if (Time.time < 5f)
        {
            return;
        }

        if (Gstate.state == PlayState.Playing)
        {
            Past.SetActive(false);
            Present.SetActive(false);
            Future.SetActive(true);
            ui.PeriodMessageField.text = "Future";
        }

    }







}
