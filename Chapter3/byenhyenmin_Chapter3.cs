using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class byenhyenmin_Chapter3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string a = "30";
        string b = "40";

        Debug.Log($"�簢���� �ʺ�� {a}�Դϴ�");
        Debug.Log($"�簢���� �ʺ��{b}�Դϴ�");
        int f = int.Parse(a);
        int e = int.Parse(b);
        Debug.Log($"�簢���� ���̴�:{f * e}");

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
