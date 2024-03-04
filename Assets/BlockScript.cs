using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour {
    public float fallingSpeed = 10f;
    void Start () {
        GetComponent<Rigidbody2D> ().gravityScale += Time.timeSinceLevelLoad / (300f / fallingSpeed);
    }

    void Update () {
        if (transform.position.y < -2f) {
            Destroy (gameObject);
        }
    }
}