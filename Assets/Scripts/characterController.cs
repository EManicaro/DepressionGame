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
    //new timer
    public float gameTimer = 0f;


    // Use this for initialization
    void Start()
    {
        // turn off cursor so we won't see it on screen and to stay in the game window
        Cursor.lockState = CursorLockMode.Locked;

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

        //nrew timer
        gameTimer += Time.deltaTime;

        int seconds = (int)(gameTimer % 60);
        int minuntes = (int)(gameTimer / 60) % 60;
        int hours = (int)(gameTimer / 3600 % 24);

        string timerString = string.Format("{0:0}:{1:0}:{2:0}", hours, minuntes, seconds);
        //display new timer
        timeText.text = timerString;


    }

    //function for the time where the addition takes place
    public void MoveTimeFwd(int m)
    {

        minutes += m;
        int dMinutes = minutes % 60;


        hours = (hours + ((minutes - dMinutes) / 60)) % 24;
        minutes = dMinutes;

        timeText.text = string.Format("Time: {0}:{1}", hours, minutes.ToString("0#"));
    }


    // private void OnTriggerEnter(Collider other)
    // {
    //     if (other.tag == "Alarm")
    //     {
    //         StartCoroutine("hello");
    //    }
    // }
    // IEnumerator hello()
    // {
    //   yield return new WaitForSeconds(1);
    //      gameTimer += 10f;

    //  yield return new WaitForSeconds(5);
    //    StopCoroutine("hello");


    //    }

}