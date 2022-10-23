using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TryingLib.Unity.Greeter;

public class TestingGreeting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var greeter = new Greeter("your-Name");
        Debug.Log(greeter.GetGreeting());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
