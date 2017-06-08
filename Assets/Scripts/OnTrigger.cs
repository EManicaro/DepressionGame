using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Choice")
        {
			other.GetComponent<ChoiceManager>().Trigger();
        }

        if (other.tag == "Hover")
        {
            other.GetComponent<ChoiceManager>().Trigger(false);
        }
    }



    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Hover")
        {
            other.GetComponent<ChoiceManager>().Trigger();
        }
    }


}