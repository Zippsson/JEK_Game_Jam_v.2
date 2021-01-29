
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Pickup : MonoBehaviour {
    Collider pickupCollider;
    public int pointValue;
    public float speed = 1.5f;
    Vector3 randomDirection;

    public Transform worldCenter;
    public float radius = 800f;
    public Collider PickupCollider { get { return pickupCollider; } }
    void Start() {
        randomDirection = Random.insideUnitSphere * 50f;
        
        transform.LookAt(randomDirection);
        pickupCollider = GetComponent<Collider>();
    }

    public void Update() {
        transform.position += transform.forward * speed * Time.deltaTime;
        
        Vector3 pickupPos = transform.position;
        float distance = Vector3.Distance(pickupPos, worldCenter.position);
        if(distance > radius) {
            transform.position -= transform.forward * speed * Time.deltaTime;
            transform.position = transform.position * -1;
        }
    }
}
