using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Khamees : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        //Q1
        int count = 0;
        while (count < 20)
        {
            int RandomCount = Random.Range(1, 21);
            Debug.Log(RandomCount);
            count++;
            if (RandomCount == 5) continue;
            Debug.Log("Loser");
            if (RandomCount == 15) break;
            Debug.Log("LoserAgain");
        }


        //Q2
        string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };

        string Arr = "";
        int counter = 0;

        while (count < 7)
        {
            int randomArray = Random.Range(0, words.Length);
            Arr += words[randomArray] + " ";
            counter++;
        }
        Debug.Log(Arr);

    }
}






// int s=0;
// while(s<words.Length){
//     Debug.Log(words[s]);
//     s++;