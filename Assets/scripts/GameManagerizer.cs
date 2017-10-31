using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManagerizer : MonoBehaviour {
	public GameObject sphere;

	// Use this for initialization
	void Start () {

		Pathmaker.total = 0;
		//Pathmaker.total = Random.Range()
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown("space")) {
			
			SceneManager.LoadScene ("mainLabScene"
			);
		//	Instantiate (sphere, transform.position, Quaternion.identity);

		}
	
	}
}
