using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task3 : MonoBehaviour
{
    // How much we are getting paid.
    public int dollarsPaid;

    private void Start() {
        // This program will go down the list from hundred, fifty, twenty, ten, five, and one.
        // dollarsPaid is updated to ensure that the bills that are already paid are taken out.
        int hundreds = dollarsPaid / 100;
        dollarsPaid -= hundreds * 100;

        int fiftys = dollarsPaid / 50;
        dollarsPaid -= fiftys * 50;

        int twentys = dollarsPaid / 20;
        dollarsPaid -= twentys * 20;

        int tens = dollarsPaid / 10;
        dollarsPaid -= tens * 10;

        int fives = dollarsPaid / 5;
        dollarsPaid -= fives * 5;

        int ones = dollarsPaid / 1;
        dollarsPaid -= ones * 1;

        // Print everything out.
        // Only print the bills we are receiving.
        if(hundreds > 0)
            print("You will receive " + hundreds + " hundreds!");
        if(fiftys > 0)
            print("You will receive " + fiftys + " fiftys!");
        if(twentys > 0)
            print("You will receive " + twentys + " twentys!");
        if(tens > 0)
            print("You will receive " + tens + " tens!");
        if(fives > 0)
            print("You will receive " + fives + " fives!");
        if(ones > 0)
            print("You will receive " + ones + " ones!");
    }

}
