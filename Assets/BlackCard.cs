using UnityEngine;
using System.Collections;

public class BlackCard : Card {
   
    [SerializeField]
    private GameObject Kugel;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (searchForKugel)
        {
            Kugel = getKugel();
            if (Kugel != null && (Kugel.GetComponent<Kugel>().MyPlayer==MyPlayer) && (Kugel.GetComponent<Kugel>().momentaryPlace != null))
            {
                Debug.Log("Hit My Kugel");
                searchForKugel = false;
                CardFunction();
            }
        }
    }
   override protected void CardFunction()
    {
        if (Kugel == null)
        {
            searchForKugel = true; 
        }else
        {
            if (Kugel.GetComponent<Kugel>().MoveNSteps(MovePoints) != false)
            {
                Debug.Log("MovedNSteps");

            }
            else Kugel = null;
            Kugel = null; 
        }
    }
}
