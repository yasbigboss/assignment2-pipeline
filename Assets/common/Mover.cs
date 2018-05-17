using UnityEngine;

public class Mover : MonoBehaviour {
	Vector3 originalPosition;
	
	private void Start() {
		originalPosition = transform.position;
	}

	void Update () {
		float speed = 1.0f;
		float distance = 5.0f;
		var x = Mathf.Sin(Time.time * speed) * distance;

		transform.position = originalPosition + new Vector3(x, 0.0f, 0.0f);
	}
}
