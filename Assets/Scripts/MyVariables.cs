using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MyVariables : MonoBehaviour
{
    //just a scratchpad for playing with variables - not to be sued in production
   /* private int health = 100;
    private int Health = 100;
    private int HeAlTh = 100;
    private int myHealth = 100;
    private string messageForTheTextView = "This space is for rent";
    private const int PlayerScore = 100;
    private const int PLAYER_SCORE = 100;
    */
    public string firstName;
    public string lastName;
    private TextMeshProUGUI textMeshPro;

    // Start is called before the first frame update
    void Start()
    {
    
       textMeshPro = GetComponent<TextMeshProUGUI>();
       textMeshPro.text = $"Hello {firstName} {lastName}!" ;
    }

    // Update is called once per frame
    void Update()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        textMeshPro.text = $"Player: {firstName}{lastName}!";

       
    }
}
