using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choiyounghwa_Chapter3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string a = "30";
        string b = "40";

        int c = int.Parse(a);
        int d = int.Parse(b);

        int e = c * d;

        Debug.Log($"�簢���� �ʺ��{c}�Դϴ�");
        Debug.Log($"������� ���̴�{d}�Դϴ�");
        Debug.Log($"�簢���� ���̴� : {e}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}