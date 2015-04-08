using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform player;

	// Use this for initialization
	void Start () {
	
	}
	
	void  Update (){
		transform.position = player.position + new Vector3 (0, 0, -10);
	} 
}
