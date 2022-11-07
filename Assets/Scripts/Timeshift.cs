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
        if (Input.GetKeyDown("1"))
        {
            PastPress();
        }
        
        if (Input.GetKeyDown("2"))
        {
            PresentPress();
        }
        
        if (Input.GetKeyDown("3"))
        {
            FuturePress();
        }

        
    }


    public void PastPress()
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

    public void PresentPress()
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

    public void FuturePress()
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
