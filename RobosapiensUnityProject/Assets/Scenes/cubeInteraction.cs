﻿using UnityEngine;
using System.Collections;

public class cubeInteraction : MonoBehaviour
{
    private Transform oldTrsf;

    void OnTriggerEnter(Collider c)
    {
        if (c.transform.parent && c.transform.parent.parent && c.transform.parent.parent.gameObject.tag.Equals("leap_hand"))
        {
            if (leapStatesManagement.leapIndex)
            {
                Destroy(gameObject);
            }
            else if (leapStatesManagement.leapPalm)
            {
                Debug.Log("palm action");
                leapStatesManagement.grabbedObj = gameObject;
            }
            else
            {
                leapStatesManagement.grabbedObj = null;
            }
        }

    }

    void OnTriggerExit(Collider c)
    {

    }
}