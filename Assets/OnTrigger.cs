using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger : MonoBehaviour
{
    // target for reference
    public GameObject choice1;
    public GameObject choice2;
    public GameObject choice3;
    public GameObject choice4;
    public GameObject choice5;
    public GameObject choice6;
    public GameObject choice7;
    public GameObject choice8;
    public GameObject choice9;
    public GameObject choice10;
    public GameObject Message1;

    public void Start()
    {
        choice1.SetActive(false);
        choice2.SetActive(false);
        choice3.SetActive(false);
        choice4.SetActive(false);
        choice5.SetActive(false);
        choice6.SetActive(false);
        choice7.SetActive(false);
        choice8.SetActive(false);
        choice9.SetActive(false);
        choice10.SetActive(false);
        Message1.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Alarm")
        {
            choice1.SetActive(true);
        }

        if (other.tag == "Bed")
        {
            choice2.SetActive(true);
        }


        if (other.tag == "BathroomBasin")
        {
            choice3.SetActive(true);
        }

        if (other.tag == "Toilet")
        {
            choice4.SetActive(true);
        }

        if (other.tag == "CoffeeMachine")
        {
            choice5.SetActive(true);
        }

        if (other.tag == "KitchenBasin")
        {
            choice6.SetActive(true);
        }

        if (other.tag == "Sofa")
        {
            choice7.SetActive(true);
        }

        if (other.tag == "WorkDesk")
        {
            choice8.SetActive(true);
        }

        if (other.tag == "ArmChairsWork")
        {
            choice9.SetActive(true);
        }

        if (other.tag == "CoffeeMachineWork")
        {
            choice10.SetActive(true);
        }

        if (other.tag == "Message1")
        {
            Message1.SetActive(true);
        }
        GameObject.FindObjectOfType<camMouseLook>().CanPlayerLook(false);
    }



    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Alarm")
        {
            choice1.SetActive(false);
        }

        if (other.tag == "Bed")
        {
            choice2.SetActive(false);
        }

        if (other.tag == "BathroomBasin")
        {
            choice3.SetActive(false);
        }

        if (other.tag == "Toilet")
        {
            choice4.SetActive(false);
        }

        if (other.tag == "CoffeeMachine")
        {
            choice5.SetActive(false);
        }

        if (other.tag == "KitchenBasin")
        {
            choice6.SetActive(false);
        }

        if (other.tag == "Sofa")
        {
            choice7.SetActive(false);
        }

        if (other.tag == "WorkDesk")
        {
            choice8.SetActive(false);
        }

        if (other.tag == "ArmChairsWork")
        {
            choice9.SetActive(false);
        }

        if (other.tag == "CoffeeMachineWork")
        {
            choice10.SetActive(false);
        }

        if (other.tag == "Message1")
        {
            Message1.SetActive(false);
        }

        GameObject.FindObjectOfType<camMouseLook>().CanPlayerLook(true);
    }


}