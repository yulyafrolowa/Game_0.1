using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannon : MonoBehaviour
{
    public float period = 1f;
    private float lastBallTime;
    public Cannonball prefab;
    public float rotationSpeed = 50f;
    private float direction = -1;
    // Start is called before the first frame update
    void Start()
    {
        lastBallTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        lastBallTime += Time.deltaTime;

        if(lastBallTime > period)
        {
            Instantiate(prefab, transform.position, transform.rotation);
            lastBallTime = 0;
        }
        if(lastBallTime > period / 2)
        {
            float rotationValue = rotationSpeed * Time.deltaTime * direction;
            Vector3 rotateVector = new Vector3(0, 0, rotationValue);
            transform.Rotate(rotateVector);

            if (transform.rotation.z < -0.9999 || transform.rotation.z > 0)
                direction *= -1;
        }
    }
}
