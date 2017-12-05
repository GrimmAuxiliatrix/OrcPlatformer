using UnityEngine;
using System.Collections;

public class GemSpawn : MonoBehaviour {

	public GameObject[] gems = new GameObject[2];
	public float vVal = 3f;
	public GameObject platform;
	public GameObject orc;
	//public float[] genValues = new float[]{-9f, -6f, -1f, 1f, 6f, 9f}; //x-value ranges for platforms
	public float xMin = -9f;
	public float xMax = -5f;
	public float yMin = -3f;
	public float yMax = 3f;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 26; i+=2) {
			Instantiate(platform, new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax), -1), Quaternion.identity);
			foreach (GameObject gem in gems){
				Instantiate (gem, new Vector3(Random.Range (xMin, xMax), vVal, -1), Quaternion.identity);
			}
			xMin += 7;
			xMax += 7;
			if(i==0){
				orc.transform.position = new Vector3(-7, vVal, -1);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
