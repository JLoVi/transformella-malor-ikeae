﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectActivator : MonoBehaviour
{

    public GameObject[] objectsToActivate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateGameObjects(bool state)
    {
        foreach (GameObject go in objectsToActivate)
        {
            go.SetActive(state);
        }
    }
}
