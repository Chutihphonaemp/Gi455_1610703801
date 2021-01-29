using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Try : MonoBehaviour
{
    public string Textsear;
    public string gbf, bdo, youtube, spotify, netflix;
    public GameObject Inputfield;
    public GameObject Textdisplay;

    public void TryToSearch()

    {
        gbf = "gbf";
        bdo = "bdo";
        youtube = "youtube";
        spotify = "spotify";
        netflix = "netflix";


        Textsear = Inputfield.GetComponent<Text>().text;
        Textdisplay.GetComponent<Text>().text = Textsear + "   is not Found";


        if (gbf == Textsear)
        {
            print(gbf + "found");
            Textdisplay.GetComponent<Text>().text = gbf+ "  is Found";

        }
        if (bdo == Textsear)
        {
            print(bdo + "found");
            Textdisplay.GetComponent<Text>().text = bdo + "  is Found";
        }

        if (youtube == Textsear)
        {
            print(gbf + "found");
            Textdisplay.GetComponent<Text>().text = youtube + "  is Found";
        }
        if (spotify == Textsear)
        {
            print(gbf + "found");
            Textdisplay.GetComponent<Text>().text = spotify + "  is Found";
        }
        if (netflix == Textsear)
        {
            print(gbf + "found");
            Textdisplay.GetComponent<Text>().text = netflix + "  is Found";
        }
        





    }
}
