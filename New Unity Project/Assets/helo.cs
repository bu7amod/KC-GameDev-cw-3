using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helo : MonoBehaviour
{

    //hero stats

    string heroName = "batman";
    int heroPower = 50;

    //villain stats

    string villainName = "joker";
    int villainPower = 70;

    float playerSpeed = 0;


    // Start is called before the first frame update
    void Start()
    {
        if (villainPower > heroPower)
        {

            print("joker : you can't defeat me HAHAHA");

        }
        else if (villainPower < heroPower)
        {
            print("IM BATMAN");

        }
        else
        {

            print("this is a fair fight");
        }

        SetSpeed(2.5f);
    }

   




    void SetSpeed (float Speed )
    {
        print(playerSpeed);
        playerSpeed = Speed;
        print(playerSpeed);     
    }


    
    // Update is called once per frame
    void Update()
    {
        
    }
}
