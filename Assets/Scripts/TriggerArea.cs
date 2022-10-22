using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    public int id;
    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            Debug.Log("Opened");
            GameEvents.current.DoorwayTriggerEnter(id);
        }
    }
    private void OnTriggerExit(Collider other) {
        if (other.tag == "Player") {
            Debug.Log("Closed");
            GameEvents.current.DoorwayTriggerExit(id);
        }
    }
}
