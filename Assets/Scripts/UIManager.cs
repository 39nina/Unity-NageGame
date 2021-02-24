using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    float point = 0;
    [SerializeField] Text pointText = default;

    public void AddPoint(float addPoint)
    {
        point += addPoint;
        pointText.text = point.ToString();
    }
}
