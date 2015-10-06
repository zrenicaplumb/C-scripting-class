using UnityEngine;
using System.Collections;

public class if_statement : MonoBehaviour {
    public float velocity = 85.0f;
    public float maxVelocity = 70.0f;
    public float minVelocity = 40.0f;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            velocityTest();

        velocity -= Time.deltaTime * 5;

        
    }

    void velocityTest() {
        if(velocity > maxVelocity)
        {
            print("too fast");
        }
       else if(velocity < minVelocity)
        {
            print("too slow.");
        }
        else
        {
            print("good speed");
        }
    }
}
