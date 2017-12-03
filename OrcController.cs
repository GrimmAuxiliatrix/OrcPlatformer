using UnityEngine;
using System.Collections;

public class OrcController : MonoBehaviour {

	public Animator anim;
	public float spd = 10f;
	public Vector2 howHigh;
	public Color txtColor;
	public int txtSize = 100;
	
	private bool canjump = true;
	private int count = 0;
	private string displayTxt;
	private GUIStyle textConfig = new GUIStyle();

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		textConfig.fontSize = txtSize;
		textConfig.normal.textColor = txtColor;
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
			count++;
		}

	}
	
	private void OnGUI(){
		displayTxt = GUI.TextField(new Rect(750, 10, 50, 20), count.ToString(), textConfig);
	}
}
