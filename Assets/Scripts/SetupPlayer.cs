using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SetupPlayer : NetworkBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (isLocalPlayer)
        {
            var controller = GetComponent<PlayerController>();
            if (controller) controller.enabled = true;

            Camera.main.gameObject.GetComponent<ICameraController>().Init(gameObject);
        }
        else
        {
            var controller = GetComponent<PlayerController>();
            if (controller) controller.enabled = false;
        }
    }

}
