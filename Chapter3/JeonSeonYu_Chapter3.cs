using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JeonSeonYu_Chapter3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string a = "30";
        string b = "40";

        int w = int.Parse(a);
        int h = int.Parse(b);

        Debug.Log($"�簢���� �ʺ�� {w}�Դϴ�.");
        Debug.Log($"�簢���� ���̴� {h}�Դϴ�.");
        Debug.Log($"�簢���� ���̴� : {w * h}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
