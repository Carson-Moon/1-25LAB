using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task2 : MonoBehaviour
{
    //Note how much books cost
    //Then how many books are bought

    public int bookPrice;
    public int booksBought;

    //A variable that cannot be changed or seen but is still referenced 
    private int totalPrice;
    private int totalLoss;

    // Start is called before the first frame update
    private void Start()
    {
        //Calculating the price of the book after the 40% discount
        float storePrice = bookPrice - (bookPrice * .40f);

        //Determines how much shipping is depending on how many books are bought
        //Then gives you the total rounded to the next dollar
        //Lastly it determines the cost of the transaction after the store's discount
        if (booksBought == 1)
        {
            totalPrice = Mathf.RoundToInt(storePrice) + 3;
            totalLoss = Mathf.RoundToInt(storePrice) - bookPrice;

            print("Total recieved from sale: " + totalPrice.ToString("F2"));
            print("Total cost of sale: " + totalLoss.ToString("F2"));
        }
        else if (booksBought >= 2)
        {
            totalPrice = Mathf.RoundToInt((storePrice + 3f + ((booksBought - 1f) * .75f)) * booksBought);
            totalLoss = Mathf.RoundToInt((storePrice + 3f + ((booksBought - 1f) * .75f)) * booksBought) - (bookPrice * booksBought);

            print("Total recieved from sale: " + totalPrice.ToString("F2"));
            print("Total cost of sale: " + totalLoss.ToString("F2"));

        }
        else if (booksBought <= 0)
        {
            print("Sorry, it doesn't look like you bought anything.");
        }

    }
}