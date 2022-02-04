using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;

    }

    // Update is called once per frame
    void Update()
    { if (Input.GetKeyDown(KeyCode.Space)) {
            pos = new Vector3(pos.x, pos.y, pos.z - 2f);

        }
        transform.position = Vector3.Lerp(transform.position, pos, 0.1f);
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0,180), 0.1f);
    }
}
