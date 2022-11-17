using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour       
{
    [SerializeField]
    protected float mouseSpeed;
    [SerializeField]
    protected float moveSpeed;
    [SerializeField]
    protected Transform cam;
    [SerializeField]
    protected CharacterController controller;
    [SerializeField]
    protected Game_State Gstate;


    private float Tiltreal = 0;

    private float FacingReal = 0;


    // Start is called before the first frame update
    protected void Start()
    {
       
        Cursor.lockState = CursorLockMode.Locked;

        
    }

    // Update is called once per frame
    protected void Update()
    {

        FreezePlayer();

        //if ()



    }

    public void FreezePlayer()                                                  //All the controls for the player character are under this function so that the player can't move during the intro period, the paused state, and the game over state
    {
        if (Gstate.state == PlayState.Playing)
        {
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");

            float side = Input.GetAxis("Horizontal");
            float forward = Input.GetAxis("Vertical");

            float turn = mouseX * Time.deltaTime * mouseSpeed;
            float tilt = mouseY * Time.deltaTime * mouseSpeed * -1;

            float y = -17f * Time.deltaTime;                                    //the gravity is higher because the character was floating down instead of walking like a normal person

            float x = side * moveSpeed * Time.deltaTime;
            float z = forward * moveSpeed * Time.deltaTime;

            if (Time.time < 5f)
            {
                return;
            }

            Tiltreal = tilt;

            Tiltreal = Mathf.Clamp(Tiltreal, -80, 80);

            FacingReal = turn;

            

            cam.localEulerAngles += new Vector3(Tiltreal, 0, 0);

            controller.Move(transform.TransformDirection(new Vector3(x, y, z)));

            transform.eulerAngles += new Vector3(0, FacingReal, 0);
        }
        
        if (Gstate.state == PlayState.Paused)
        {

        }
    
        if (Gstate.state == PlayState.GameOver)
        {

        }
    
    
    
    }



}
