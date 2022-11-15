using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class IntroScript : MonoBehaviour
{

    [SerializeField]
    protected TextMeshProUGUI IntroMessageField;




    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void Update()
    {
        Ballmunch();
    }

    protected void Ballmunch()                                              //Hides the intro message after the intro period
    {
       if (Time.time > 5f)
       {
            IntroMessageField.gameObject.SetActive(false);
       } 
    }





}
