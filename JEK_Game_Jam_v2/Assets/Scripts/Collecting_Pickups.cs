using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder;

public class Collecting_Pickups : MonoBehaviour {
    public Pickup pickupPrefab;
    public Transform worldCenter;
    [HideInInspector]
    public List<Pickup> pickups = new List<Pickup>();

    [Range(10, 200)]
    public int startingPickupAmount = 100;
    const float pickupDensity = 0.08f;

    void Start() {
        for(int i = 0; i < startingPickupAmount; i++) {
            Pickup pickup = Instantiate(pickupPrefab, new Vector3(Random.insideUnitSphere.x * startingPickupAmount * pickupDensity, 
                Random.insideUnitSphere.y * startingPickupAmount * pickupDensity, 
                Random.insideUnitSphere.z * startingPickupAmount * pickupDensity), Quaternion.Euler(Vector3.up * Random.Range(0f,360f)), transform);
            pickup.pointValue = Random.Range(5, 100);
            pickup.name = "Pickupnr: " + i;
            pickup.worldCenter = worldCenter;
            if(pickup.pointValue > 50) {
                pickup.GetComponentInChildren<Renderer>().material.color = Color.yellow;
            }
            else {
                pickup.GetComponentInChildren<Renderer>().material.color = Color.blue;
            }
            Debug.Log("My Point Value is: " + pickup.pointValue + " and my name is: " + pickup.name);
            pickups.Add(pickup);
        }
    }
}
