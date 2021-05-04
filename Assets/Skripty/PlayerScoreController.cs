using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScoreController : MonoBehaviour {

    public Hrac hracvar;

    public Text scoretext;
    public Text moneytext;

    void Update()
    {
        scoretext.text = "Score: " + hracvar.score;
        moneytext.text = "Credits: " + hracvar.credits;
    }
}
