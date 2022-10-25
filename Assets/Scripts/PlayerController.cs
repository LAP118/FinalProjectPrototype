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
    
    // Start is called before the first frame update
    protected void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    protected void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        float side = Input.GetAxis("Horizontal");
        float forward = Input.GetAxis("Vertical");

        float turn = mouseX * Time.deltaTime * mouseSpeed;
        float tilt = mouseY * Time.deltaTime * mouseSpeed * -1;

        tilt = Mathf.Clamp(tilt, -80, 80);

        float y = -9.8f * Time.deltaTime;

        float x = side * moveSpeed * Time.deltaTime;
        float z = forward * moveSpeed * Time.deltaTime;

        cam.localEulerAngles += new Vector3(tilt, 0, 0);

        controller.Move(transform.TransformDirection(new Vector3(x, y, z)));

        transform.eulerAngles += new Vector3(0, turn, 0);






    }





}
