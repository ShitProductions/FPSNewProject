using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using UnityStandardAssets.Characters.FirstPerson;

public class LocalPlayerSetup : NetworkBehaviour
{

    public Camera playercamera;
    public FirstPersonController player;
    public GameObject SceneCam;
    public Camera scene;
    public AudioListener mainaudio;

    public NetworkManager network;

    // Use this for initialization
    void Start()
    {
        if (isLocalPlayer)
        {
            player.enabled = true;
            playercamera.enabled = true;
            SceneCam = GameObject.Find("SceneCam");
            scene = SceneCam.GetComponent<Camera>();
            scene.enabled = false;
            mainaudio = SceneCam.GetComponent<AudioListener>();
            mainaudio.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.X))
        {
            scene = SceneCam.GetComponent<Camera>();
            scene.enabled = true;
            mainaudio = SceneCam.GetComponent<AudioListener>();
            mainaudio.enabled = true;
        }
    }
}
