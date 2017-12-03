using UnityEngine;
using System.Collections;

public class OrcController : MonoBehaviour {

	public Animator anim;
	public float spd = 10f;
	public Vector2 howHigh;
	private bool canjump = false;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("d")) {
			anim.SetInteger ("state", 1); 
			var move = new Vector3 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"), 0);
			transform.position += move * spd * Time.deltaTime;
		} else if (Input.GetKey ("a")) {
			anim.SetInteger ("state", 1); 
			var move = new Vector3 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"), 0);
			transform.position += move * spd * Time.deltaTime;
		} else {
			anim.SetInteger ("state", 0);
		}

		if(Input.GetKeyDown("w") && canjump == true){
			GetComponent<Rigidbody2D>().AddForce(howHigh, ForceMode2D.Impulse);
			canjump = false;
		}
	}
	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag ("platform")) {
			canjump = true;
		}
		if(other.gameObject.CompareTag("collectible")){
			Destroy(other.gameObject);
		}

	}
}