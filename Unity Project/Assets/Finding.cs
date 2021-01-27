using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finding : MonoBehaviour
{

    public string showname;
    public InputField input;
    public Text showtext;
  
 
    public void Findlist()
    {
        showname = input.text;
        if (showname=="ABC" || showname=="DEF" || showname == "CBA" || showname == "FED" || showname == "gg")
        {
            showtext.text = "[ "+"<color=green>" + showname+ "</color>" + " ] is found";
        }
        else
        {
            showtext.text = "[ " + "<color=red>" + showname + "</color>" + " ] is not found";
        }
    }

   
}
