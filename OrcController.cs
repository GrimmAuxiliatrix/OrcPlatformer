using UnityEngine.SceneManagement;

public class OrcController : MonoBehaviour {

	public Animator anim;
	public float spd = 10f;
	public Vector2 howHigh;
	public Color txtColor;
	public int txtSize = 100;
	private float hmovement = 0f;
	private float vmovement = 0f;
	public float wincount = 6f; //change to set amount of gems needed to win the game

	private bool canjump = true;
	private int count = 0;
	private string displayTxt;
	private GUIStyle textConfig = new GUIStyle();
	
	public GameObject cam;
	private Vector3 offset; 

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		textConfig.fontSize = txtSize;
		textConfig.normal.textColor = txtColor;
		offset = cam.transform.position - transform.position;
	}

	// Update is called once per frame
	void Update () {
		hmovement = Input.GetAxis ("Horizontal");
		vmovement = Input.GetAxis ("Vertical");

		if (Input.GetKey ("d")) {
			anim.SetInteger ("state", 1); 
			var move = new Vector3 (hmovement, vmovement, 0);
			transform.position += move * spd * Time.deltaTime;
		} else if (Input.GetKey ("a")) {
			anim.SetInteger ("state", 1); 
			var move = new Vector3 (hmovement, vmovement, 0);
			transform.position += move * spd * Time.deltaTime;
		} else {
			anim.SetInteger ("state", 0);
		}

		if(Input.GetKeyDown("w") && canjump == true){
			GetComponent<Rigidbody2D>().AddForce(howHigh, ForceMode2D.Impulse);
			canjump = false;
		}

		if (Input.GetKey("escape"))
			Application.Quit();
	}
	
	void LateUpdate(){
		cam.transform.position = transform.position + offset;
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag ("platform")) {
			canjump = true;
		}
		if(other.gameObject.CompareTag("collectible")){
			Destroy(other.gameObject);
			count++;
		}
		if (count == wincount) {
			SceneManager.LoadScene("Menu", LoadSceneMode.Additive);
		}

	}

	private void OnGUI(){
		displayTxt = GUI.TextField(new Rect(750, 10, 50, 20), count.ToString(), textConfig);
	}
}
