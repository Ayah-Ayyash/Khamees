using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Khamees : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
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
    }
}

