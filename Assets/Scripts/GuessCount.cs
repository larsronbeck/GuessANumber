using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GuessCount : MonoBehaviour 
{
   //NumberWizard numberWizard;
   public Text text;
  
   // Use this for initialization
   void Start () 
   {
      text.text = "I guessed " + NumberWizard.guessCount.ToString() +" times";
   }
	
	// Update is called once per frame
	void Update () {
	
	}
}
