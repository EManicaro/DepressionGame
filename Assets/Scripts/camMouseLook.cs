using UnityEngine;
using System.Collections;

public class camMouseLook : MonoBehaviour
{

    // this will keep track of how much movement the camera done (will get the change of the movement since the last update)
    Vector2 mouseLook;
    // this will smooth the movement of the mouse
    Vector2 smoothV;
    // the sensitivity of the mouse in order to get any movement from the character
    public float sensitivity = 5.0f;
    // the amount of smoothness
    public float smoothing = 2.0f;

    public bool canMoveCamera = true;

    // when the camera turns/move etc, it will control the whole body of the character
    GameObject character;


    void Start()
    {
        // character is set to the parent of the camera
        character = transform.parent.gameObject;


    }

    void Update()
    {
        if (!canMoveCamera) return;

        //md for mousedelta
        var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        // the md is multiplied by the smoothing and the sensitivity of the mouse
        md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity * smoothing));

        //lerp - linear interpretation of movement, move smoothly between to points
        smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing);
        smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smoothing);

        //mouse look and smooth v are attached
        mouseLook += smoothV;

        // use the mouse look value and add the mouse look y as a local rotation to the camera around its y axis
        // the minus in mouse look y, is an inverted system to rotate the camera up and down
        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        //rotate according the he characters up and down not the camera, in order to move the whole character
        character.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, character.transform.up);
    }

    public void CanPlayerLook(bool canLook)
    {
        canMoveCamera = canLook;
        if (!canMoveCamera)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }



}