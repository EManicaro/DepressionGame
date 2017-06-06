using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DoorScript : MonoBehaviour {
    
    private bool _isInsideTrigger = false;
    private GameObject touchingDoor;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "door")
        {
            _isInsideTrigger = true;
            touchingDoor = other.gameObject;
        }
        
    }
    

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "door")
        {
            touchingDoor.GetComponentInChildren<Animator>().SetBool("open", false);
            touchingDoor.GetComponent<AbstractDoorAction>().DoorAction();

            _isInsideTrigger = false;
            touchingDoor = null;
        }
    }

    
    // Update is called once per frame
    void Update () {

        if(_isInsideTrigger)
        {
            if(Input.GetKeyDown(KeyCode.Return))
            {
                touchingDoor.GetComponentInChildren<Animator> ().SetBool("open", true);
                touchingDoor.GetComponent<AbstractDoorAction>().DoorAction();
            }
        }

       

    }
}
