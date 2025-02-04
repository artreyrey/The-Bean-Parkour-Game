using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using UnityEditor.Rendering;
public class MyObjects : MonoBehaviour
{
    [field: SerializeField]
    public int GoldPieces {get; set;}
    private TextMeshProUGUI textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
   public void ShowMessage()
   {
    PropertyPerson artreyrey = new PropertyPerson();
    artreyrey.FirstName = "art";
    artreyrey.lastName = "reyrey";
    textMeshPro.text = artreyrey.FullName;
        // LeaderboardEntry entry1 = new LeaderboardEntry();
        // LeaderboardEntry entry2 = new LeaderboardEntry();
        // LeaderboardEntry entry3 = new LeaderboardEntry();


        // entry1.Score = 100;
        // entry1.Initials = "BDM";

        // entry2.Score = 300;
        // entry2.Initials = "RTM";

        // entry3.Score = 400;
        // entry3.Initials = "JBN";

        // LeaderboardEntry [] entries = { entry1, entry2, entry3};
        // string message = "";
        // foreach(LeaderboardEntry entry in entries)
        // {
        //     message += $"{entry.Score}\t{entry.Initials}\n";
        // }
        // textMeshPro.text = message;

        // Fighter bezerker = new Fighter();
        // bezerker.Name = "Luis";
        // bezerker.Strength = 18;

        // Fighter leader = new Fighter();
        // leader.Name = "Aragaon";
        // leader.Strength = 14;

        // string message = bezerker.GetSpeech();
        // message += leader.GetSpeech();
        // textMeshPro.text = message;

        // bezerker.Speak();
        // leader.Speak();

        // string message = $"I'm {bezerker.Name} and I have {bezerker.Strength} strength\n";
        //  message += $"I'm {leader.Name} and I have {leader.Strength} strength";
        //  textMeshPro.text = message;
   }
}
