using UnityEngine;
using System.Collections;

public class CardGiver : MonoBehaviour {
    public GameObject[] Deck = new GameObject[104];
    public GameObject[] AvailableCards = new GameObject[14];
	// Use this for initialization
	void Start () {
        int counter = 0; 
        for (int a = 0; a < 9;a++) {
            Deck[counter] = AvailableCards[0];
            counter++;
                    }
        for (int b = 0; b < 7; b++)
        {
            Deck[counter] = AvailableCards[1];
            counter++;
        }
        for (int c = 0; c < 7;c++)
        {
            Deck[counter] = AvailableCards[2];
            counter++;
        }
        for (int d = 0; d < 7; d++)
        {
            Deck[counter] = AvailableCards[3];
            counter++;
        }
        for (int e= 0; e < 7; e++)
        {
            Deck[counter] = AvailableCards[4];
            counter++;
        }
        for (int f = 0; f < 7; f++)
        {
            Deck[counter] = AvailableCards[5];
            counter++;
        }
        for (int g = 0; g < 8;g++)
        {
            Deck[counter] = AvailableCards[6];
            counter++;
        }
        for (int h = 0; h < 7; h++)
        {
            Deck[counter] = AvailableCards[7];
            counter++;
        }
        for (int i = 0; i < 7; i++)
        {
            Deck[counter] = AvailableCards[8];
            counter++;
        }
        for (int j = 0; j < 7;j++)
        {
            Deck[counter] = AvailableCards[9];
            counter++;
        }
        for (int k = 0; k < 7;k++)
        {
            Deck[counter] = AvailableCards[10];
            counter++;
        }
        for (int l= 0; l < 9; l++)
        {
            Deck[counter] = AvailableCards[11];
            counter++;
        }
        for (int m = 0; m < 7; m++)
        {
            Deck[counter] = AvailableCards[12];
            counter++;
        }
        for (int n = 0; n < 4; n++)
        {
            Deck[counter] = AvailableCards[13];
            counter++;
        }

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    GameObject[] GetFiveCards ()
    {
        GameObject[]temp = new GameObject[5];
        for (int i = 0; i < 5; i++)
        {
            temp[i] = Deck[Random.Range(0, 103)];
        }
        return temp; 
    }
}
