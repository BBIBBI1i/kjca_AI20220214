using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimMinSeo_Chapter3 : MonoBehaviour
{   
    void Start()
    {
        // �������� 1
        string a = "30";
        string b = "40";
        int x = int.Parse(a);
        int y = int.Parse(b);

        Debug.Log($"�簢���� �ʺ�� {a}�Դϴ�");
        Debug.Log($"�簢���� ���̴� {b}�Դϴ�");
        Debug.Log($"�簢���� ����: {x * y}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
