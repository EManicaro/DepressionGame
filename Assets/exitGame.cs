using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitGame : MonoBehaviour {

    public void quit()
    {
        if (Input.GetKey("escape"))
            Application.Quit();

    }
}
