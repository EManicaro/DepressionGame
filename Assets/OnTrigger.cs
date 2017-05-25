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
    public GameObject Shave;
    public GameObject NoShave;
    public GameObject WashFaceAndTeeth;
    public GameObject WashFace;
    public GameObject ToiletSeatUp;
    public GameObject ToiletSeatDown;
    public GameObject ToastAndCoffee;
    public GameObject Coffee;
    public GameObject WashDishesNow;
    public GameObject WashDishesLater;
    

    public void Start()
    {
        Getup.SetActive(false);
        Snooze.SetActive(false);
        MakeBed.SetActive(false);
        LeaveBed.SetActive(false);
        PickRandomClothes.SetActive(false);
        CoordinateOutfit.SetActive(false);
        Shave.SetActive(false);
        NoShave.SetActive(false);
        WashFaceAndTeeth.SetActive(false);
        WashFace.SetActive(false);
        ToiletSeatUp.SetActive(false);
        ToiletSeatDown.SetActive(false);
        ToastAndCoffee.SetActive(false);
        Coffee.SetActive(false);
        WashDishesNow.SetActive(false);
        WashDishesLater.SetActive(false);
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

        
        //if (other.tag == "Mirror")
       // {
      //      Shave.SetActive(true);
      //      NoShave.SetActive(true);
      //  }

        if (other.tag == "BathroomBasin")
        {
            Shave.SetActive(true);
            NoShave.SetActive(true);
            WashFaceAndTeeth.SetActive(true);
            WashFace.SetActive(true);
        }

        if (other.tag == "Toilet")
        {
            ToiletSeatUp.SetActive(true);
            ToiletSeatDown.SetActive(true);
        }

        if (other.tag == "CoffeeMachine")
        {
            ToastAndCoffee.SetActive(true);
            Coffee.SetActive(true);
        }

        if (other.tag == "KitchenBasin")
        {
            WashDishesNow.SetActive(true);
            WashDishesLater.SetActive(true);
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


        //if (other.tag == "Mirror")
        //{
        //Shave.SetActive(false);
        //    NoShave.SetActive(false);
        //}

        if (other.tag == "BathroomBasin")
        {
            Shave.SetActive(false);
            NoShave.SetActive(false);
            WashFaceAndTeeth.SetActive(false);
            WashFace.SetActive(false);
        }

        if (other.tag == "Toilet")
        {
            ToiletSeatUp.SetActive(false);
            ToiletSeatDown.SetActive(false);
        }

        if (other.tag == "CoffeeMachine")
        {
            ToastAndCoffee.SetActive(false);
            Coffee.SetActive(false);
        }

        if (other.tag == "KitchenBasin")
        {
            WashDishesNow.SetActive(false);
            WashDishesLater.SetActive(false);
        }
    }

}
