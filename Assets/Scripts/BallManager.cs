using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallManager : MonoBehaviour
{
    float addPoint;
    [SerializeField] UIManager UIManager;
    bool isGrabbed = false;
    bool isSleeping = false;

    private void Update()
    {
        // 一度キューブを掴んだらisGrabbledをtrueに変更
        if (this.GetComponent<Rigidbody>().IsSleeping() == false)
        {
            isGrabbed = true;
        }
    }

    private void OnCollisionEnter(Collision target)
    {
        // 掴まれた後かつ、静止状態かつ、数字と接触していたら、ポイント表示に加算
        if (isGrabbed == true && (target.gameObject.name == "10" || target.gameObject.name == "20" || target.gameObject.name == "30" || target.gameObject.name == "40" || target.gameObject.name == "50"))
        {
            addPoint = float.Parse(target.gameObject.name);
            UIManager.AddPoint(addPoint);
        }
    }
}
