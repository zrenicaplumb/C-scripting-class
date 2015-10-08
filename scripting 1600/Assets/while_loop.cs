using UnityEngine;
using System.Collections;

public class while_loop : MonoBehaviour
{

    int numSpiders = 5;


    void Start()
    {
        for (int i = 0; i < numSpiders; i++)
        {
            print("creating spider number:" + i);
        }

        int bob = 0;
        while (bob < 6)
        {
            print("bob is not 6 yrs old yet");
            bob += 1;
            if (bob >= 6)
            {
                print("bob is 6 yrs old now");
            }
        }
        bool skyIsBlue = true;
        do
        {
            print("sky is blue");
            
        } while (skyIsBlue);
    }
}
