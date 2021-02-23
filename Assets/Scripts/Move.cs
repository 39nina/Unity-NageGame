using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody rb;
    float moveSpeed = 5;

    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 SecondaryThumstick = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick);

        // Y軸をZ軸に変換する
        Vector3 velocity = new Vector3(SecondaryThumstick.x, 0, SecondaryThumstick.y);

        rb.velocity = velocity * moveSpeed;
    }
}
