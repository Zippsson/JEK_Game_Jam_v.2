using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder;

public class Collecting_Pickups : MonoBehaviour {
    public static Pickup[] prefabs;
    public Transform worldCenter;
    
    [HideInInspector]
    public List<Pickup> pickups = new List<Pickup>();

    [Range(10, 200)]
    public int startingPickupAmount = 100;
    const float pickupDensity = 0.08f;

    void Start() {
        prefabs = Resources.LoadAll<Pickup>("PreFabs");

        for (int i = 0; i < startingPickupAmount; i++) {
            Pickup pickup = Instantiate(prefabs[i % prefabs.Length], new Vector3(Random.insideUnitSphere.x * startingPickupAmount * pickupDensity, 
                Random.insideUnitSphere.y * startingPickupAmount * pickupDensity, 
                Random.insideUnitSphere.z * startingPickupAmount * pickupDensity), Quaternion.Euler(Vector3.up * Random.Range(0f,360f)), transform);

            pickup.pointValue = Random.Range(5, 100);
            pickup.name = "Pickupnr: " + i;
            pickup.worldCenter = worldCenter;

            pickups.Add(pickup);
        }
    }
}
