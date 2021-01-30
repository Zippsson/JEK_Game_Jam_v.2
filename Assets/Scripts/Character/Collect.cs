using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour {
    public Collecting_Pickups collectScript;
    public int points;

    private void OnCollisionEnter(Collision collision) {
        points += collision.gameObject.GetComponent<Pickup>().pointValue;
        Debug.Log("I collided with: " + collision.gameObject.name);
        Destroy(collision.gameObject);
        Debug.Log("Points: " + points);
    }
}
