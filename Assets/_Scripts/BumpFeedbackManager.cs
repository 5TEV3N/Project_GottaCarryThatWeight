using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumpFeedbackManager : MonoBehaviour
{
    public Transform pointOfContact;
    public GameObject testBump;

    private void OnCollisionEnter(Collision collision)
    {
        pointOfContact = collision.transform;
        Debug.Log("Player hit something in these xyz coordinates" + pointOfContact);
        GameObject.Instantiate(testBump, pointOfContact.transform.position,pointOfContact.rotation);
    }
}
