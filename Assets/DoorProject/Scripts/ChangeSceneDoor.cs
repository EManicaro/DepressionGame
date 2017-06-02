using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneDoor : AbstractDoorAction {

    public string sceneToLoad;

    public override void DoorAction()
    {
        base.DoorAction();
        SceneManager.LoadScene(sceneToLoad);

    }
}
