using System;
using UnityEngine;

// custom struct that I use in the editor to allow position/target to be set at the same time
[Serializable]
public struct CameraPositionTarget {
	public Transform position;
	public Transform target;

	public Vector3 direction() {
		return (target.position - position.position).normalized;
	}
}