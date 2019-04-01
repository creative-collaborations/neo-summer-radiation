using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public int COMBO_LIMIT = 8;
    public int DECK_LIMIT = 40;
    private int comboCount= 0;
   
    private List<Card> deck;


    // Start is called before the first frame update
    void Start()
    {
        this.deck = initializeDeck();
    }
    public List<Card> initializeDeck(){
        List<Card> cards = new List<Card>();

        for (int i=0; i< 10; i++){        
            cards.Add(new YellowCard());
            cards.Add(new BlueCard());
            cards.Add(new GreenCard());
            cards.Add(new RedCard());
        }
        
        return cards; // Cards are not shuffled yet, they go in the order of YBGR,YBGR, x10

    }

 


    public int getComboLimit(){
        return this.COMBO_LIMIT;
    }

    public void setComboCount(int x){
        this.comboCount=x;
    }
    public void addComboCount(int x){
        this.comboCount+=x;
    }

    public void resetComboCount(){
        this.comboCount=0;
    }

    public List<Card> getCards(){
        return this.deck;
    }

    // Update is called once per frame
    void Update()
    {
        if(this.deck.Count ==0 ){
            this.deck = initializeDeck();
        }
    }
}
