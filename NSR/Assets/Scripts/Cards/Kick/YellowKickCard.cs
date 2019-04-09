using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowKickCard : Card
{
    float ULT_MULTIPLIER = 1.0f;
    float DMG_MULTIPLIER = 2.0f;
    string CARD_COLOR = "YELLOW";
    string CARD_TYPE = "KICK";

    public override float getUltMultiplier() {
        return this.ULT_MULTIPLIER;
    }

    public override float getDamageMultiplier() {
        return this.DMG_MULTIPLIER;
    }

    public override string getCardColor() {
        return this.CARD_COLOR;
    }

    public override string getCardType() {
        return this.CARD_TYPE;
    }
}
