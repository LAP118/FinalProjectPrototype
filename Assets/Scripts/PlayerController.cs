using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour       //this script I am not going to comment because nothing in this script is used the script itself is diabled
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

    
    // Start is called before the first frame update
    protected void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    protected void Update()
    {

        FreezePlayer();





    }

    public void FreezePlayer()
    {
        if (Gstate.state == PlayState.Playing)
        {
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");

            float side = Input.GetAxis("Horizontal");
            float forward = Input.GetAxis("Vertical");

            float turn = mouseX * Time.deltaTime * mouseSpeed;
            float tilt = mouseY * Time.deltaTime * mouseSpeed * -1;

            float y = -15f * Time.deltaTime;                                    //the gravity is higher because the character was floating down instead of walking like a normal person

            float x = side * moveSpeed * Time.deltaTime;
            float z = forward * moveSpeed * Time.deltaTime;

            if (Time.time < 5f)
            {
                return;
            }

            Tiltreal += tilt;

            Tiltreal = Mathf.Clamp(Tiltreal, -80, 80);

            cam.localEulerAngles += new Vector3(tilt, 0, 0);

            controller.Move(transform.TransformDirection(new Vector3(x, y, z)));

            transform.eulerAngles += new Vector3(0, turn, 0);
        }
        
        if (Gstate.state == PlayState.Paused)
        {

        }
    
        if (Gstate.state == PlayState.GameOver)
        {

        }
    
    
    
    }



}
