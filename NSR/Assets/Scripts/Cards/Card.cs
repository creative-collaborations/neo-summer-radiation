using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Card : ScriptableObject
{
    // Getters/setters

    abstract public float getUltMultiplier();

    abstract public float getDamageMultiplier();

    //Get card type: PUNCH, KICK, or SPECIAL
    abstract public string getCardType();

    //Get card color: GREEN, YELLOW, RED, BLUE
    abstract public string getCardColor();

}
