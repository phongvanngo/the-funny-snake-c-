using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour {
	private Vector2Int gridPosition;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	private void Awake () {
		gridPosition = new Vector2Int (15, 15);
	}
	private void Update() {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			gridPosition.y += 10;
		}
		transform.position = new Vector3 (gridPosition.x, gridPosition.y);

	}
}