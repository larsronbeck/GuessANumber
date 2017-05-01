using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {

   int max;
   int min;
   int guess;
   public int maxGuessesAllowed = 7;
   int guessesLeft = 7;
   public static int guessCount = 0;
   public Text text;

  // Use this for initialization
   void Start () 
   {
      // Anropar startfunktion en gång direkt
      StartGame();
   }
   // Funktionen anropas när man klickar på knappen GuessLower (när talet som man tänker på är lägre än slumptalet)
   public void GuessLower()
   {
      // maxvärdet anges till slumptalet
      max = guess;
      // efter tilldelningen anropas funktionen NextGuess
      NextGuess();
   }
  public void GuessHigher()
  {
      min = guess;
      NextGuess();
  }
  void StartGame()
  {
      // tilldelar 100 som max
      max = 100;
      // tilldelar 1 som min
      min = 1;
      // tilldelar ett slumptal mellan min och max till guess
      guess = Random.Range(min, max + 1);
      // omvandlar och visar ett heltal till sträng i textrutan
      text.text = guess.ToString();
  }
  void NextGuess()
  {
      // guess tilldelas summan av (max och min)/2
      guess = (max + min) / 2;
      // textrutan visar nya beräkningen      
      text.text = guess.ToString();
      // värdet på maxGuessesAllowed räknas ner ett steg
      maxGuessesAllowed = maxGuessesAllowed - 1;
      guessCount = (guessesLeft-maxGuessesAllowed);
      // om man använt max antal gissningar så vinner användaren
      if (maxGuessesAllowed <= 0)
      {
         SceneManager.LoadScene("Win");         
      }
        
  }
}
