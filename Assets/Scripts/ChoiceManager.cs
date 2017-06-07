using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceManager : MonoBehaviour {

	// was the event triggered in this scene?
	bool wasTriggered;

	// the objects that need to be activated/deactivated
	public GameObject[] links;


	void Start()
	{
		SetObjectsActive(false);	
	}

	// toggles the object's active state
	void SetObjectsActive(bool active)
	{
		foreach (GameObject go in links)
		{
			go.SetActive(active);
		}
	}


	// triggers the objects once for this scene
	public void Trigger()
	{
		Trigger(true);
	}

	public void Trigger(bool disablePlayerControl)
	{
		if (!wasTriggered)
		{
			wasTriggered = true;
			SetObjectsActive(true);

			if (disablePlayerControl)
			{
				GameObject.FindObjectOfType<camMouseLook>().CanPlayerLook(false);
				GameObject.FindObjectOfType<characterController>().CanPlayerMove(false);
			}
		}
		else
		{
			SetObjectsActive(false);
			GameObject.FindObjectOfType<camMouseLook>().CanPlayerLook(true);
			GameObject.FindObjectOfType<characterController>().CanPlayerMove(true);
		}
	}

}
