using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    float timer = 5f;
    public GameObject Enemy;
    public GameObject target;

    void Start () {
        InvokeRepeating("Spawn", timer, timer);
    }

    void Spawn()
    {
        GameObject clone = Instantiate(Enemy, this.transform.position, Quaternion.identity);
        clone.GetComponent<EnemyFacing>().target = target;
    }
}
