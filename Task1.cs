using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Task1 : MonoBehaviour
{
    // The name of this course.
    public string courseName;

    // Challenge Score Variables
    //We can have between 0 and 15 modules.
    //We can have between 0 and 30 reading materials.
    //We can have between 0 and 15 quizzes.
    //We can have between 0 and 30 assignments.
    public int numModules;
    public int numReadingMaterials;
    public int numQuizzes;
    public int numAssignments;

    public bool hasTaughtClass;

    private void Start()
    {
        float _totalScore = 0;

        // Calculate percentages and add to totalScore. 
        _totalScore += CalculateScoreFifteen(numModules) + CalculateScoreFifteen(numQuizzes) +
            CalculateScoreThirty(numReadingMaterials) + CalculateScoreThirty(numAssignments) + CalculateTeacher(hasTaughtClass);

        // Print our information.
        print(courseName + "has a challenge score of " + _totalScore.ToString());
    }

    private float CalculateScoreFifteen(int _num)
    {
        // Determine score based on num and 15 as the percentage.
        if(_num <= 5)
        {
            return .5f;
        }else if(_num <= 10)
        {
            return 1.0f;
        }else if(_num <= 15 || _num > 15)
        {
            return 1.5f;
        }

        return 0.0f;
    }

    private float CalculateScoreThirty(int _num)
    {
        // Determine score based on num and 30 as the percentage.
        if (_num <= 10)
        {
            return 1.0f;
        }
        else if (_num <= 20)
        {
            return 2.0f;
        }
        else if (_num <= 30 || _num > 30)
        {
            return 3.0f;
        }

        return 0.0f;
    }

    private float CalculateTeacher(bool taughtBool)
    {
        if(taughtBool)
        {
            return 0.0f;
        }else
        { 
            return 1.0f; 
        }    
    }

}
