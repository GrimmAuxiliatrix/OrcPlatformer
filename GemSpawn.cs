using UnityEngine;
using System.Collections;

public class GemSpawn : MonoBehaviour {

	public GameObject[] gems = new GameObject[2];
	public int count;
	public float vVal = 2.5f;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < count; i++) {
			foreach (GameObject gem in gems){
				Instantiate (gem, new Vector3(Random.Range (-10, 10), vVal, -1), Quaternion.identity);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
