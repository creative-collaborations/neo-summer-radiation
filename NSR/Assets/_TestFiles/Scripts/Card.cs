using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Card : ScriptableObject
{
    // Getters/setters

    abstract public float getUltMultiplier();

    abstract public float getDamageMultiplier();

    abstract public string getCardType();

}
