using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin7: MonoBehaviour
{   const float ROTATION_SPEED = -55;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var parentTransform = transform.parent;
        transform.RotateAround(parentTransform.position, new Vector3(0.0f, 0.0f,1.0f), ROTATION_SPEED* Time.deltaTime);
    }
}
