using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dynamics : MonoBehaviour
{

    public Rigidbody Reference_Rigidbody;
    public int Newtons;


    // Start is called before the first frame update
    void Start()
    {
        //This text is sent to the Debug Log to let you know everything is running fine...

        Debug.Log("Script Running Smoothly...");
        Debug.Log("Version 1.0");
        Debug.Log("Developer Notes: Messing with the Dynamics.");
    }

    // Update is called once per frame
    void Update()
    {
        //It is currently 12:30AM, I will switch this with a switch statemet
        //Using accessors later...

        //Here we check for the key code
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            //This was written before the function...
            //Reference_Rigidbody.AddForce(new Vector3(0, 1, 0) * Newtons);


            ForceAndMessage(Reference_Rigidbody, 0, 1, 0, "Vector Force <0 1 0>");

        }else if(Input.GetKeyDown(KeyCode.DownArrow)){

            ForceAndMessage(Reference_Rigidbody, 0, -1, 0, "Vector Force <0 -1 0>");

        }else if(Input.GetKeyDown(KeyCode.LeftArrow)){

            ForceAndMessage(Reference_Rigidbody, -1, 0, 0, "Vector Force <-1 0 0>");

        }else if(Input.GetKeyDown(KeyCode.RightArrow)){

            ForceAndMessage(Reference_Rigidbody, 1, 0, 0, "Vector Force <1 0 0>");
        }

        /*
        Applying a force of arbitrary Newtowns across the vectors.
        note to my future self to do more research on the Rigidbody
        Class and learn the Physics engine on Unity.

        Im only going to be a kid once, better make it count.
        */


    }

    //This function applies a force and sends a debug message for me
    //Takes a Rigidbody, int, and string as a parameter
    void ForceAndMessage(Rigidbody Rig_Param, int X, int Y, int Z, string Message){

        //Sends the debug message...
        Debug.Log(Message);

        //Applies the force
        Rig_Param.AddForce(new Vector3(X, Y, Z) * Newtons);
    }
}
