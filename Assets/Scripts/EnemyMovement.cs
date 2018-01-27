using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    public float speed = 0.5f;

    void FixedUpdate()
    {
        transform.position += transform.right * speed * Time.deltaTime;
    }
}
