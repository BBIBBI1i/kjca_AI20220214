using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leehyeonchan_chapter4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 1. i ++�� ++i�� �������� �����ΰ���?
        // ���������� ++i�� i�� ���� 1 ���� ��Ų�Ŀ� ������ ���� return �մϴ�
        // ���������� i++�� i�� ���� 1 ���� ��Ų �Ŀ� , �����Ǳ� ���� ���� return �մϴ�

        //  2. ��¹� �� �ۼ��ϼ���
        int i = 1;
        Debug.Log(i = i + 1); 
        Debug.Log(i++); 
        Debug.Log(++i); 
        Debug.Log(i += 1);

        // ���� ����
        //  Debug.Log(i = i + 1);  �� : 2
        //  Debug.Log(i++); �� : 2
        //  Debug.Log(++i); �� :4
        //  Debug.Log(i += 1); ��: 5

        //3. ���� �ڵ忡�� B �� � ���� �������>?

        // int a = 10;
        // string b = a == 0 ? "������" : "ABC";

        int a = 10;
        string b = a == 0 ? "������" : "ABC";

        Debug.Log(b);

        // �� : �ѱ����� ���������� �˷��ִ°�!





    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
