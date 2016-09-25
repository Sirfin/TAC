using UnityEngine;
using System.Collections;

public class RedCard : Card {
    [SerializeField]
    private GameObject Kugel;

    enum RedCardStyle { DreizehnEins, Acht, Sieben, Trickser, Tac, Vier }
    public bool DreizehnEinsBool;
    public bool AchtBool;
    public bool SiebenBool;
    public bool TrickserBool;
    public bool TacBool;
    public bool VierBool;
    private RedCardStyle myStyle; 
    
    // Use this for initialization
    void Start () {
        if (DreizehnEinsBool) myStyle = RedCardStyle.DreizehnEins;
        if (AchtBool) myStyle = RedCardStyle.Acht;
        if (SiebenBool) myStyle = RedCardStyle.Sieben;
        if (TrickserBool) myStyle = RedCardStyle.Trickser;
        if (TacBool) myStyle = RedCardStyle.Tac;
        if (VierBool) myStyle = RedCardStyle.Vier;
        PlayCamera = GameObject.FindGameObjectWithTag("BoardCamera").GetComponent<Camera>(); ;

    }
	
	// Update is called once per frame
	void Update () {
        if (searchForKugel)
        {
            Kugel = getKugel();
            if (Kugel != null && (Kugel.GetComponent<Kugel>().MyPlayer == MyPlayer))
            {
                Debug.Log("Hit My Kugel");
                searchForKugel = false;
                CardFunction();
            }
        }
    }
    private void DreizehnEinsMethod()
    {
        if (Kugel.GetComponent<Kugel>().GetInHome())
        {
            Kugel.GetComponent<Kugel>().GetOutOfHome();
        }
        else
        {

            if (Kugel.GetComponent<Kugel>().MoveNSteps(MovePoints) != false)
            {
                Debug.Log("MovedNSteps");
            }
            else Kugel = null;
        }
    }
    private void Vier()
    {
        if (Kugel.GetComponent<Kugel>().MoveNStepsBackwards(MovePoints) != false)
        {
            Debug.Log("MovedNSteps");
        }
        else Kugel = null;
    }
        
    override protected void CardFunction()
    {
        if (Kugel == null)
        {
            searchForKugel = true;
        }
        else
        {

            switch (myStyle)
            {
                case RedCardStyle.DreizehnEins:
                    DreizehnEinsMethod(); 
                    break;
                case RedCardStyle.Vier:
                    Vier();
                    break; 
            }
            //Kugel.GetComponent<Kugel>().MoveNSteps(MovePoints);
            Kugel = null;
        }
    }
}
