using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger : MonoBehaviour
{
    // target for reference
    public GameObject Message1;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Choice")
        {
			other.GetComponent<ChoiceManager>().Trigger();
        }

        if (other.tag == "Message1")
        {
            Message1.SetActive(true);
        }
    }



    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Message1")
        {
            Message1.SetActive(false);
        }
    }


}