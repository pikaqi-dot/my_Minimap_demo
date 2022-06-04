using UnityEngine;

public class Movement : MonoBehaviour {

	public float speed = 25f;
	public float rotateSpeed = 43f;
	private Vector3 movement;
	private float rotation;

	// Update is called once per frame
	void Update () {
		movement.z = Input.GetAxis("Vertical") * speed * Time.deltaTime;
		rotation = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;

		
	}
	/// <summary>
	/// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
	/// </summary>
	private void FixedUpdate()
	{
		transform.Translate(movement,Space.Self);
		transform.Rotate(0f,rotation,0f);
	}
}
