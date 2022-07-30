using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

public class message : MonoBehaviour
{
  public Text messageText = null;
  public Button messageBut;
  public Button checkBut;
  int levelCount = 0;

// make new alphabet and print message
  public void shuffleAlpha()
  {
    string[] alphabet = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n","o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};
    string[] messList = {"hello","b","c","d","e","f","g","h"};
    string levelMessage = null;
    // change [0] to be level number
    levelMessage = messList[levelCount];
    messageText.text = levelMessage;
    messageText.text = messList[0];

    // hide button after opening the messListage
    messageBut.gameObject.SetActive(false);

    List<string> newAlpha = new List<string>();
    var rnd = new Random();
    var randomized = alphabet.OrderBy(item => rnd.Next());

    foreach (string letter in randomized)
    //foreach (string letter in alphabet)
    {
        newAlpha.Add(letter);
    }

    string result = "Normal alphabet: ";
    foreach (var item in alphabet)
    {
        result += item.ToString() + ", ";
    }
    Debug.Log(result);

    string result2 = "New alphabet: ";
    foreach (var item in newAlpha)
    {
        result2 += item.ToString() + ", ";
    }
    Debug.Log(result2);

  }

  public Text userInput;

  public void checkAns()
  {
    string theirAns = userInput.text;
    string encAns = messageText.text;

      if (theirAns != encAns)
      {
        Debug.Log("Wrong");
      }
      else
      {
        Debug.Log("Correct");}
      }
  }

