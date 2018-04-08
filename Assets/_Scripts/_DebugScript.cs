using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _DebugScript : MonoBehaviour
{
    private GameObject player;
    private GameObject playerCamera;

    public Text currentPosUIText;
    public Text currentZoneUIText;
    public Text currentCameraUIText;

    [Space (2)]
    public Transform[] zoneLocations;

    private void Start()
    {
        currentZoneUIText.text = "current zone: " + "3";
    }

    private void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerCamera = GameObject.FindGameObjectWithTag("MainCamera");

        currentPosUIText.text = "current pos: " + player.transform.position;
        currentCameraUIText.text = "current camera pos: " + playerCamera.transform.rotation;

        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
        {
            player.transform.position = zoneLocations[0].transform.position;
            currentZoneUIText.text = "current zone: " + "1";
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            player.transform.position = zoneLocations[1].transform.position;
            currentZoneUIText.text = "current zone: " + "2";
        }

        if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
        {
            player.transform.position = zoneLocations[2].transform.position;
            currentZoneUIText.text = "current zone: " + "3";
        }
    }
}
