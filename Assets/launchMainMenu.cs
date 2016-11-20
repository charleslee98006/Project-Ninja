using UnityEngine;
using System.Collections;

public class launchMainMenu : MonoBehaviour {
	// store the GameObject which renders the overlay info
	public GameObject overlay;

	// store a reference to the audio listener in the scene, allowing for muting of the scene during the overlay
	public AudioListener mainListener;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void Awake(){
		ShowLaunchScreen();
	}

	// show overlay info, pausing game time, disabling the audio listener 
	// and enabling the overlay info parent game object
	public void ShowLaunchScreen()
	{
		Time.timeScale = 0f;
		mainListener.enabled = false;
		overlay.SetActive (true);
	}
}
