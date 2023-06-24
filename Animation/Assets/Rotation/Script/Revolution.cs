using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolution : MonoBehaviour
{
    public GameObject moon, moon1;
    public GameObject origin;
    public float speed = 1.0f;

    void Start()
    {
        StartCoroutine(RotateCoroutine());
    }

    IEnumerator RotateCoroutine()
    {
        while (true)
        {
            transform.RotateAround
            (
            origin.transform.position,
            Vector3.down,
            speed * Time.deltaTime
            );

            moon.transform.Rotate(0.1f, 0.1f, 0.1f);
            moon1.transform.Rotate(-0.5f, -0.5f, -0.5f);

            yield return null;
        }
    }
}
