using UnityEngine;
using System.Collections;

public class Radar : MonoBehaviour {

	public GameObject balaPrefab;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("atirar", 1, 0.25f);
	}
	
	// Update is called once per frame
	void Update () {


	}

	void atirar(){
		Debug.Log ("Atirou");
		RaycastHit hit;
		if (Physics.Raycast (this.transform.position, this.transform.right, out hit)) {
			balaPrefab.transform.position = hit.point;		
		}
	}

}
