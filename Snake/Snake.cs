using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour {
	private Vector2Int gridMoveDirection;
	private int gridValue = 10;
	private Vector2Int gridPosition;
	private float gridMoveTimer;
	private float gridMoveTimerMax;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	private void Awake () {
		gridPosition = new Vector2Int (5, 5);
		gridMoveTimerMax = 1f;
		gridMoveTimer = gridMoveTimerMax;
		gridMoveDirection = new Vector2Int (gridValue, 0);
	}
	private void Update() {
		//moverment input
		{
			if (Input.GetKeyDown (KeyCode.UpArrow) && gridMoveDirection.y != -gridValue ) {
				gridMoveDirection.x = 0;
				gridMoveDirection.y = gridValue;
			}
			if (Input.GetKeyDown (KeyCode.DownArrow) && gridMoveDirection.y != gridValue ) {
				gridMoveDirection.x = 0;
				gridMoveDirection.y = -gridValue;
			}
			if (Input.GetKeyDown (KeyCode.LeftArrow) && gridMoveDirection.x != gridValue) {
				gridMoveDirection.x = -gridValue;
				gridMoveDirection.y = 0;
			}
			if (Input.GetKeyDown (KeyCode.RightArrow)&& gridMoveDirection.x != -gridValue) {
				gridMoveDirection.x = gridValue;
				gridMoveDirection.y = 0;
			}
		}
		gridMoveTimer += Time.deltaTime;
		if (gridMoveTimerMax <= gridMoveTimer) {
			gridPosition += gridMoveDirection;
			gridMoveTimer -= gridMoveTimerMax;
		}
		transform.position = new Vector3 (gridPosition.x, gridPosition.y);

	}
}
