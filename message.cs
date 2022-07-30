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
  //char[] alphabet = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};

  public void shuffleAlpha()
  {
    string[] alphabet = {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r", "s", "t","u","v","w","x","y","z"};
    string[] mess = {"hello","b","c","d","e","f","g","h"};
    /*string levelMessage = null;
    // change [0] to be level number
    levelMessage = mess[0];
    messageText.text = levelMessage;*/
    messageText.text = mess[0];

    // hide button after opening the message
    messageBut.gameObject.SetActive(false);

/*
    int keyShift = 2;
    int keyShiftCount = 0;
    List<char> newAlpha = new List<char>();

    while (keyShiftCount < keyShift) {
        // append
        newAlpha.Add(alphabet[keyShiftCount]);
        // remove
        newAlpha.Remove(newAlpha[keyShiftCount]);
        keyShiftCount++;
      }

*/
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

}
