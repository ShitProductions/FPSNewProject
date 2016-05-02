using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

[AddComponentMenu("Network/NetworkManagerHUD")]
[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
public class HUDControl : NetworkBehaviour {

    public NetworkManagerHUD hudManager;

    // Use this for initialization
    void Start ()
    {
        hudManager.showGUI = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (isLocalPlayer)
        {
            if (Input.GetKey(KeyCode.P))
            {
                hudManager.showGUI = !hudManager.showGUI;
            }
        }
	}
}