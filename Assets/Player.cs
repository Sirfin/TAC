using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    public bool MyTurn ;
    public GameObject PlayCamera;
    private bool PlayCameraActive;

    public GameObject[] MyKugeln = new GameObject[4];
    [SerializeField]
    public GameObject[] MyCards = new GameObject[5];
	// Use this for initialization
	void Start () {
	foreach (GameObject element in MyKugeln)
        {
            element.GetComponent<Kugel>().MyPlayer = this.gameObject; 
        }
        ActualizeCards(); 
    }
    public void ActualizeCards()
    {
        foreach (GameObject element in MyCards)
        {
            if (element != null) if (element.GetComponent<Card>() !=null) element.GetComponent<Card>().MyPlayer = this.gameObject;
        }
    }
	// Update is called once per frame
	void Update () {

        if (MyTurn)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (PlayCameraActive)
                {
                    PlayCamera.GetComponent<Camera>().enabled = false;
                    this.GetComponentInChildren<Camera>().enabled = true;
                    PlayCameraActive = false;
                    Cursor.visible = false;
                }
                else
                {
                    PlayCamera.GetComponent<Camera>().enabled = true;
                    this.GetComponentInChildren<Camera>().enabled = false;
                    PlayCameraActive = true;
                    Cursor.visible = true;
                }
            }
        }
        else
        {

        }
	}
}
