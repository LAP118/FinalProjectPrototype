using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{

    [SerializeField]
    protected UI ui;




    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    protected void OnTriggerEnter(Collider entered)
    {





        ui.score = ui.score + 1;
    }








}