using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloUnity : MonoBehaviour
{

    int a = 30;
    int b = 40;

    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("�簢���� �ʺ��:"+(a));
        Debug.Log("�簢���� ���̴�:"+(b));
        Debug.Log("�簢���� ����:" + (a * b));

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))

        {

            Debug.Log("Hello, C# World!");

        }
        if (Input.GetKeyDown(KeyCode.F2))

        {

            Debug.Log("������, �ȳ��ϼ���?");
            Debug.Log("�ݰ����ϴ�!");

        }
        if (Input.GetKeyDown(KeyCode.F3))

        {

            Debug.Log("C# ����� �ʾƿ�~");
            Debug.Log("�츮 ����!");
            Debug.Log("�ͼ��������ô�~");

        }
    }
}
