using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Data;


public class MadLibs : MonoBehaviour
{
    public bool Statement = true;
    public string verb = "punch";
    public string noun = "nigger";
    public string adjective = "skibidii";
    public int number = 99;
    public string pluralNoun ="gay";
    public float percent =64.68F;

    private TextMeshProUGUI textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        textMeshPro.text = $"The statement is {Statement}. I did not {verb} the {noun}. I am not guilty. I am a {adjective} person. The act was performed by {number} wandering {pluralNoun}. I am {percent}% sureof this.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
