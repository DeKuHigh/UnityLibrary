
using UnityEngine;
using UnityEngine.UI;

namespace Unity.movement.align
{
    /// <summary>
    /// Tried to implement to movement class for Unity Engine
    /// </summary>
    public class movement:MonoBehaviour
    {
        
            //general value for the speed that can be altered by calling speed variable or can be change from the inspector panel in unity
        public float speed = 10.5f;

    // Update is called once per frame
    public void Move()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("w"))
        {
            pos.z += speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.z -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }
       

        transform.position = pos;
    }
     
    }
}
