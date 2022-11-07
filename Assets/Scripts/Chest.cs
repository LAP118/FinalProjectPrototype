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

    public void OnTriggerEnter(Collider entered)
    {
        GetChestMessage();
        ui.score = ui.score + 1;
    }

    private void GetChestMessage()
    {
        ui.ChestGetField.gameObject.SetActive(true);
        ui.ChestGetField.text = "You got a chest!";





    }






}
