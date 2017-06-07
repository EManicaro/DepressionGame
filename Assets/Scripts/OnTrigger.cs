using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger : MonoBehaviour
{
    // target for reference
    public GameObject Message1;
    public GameObject YesAnswer;
    public GameObject NoAnswer;

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

        if (other.tag == "Yes")
        {
            YesAnswer.SetActive(true);
        }

        if (other.tag == "No")
        {
            NoAnswer.SetActive(true);
        }
    }



    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Message1")
        {
            Message1.SetActive(false);
        }

        if (other.tag == "Yes")
        {
            YesAnswer.SetActive(false);
        }

        if (other.tag == "No")
        {
            NoAnswer.SetActive(false);
        }
    }


}