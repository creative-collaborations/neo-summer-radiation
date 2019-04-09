using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPunchCard : Card
{
    float ULT_MULTIPLIER = 2.0f;
    float DMG_MULTIPLIER = 3.0f;
    string CARD_COLOR = "RED";
    string CARD_TYPE = "PUNCH";

    public override float getUltMultiplier(){
      return this.ULT_MULTIPLIER;
    }

    public override float getDamageMultiplier(){
      return this.DMG_MULTIPLIER;
    }

    public override string getCardColor() {
        return this.CARD_COLOR;
    }

    public override string getCardType(){
      return this.CARD_TYPE;
    }
}
