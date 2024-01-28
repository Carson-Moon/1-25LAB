using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task2 : MonoBehaviour
{
    //Note how much books cost
    //Then how many books are bought

    public float bookPrice;
    public float booksBought;

    //Variables that cannot be changed or seen but are still referenced
    //One marks Gain from sale, the other marks Cost of sale.
    private float totalGain = 0;
    private float totalCost = 0;

    // Start is called before the first frame update
    private void Start()
    {
        //Calculating the price of the book after the 40% discount
        float storePrice = bookPrice - (bookPrice * .40f);

        //Determines how much shipping is depending on how many books are bought
        //Then gives you the total rounded to the tenth decimal point
        //Lastly it determines the cost of the transaction after the store's discount
        if (booksBought == 1)
        {
            totalCost = storePrice + 3;
            totalGain = bookPrice;

            print("Total recieved from sale: " + totalGain.ToString("F2"));
            print("Total cost of sale: " + totalCost.ToString("F2"));
        }
        else if (booksBought >= 2)
        {
            // Calculate price and shipping
            totalCost = storePrice * booksBought;
            totalCost += 3 + (booksBought - 1) * .75f;
            totalGain = bookPrice * booksBought;

            print("Total recieved from sale: " + totalGain.ToString("F2"));
            print("Total cost of sale: " + totalCost.ToString("F2"));

        }
        else if (booksBought <= 0)
        {
            print("Sorry, it doesn't look like you bought anything.");
        }

    }
}