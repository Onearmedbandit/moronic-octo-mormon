using UnityEngine;
using System.Collections;

public class booyah : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other){
		Application.LoadLevel("booyah");
		Debug.Log("Something happened");
	}
	}
