using UnityEngine;
using System.Collections;

public class Kugel : MonoBehaviour {
    public GameObject momentaryPlace;
    public Vector3 HomePlace;
    public GameObject MyPlayer;
    public GameObject OutOfHomeSpot;
    [SerializeField]
    private bool InHome = true; 
	// Use this for initialization
	void Start () {
        HomePlace = transform.position;
        //Debug.Log(HomePlace);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public bool GetInHome()
    {
        return InHome; 
    }
    public void GetOutOfHome()
    {
        this.transform.position = OutOfHomeSpot.transform.position; //Wir führen die Kugel aus dem Haus raus. 
        momentaryPlace = OutOfHomeSpot;
        
        if (OutOfHomeSpot.GetComponent<BoardPlaces>().KugelOnThisSpot != null)
        {
            OutOfHomeSpot.GetComponent<BoardPlaces>().KugelOnThisSpot.GetComponent<Kugel>().Geschlagen(); 
        }
        momentaryPlace.GetComponent<BoardPlaces>().KugelOnThisSpot = this.gameObject;
        InHome = false; 
    }
    public void Geschlagen()
    {
        Debug.Log("Ich Wurde geschlagen");
        InHome = true;
        Debug.Log(HomePlace);
        this.gameObject.transform.position = HomePlace;
        momentaryPlace = null; 
    }
    public bool MoveNSteps(int n)
    {
        GameObject counter;

        counter = momentaryPlace;
        
        for (int i = 0; i < n; i++)
        {
            if (counter.GetComponent<BoardPlaces>().KugelOnThisSpot != null&& i >0 ) return false; 
            counter = counter.GetComponent<BoardPlaces>().NextPlace; //Suche den Spot in N Schritten und gehen dorthin
        }


        momentaryPlace.GetComponent<BoardPlaces>().KugelOnThisSpot = null;
        if (counter.GetComponent<BoardPlaces>().KugelOnThisSpot!= null) counter.GetComponent<BoardPlaces>().KugelOnThisSpot.GetComponent<Kugel>().Geschlagen();
        this.momentaryPlace = counter;
        counter.GetComponent<BoardPlaces>().KugelOnThisSpot = this.gameObject; 
        this.transform.position = counter.transform.position;
        return true; 
    }
}
