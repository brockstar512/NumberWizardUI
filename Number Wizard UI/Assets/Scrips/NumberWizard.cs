using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//if it was a normal text field i'd say



public class NumberWizard : MonoBehaviour
{
    //serializers show up on the inspector where the game object has the script
    [SerializeField] int max;
    [SerializeField] int min;
    // how to make something like guess show up on the screen?
    //first we need to serialize a variable that allows us to conect the two together
    //we have to make the serialized field exactly what the output type is... in our case the ??? are text mess pro
    [SerializeField] TextMeshProUGUI guessText;
    //**this should serialize onto your project file but you need to drag the TEXT FILE THAT HAS THE TEXT YOU want the variable to be
    //basically you need to drag the text box object to the varaible that you want shown on the texct box
    //but we need to make the data type a string

    int guess;

    // Start is called before the first frame update
    //start always gets called upon laoding
    void Start()
    {
        StartGame();
    }
    void StartGame()
    {
       NextGuess();
    }
   public void OnpressHigher()
    {
        min = guess + 1;
        NextGuess();
    }
    public void OnpressLower()
    {
        max=guess - 1;
        NextGuess();

    }

    void NextGuess()
    {                   //min is inclusive and max is exclusive
        guess = Random.Range(min,max + 1);
        //im not completely sure what the .text means exactly
        guessText.text=guess.ToString();
        
    }


}
