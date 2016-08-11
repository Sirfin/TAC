using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {
    public GameObject Player;
    public GameObject PlayCamera;
    public GameObject Kugel;
    public GameObject Position; 
    private bool PlayCameraActive;  
	// Use this for initialization
	void Start () {
        PlayCamera.GetComponent<Camera>().enabled = false;
        Player.GetComponentInChildren<Camera>().enabled = true;
        PlayCameraActive = false;
        Cursor.visible = false; 
    }
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown(KeyCode.Space))
        {
            if (PlayCameraActive)
            {
                PlayCamera.GetComponent<Camera>().enabled = false;
                Player.GetComponentInChildren<Camera>().enabled = true;
                PlayCameraActive = false;
                Cursor.visible = false; 
            }
            else
            {
                PlayCamera.GetComponent<Camera>().enabled =true ;
                Player.GetComponentInChildren<Camera>().enabled =false;
                PlayCameraActive = true ;
                Cursor.visible = true; 
            }
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Position = Position.GetComponent<BoardPlaces>().NextPlace;
            Kugel.transform.position = Position.transform.position;
            
        }
        if (Input.GetKeyDown(KeyCode.S)) { 

            Position = Position.GetComponent<BoardPlaces>().BeforePlace;
        Kugel.transform.position = Position.transform.position;
            
        }
	}
}
