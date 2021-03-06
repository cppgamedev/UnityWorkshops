﻿using UnityEngine;
using System.Collections;

public class Hole : MonoBehaviour {
    // Mole Prefab
    public GameObject mole;
    public float aliveTime = 3;
    
    // Spawn Interval
    public int intervalMin = 3;
    public int intervalMax = 12;
        
    // Use this for initialization
    void Start () {
        Invoke("Spawn", Random.Range(intervalMin, intervalMax));
    }
    
    void Spawn() {
        // Spawn the mole
        GameObject g = (GameObject)Instantiate(mole, transform.position, Quaternion.identity);
        
        // Make sure to destroy it after a few seconds
        Destroy(g, aliveTime);
        
        // Next Spawn
        Invoke("Spawn", Random.Range(intervalMin, intervalMax));
    }
}
