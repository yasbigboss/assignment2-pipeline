using UnityEngine;

public class MouseClicker : MonoBehaviour {
	public CameraMoveManual cameraMoveManual;
	public GameObject Domino;
	
	void Update () {
		if(Input.GetMouseButtonDown(0) ) {
			// tell the camera to go to its next viewpoint.
			cameraMoveManual.goToNextTarget();
			
			// domnio for fun!
			var rb = Domino.GetComponent<Rigidbody>();
			var force = Domino.transform.right * 100.0f * Time.deltaTime;
			var position = Domino.transform.Find("ForcePosition").position;
			rb.AddForceAtPosition(force, position, ForceMode.Impulse);
		}
	}
}
