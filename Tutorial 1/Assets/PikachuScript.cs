using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PikachuScript : MonoBehaviour {
	public Button attackButton;
	public GameObject lightningWave;

	// Use this for initialization
	void Start () {
		attackButton.onClick.AddListener (attackButtonDown);
		lightningWave.gameObject.SetActive (false);
		
	}
	IEnumerator Wait(){
		lightningWave.gameObject.SetActive (true);
		yield return new WaitForSeconds (2);
		lightningWave.gameObject.SetActive (false);
	}
	void attackButtonDown(){
		StartCoroutine (Wait ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
}
