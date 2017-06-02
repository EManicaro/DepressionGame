using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class characterController : MonoBehaviour
{
    //public variable speed
    public float speed = 10.0F;


    //time variables

    public int hours = 7;
    public int minutes = 0;

    //this is the canvas text box
    public Text timeText;

    





    // Use this for initialization
    void Start()
    {
        // turn off cursor so we won't see it on screen and to stay in the game window
        Cursor.lockState = CursorLockMode.Locked;
        StartCoroutine("AutoTime");

    }

    //Update is called once per frame
    void Update()
    {

        //translation will be used for the up and down movements (get the value)
        float translation = Input.GetAxis("Vertical") * speed;

        //straffe is also like translate, but we will use it for the side movements (get the value)
        float straffe = Input.GetAxis("Horizontal") * speed;

        // to move smoothly between updates and at the same rate
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;

        //move on the X and Y axis
        transform.Translate(straffe, 0, translation);


        //new timer
    }

    //function for the time where the addition takes place
    public void MoveTimeFwd(int m)
    {

        minutes += m;
        int dMinutes = minutes % 60;


        hours = (hours + ((minutes - dMinutes) / 60)) % 24;
        minutes = dMinutes;

        timeText.text = string.Format("Time:{0}:{1}", hours, minutes.ToString("0#"));
    }


    IEnumerator AutoTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            MoveTimeFwd(1);
        }
    }
}