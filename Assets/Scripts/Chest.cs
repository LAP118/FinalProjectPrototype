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
    private float messageDelay;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider entered)
    {
        ui.Showmessagechest(messageDelay);
        ui.score = ui.score + 1;
        ChestPrefab.gameObject.SetActive(false);
        


    }

    






}
