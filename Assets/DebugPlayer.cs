using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugPlayer : MonoBehaviour
{

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F1))
        {
            Destroy(gameObject);
            Debug.Log("Debug: Player was destroyed by debug script");
        }


        if (Input.GetKeyDown(KeyCode.F2))
        {
            gameObject.SetActive(false);
            Debug.Log("Debug: Player was SetActive(false) by debug script");
        }
    }
}
