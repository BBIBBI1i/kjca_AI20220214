using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yangchaeeun_Chapter4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //1. i++�� i�� ���� �ν��ϰ� �������Ѵ�. ++i�� ������ �����ϰ� i�� �ν��Ѵ�.

        //2.
        int i = 1;
        Debug.Log(i = i + 1); // �� : 1 = 2
        Debug.Log(i++); //�� : 2
        Debug.Log(++i); //�� : 4
        Debug.Log(i += 1); //�� : 5

        //3. ABC
        int a = 10;
        string b = a == 0 ? "������" : "ABC";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
