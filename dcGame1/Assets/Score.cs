using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Score : MonoBehaviour
{
    public static int skorMe = 0; public static int skorAmy = 0;public static int skorRemy = 0; public static int skorLeonard = 0;
    TextMeshProUGUI scoreMe; TextMeshProUGUI scoreAmy; TextMeshProUGUI scoreRemy; TextMeshProUGUI scoreLeonard;

    
    
    void Start()
    {
        

        scoreMe = GameObject.Find("Canvas/scoreMe").GetComponent<TextMeshProUGUI>();
        scoreAmy = GameObject.Find("Canvas/scoreAmy").GetComponent<TextMeshProUGUI>();
        scoreRemy = GameObject.Find("Canvas/scoreRemy").GetComponent<TextMeshProUGUI>();
        scoreLeonard = GameObject.Find("Canvas/scoreLeonard").GetComponent<TextMeshProUGUI>();

    }

    

      void Update()
    {
        scoreMe.text = "Ben: " + skorMe.ToString();
        scoreAmy.text = "Amy: " + skorAmy.ToString();
        scoreLeonard.text = "Leonard: " + skorLeonard.ToString();
        scoreRemy.text = "Remy: " + skorRemy.ToString();

    }
}
