using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{

    [SerializeField]
    protected Game_State Gstate;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
 
    
    
    
    
    }


    public void OnTriggerEnter (Collider entered)
    {
        Gstate.state = PlayState.GameOver;
    }


    




}
