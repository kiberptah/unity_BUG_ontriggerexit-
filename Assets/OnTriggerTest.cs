using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerTest : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter by: " + other.name);
    }
    void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit by: " + other.name);
    }
}
