using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {
    public GameObject Player;
    public GameObject PlayCamera;
    public GameObject Kugel,Kugel2;
    public GameObject Position; 
    private bool PlayCameraActive;
    private int a = 0; 
	// Use this for initialization
	void Start () {
        PlayCamera.GetComponent<Camera>().enabled = false;
        Player.GetComponentInChildren<Camera>().enabled = true;
        PlayCameraActive = false;
        Cursor.visible = false; 
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.A))
        {
            Kugel.GetComponent<Kugel>().MoveNSteps(5);
            
        }
        if (Input.GetKeyDown(KeyCode.S)) {
            if (a == 0)
            {
                Position = Position.GetComponent<BoardPlaces>().BeforePlace;
                Kugel.GetComponent<Kugel>().momentaryPlace = Position;
                Kugel.transform.position = Position.transform.position;
                a++;
            }else
            {
                Position = Position.GetComponent<BoardPlaces>().BeforePlace;
                Kugel2.GetComponent<Kugel>().momentaryPlace = Position;
                Kugel2.transform.position = Position.transform.position;
            }


        }
	}
}
