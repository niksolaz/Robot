using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public float speed;
	public Text countTextSturtrup;
	public Text countTextBlocked;
	public Text winText;
	public Text loseText;

	private Rigidbody rb;
	private int countBlock;
	private int countSturtrup;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody> ();
		countBlock = 2;
		countSturtrup = 0;
		SetCountText ();
		winText.text = "";
		loseText.text = "";
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);

	}

	void OnTriggerEnter (Collider other) {
		
		if (other.gameObject.CompareTag("Sturtruppen"))
		{
			other.gameObject.SetActive(false);
			countSturtrup = countSturtrup + 1;
			SetCountText ();
		}
		if (other.gameObject.CompareTag("Blocked"))
		{
			other.gameObject.SetActive(false);
			countBlock = countBlock - 1;
			SetCountText ();
		}
	}

	void SetCountText ()
	{
		countTextSturtrup.text = "Count: " + countSturtrup.ToString ();
		if (countSturtrup >= 3)
		{
			loseText.text = "You Lose! The Empire won! ";
			winText.text = "";
			countBlock = 2;
		}
		countTextBlocked.text = "Count: " + countBlock.ToString ();
		if (countBlock == 0)
		{
			winText.text = "You Win! Thank you BB-8! You saved the rebellion! ";
			loseText.text = "";
			countSturtrup = 0;
		}
	}
}
	