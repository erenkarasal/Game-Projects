using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KbZombie : MonoBehaviour
{
    public Transform zombi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(zombi.position.x,100f,zombi.position.z ) ;
        transform.rotation = Quaternion.Euler(zombi.eulerAngles.x+90F,zombi.eulerAngles.y,zombi.eulerAngles.z);
    }
}
