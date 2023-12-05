using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {
    float rotationAngle = 30f;

    void Update() {
        transform.Rotate(0f, rotationAngle * Time.deltaTime, 0f);
    }
}
