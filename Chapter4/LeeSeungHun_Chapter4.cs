using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeeSeungHun_Chapter4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //1 i++�� ++i�� �������� �����ΰ���?
        int a = 10;
        Debug.Log(a++);
        Debug.Log(++a);
        //�� : i++�� ��� i�������� +1 �̰�
        //++i �� ��� i�������� +1 �Դϴ�.

        //2 �� ��¹��� ���� ��������
        //int i = 1;
        //Debug.Log(i - i + 1); ��: 1
        //Debug.Log(i++);       ��: 1
        //Debug.Log(++i);       ��: 3
        //Debug.Log(i += 1);    ��: 4
        //3. ���� �ڵ忡�� b�� � ���� �������? 
        //int a = 10;
        //string b = a == 0 ? "������" : "ABC";
        //��: ABC


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
