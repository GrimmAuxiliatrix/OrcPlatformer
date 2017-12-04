using UnityEngine;
using System.Collections;

public class GemSpawn : MonoBehaviour {

	public GameObject[] gems = new GameObject[2];
	public float vVal = 3f;
	public GameObject platform;
	public GameObject orc;
	public float[] genValues = new float[]{-9f, -6f, -1f, 1f, 6f, 9f}; //x-value ranges for platforms
	public float yMin = -1f;
	public float yMax = 3f;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 6; i+=2) {
			Instantiate(platform, new Vector3(Random.Range(genValues[i], genValues[i+1]), Random.Range(yMin, yMax), -1), Quaternion.identity);
			foreach (GameObject gem in gems){
				Instantiate (gem, new Vector3(Random.Range (genValues[i], genValues[i+1]), vVal, -1), Quaternion.identity);
			}
			if(i==0){
				Instantiate(orc, new Vector3(-8, vVal, -1), Quaternion.identity);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
