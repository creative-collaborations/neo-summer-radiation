using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowCard : Card
{
    float ULT_MULTIPLIER = 1.0f;
    float DMG_MULTIPLIER = 2.0f;
    string CARD_TYPE = "YELLOW";

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public override float getUltMultiplier(){
      return this.ULT_MULTIPLIER;
    }

    public override float getDamageMultiplier(){
      return this.DMG_MULTIPLIER;
    }

    public override string getCardType(){
      return this.CARD_TYPE;
    }
}
