using UnityEngine;
using System.Collections;

public class Card : MonoBehaviour {
    public Camera PlayCamera;
    public GameObject MyPlayer; 
    [SerializeField]
    protected int MovePoints;
    public bool searchForKugel = false;
    
	// Use this for initialization
	void Start () {
	
	}
    virtual protected void CardFunction(){
    }
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseDown ()
    {
        foreach(GameObject element in MyPlayer.GetComponent<Player>().MyCards)
        {
            if (element != this.gameObject) element.GetComponent<Card>().searchForKugel = false; 
        }
        CardFunction();
    }
    protected GameObject getKugel()
    {
       
        if (Input.GetMouseButtonDown(0))
        { // if left button pressed...
           // Debug.Log("Searching for Kugel");
            Ray ray = PlayCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100))
            {
              //  Debug.Log("Shot The Raycast");
                if (hit.collider.gameObject.tag == "Kugel")
                {
                //    Debug.Log("Hit a Sphere");
                    return hit.collider.gameObject;
                }
            }
        }
        return null; 
        
    }
}
