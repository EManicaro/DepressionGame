using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger : MonoBehaviour {
    // target for reference
    public GameObject Getup;
    public GameObject Snooze;
    public GameObject MakeBed;
    public GameObject LeaveBed;
    public GameObject PickRandomClothes;
    public GameObject CoordinateOutfit;

    public void Start()
    {
        Getup.SetActive(false);
        Snooze.SetActive(false);
        MakeBed.SetActive(false);
        LeaveBed.SetActive(false);
        PickRandomClothes.SetActive(false);
        CoordinateOutfit.SetActive(false);
    } 

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Alarm")
        {
            Snooze.SetActive(true);
            Getup.SetActive(true);
        }

        if (other.tag == "Bed")
        {
            MakeBed.SetActive(true);
            LeaveBed.SetActive(true);
        }

        if (other.tag == "Wardrobe")
        {
            PickRandomClothes.SetActive(true);
            CoordinateOutfit.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Alarm")
        {
            Getup.SetActive(false);
            Snooze.SetActive(false);
        }

        if (other.tag == "Bed")
        {
            MakeBed.SetActive(false);
            LeaveBed.SetActive(false);
        }

        if (other.tag == "Wardrobe")
        {
            PickRandomClothes.SetActive(false);
            CoordinateOutfit.SetActive(false);
        }
    }

}
