using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeEnemySpin : MonoBehaviour
{

    public float spinSpeed;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, 0, 100) * Time.fixedDeltaTime * spinSpeed);
    }
}
