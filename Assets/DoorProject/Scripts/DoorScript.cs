using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

    private Animator _animator;


    private bool _isInsideTrigger = false;

	// Use this for initialization
	void Start () {
        _animator = transform.FindChild("Door").GetComponent<Animator>();
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _isInsideTrigger = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            _isInsideTrigger = false;
            _animator.SetBool("open", false);
        }
    }

    
    // Update is called once per frame
    void Update () {

        if(_isInsideTrigger)
        {
            if(Input.GetKeyDown(KeyCode.Return))
            {
                _animator.SetBool("open", true);  
            }
        }

    }
}
