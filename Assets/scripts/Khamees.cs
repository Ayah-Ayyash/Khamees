using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Khamees : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        // string FirstName="Ayah";
        // string LastName="Ayyash";

        // Debug.Log(FirstName.Length);

        // if ((5 + 5) + 3 == 12)
        // {
        //     Debug.Log("winer");


        // }
        // else {
        //     Debug.Log("loser");

        // }

    int count=0;
    while(count<=5){
        int RandomNumber=Random.Range(1,5);
        Debug.Log(RandomNumber);
        count++;
        if(RandomNumber == 2) break;
        Debug.Log("Break");
    }




    }

}

