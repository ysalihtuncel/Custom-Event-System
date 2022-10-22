using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameEvents : MonoBehaviour
{

    public static GameEvents current;

    void Awake()
    {
        current = this;
    }

    public event Action<int> onDoorwayTriggerEnter;
    public void DoorwayTriggerEnter(int id) {
        onDoorwayTriggerEnter?.Invoke(id);
    }
    public event Action<int> onDoorwayTriggerExit;
    public void DoorwayTriggerExit(int id) {
        onDoorwayTriggerExit?.Invoke(id);
    }
}
