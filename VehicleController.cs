using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleController : MonoBehaviour
{
    public float speed;
    public float steerSpeed;
    public bool isMoving = false;
    private float accelerate;
    private float steer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        accelerate = Input.GetAxis("Vertical");
        steer = Input.GetAxis("Horizontal");
        
        //making sure if the vehicle is in motion
        if(accelerate == 0){
            isMoving = false;
        }else{
            isMoving = true;
        }
        
        //vehicle acceleration
        transform.Translate(Vector3.forward * accelerate * Time.deltaTime * speed);
        
        //steer only when the vehicle is in motion
        if(isMoving){
            transform.Rotate(Vector3.up * steer * Time.deltaTime * steerSpeed);
        } 
    }
}
