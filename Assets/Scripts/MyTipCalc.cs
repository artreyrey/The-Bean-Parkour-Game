using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class MyTipCalc : MonoBehaviour
{
    private TextMeshProUGUI textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TipCalculator()
    {
        int tip = 300;
        int cash = 400;  

        int tipTotal;
        float tipPercent = .2F;

        tipTotal = cash - tip;
        tipPercent = (cash/tip) * 100;

        textMeshPro.text = $"Tip Total is {tipTotal} and Tip Percentage is {tipPercent}"  ;
    }

    
}
