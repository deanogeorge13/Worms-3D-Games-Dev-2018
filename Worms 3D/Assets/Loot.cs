using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loot : MonoBehaviour {

    public class DropCurrency
    {
        public string name;
        public GameObject Item;
        public int dropChance;
    }

    public List<DropCurrency> LootTable = new List<DropCurrency> { };

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
