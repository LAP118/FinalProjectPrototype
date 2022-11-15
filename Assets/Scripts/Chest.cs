using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{

    [SerializeField]
    protected UI ui;
    [SerializeField]
    protected GameObject ChestPrefab;
    [SerializeField]
    protected CoRoutines Coroute;


    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider entered)
    {
        GetChestMessage();
        ui.score = ui.score + 1;
        ChestPrefab.gameObject.SetActive(false);
    }

    private void GetChestMessage()
    {
        ui.ChestGetField.gameObject.SetActive(true);
        ui.ChestGetField.text = "You got a chest!";
        StartCoroutine(Coroute.doMove(Coroute.LerpTarget, Coroute.StartPoint.position, Coroute.EndPoint.position, Coroute.Duration, Coroute.StartDelay));




    }






}
