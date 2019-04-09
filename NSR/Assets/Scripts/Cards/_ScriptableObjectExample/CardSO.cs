using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Card", menuName ="Cards")]
public class CardSO : ScriptableObject
{
    //How to create a Card ScriptableObject on Editor:
    //Right click on Project tab, select Create > Cards.

    public string cardColor;
    public string cardType;
    public float damageMultiplier;
    public float ultMultiplier;

    public Sprite cardSprite;
}
