using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string a = "30";
        string b = "40";
        
        int x= int.Parse (a);
        int y= int.Parse (b);

        Debug.Log($"�簢���� �ʺ�� {x}�Դϴ�.");
        Debug.Log($"�簢���� ���̴� {y}�Դϴ�.");
        Debug.Log($"�簢���� ���̴� {x * y}�Դϴ�.");





    }

    // Update is called once per frame
    void Update()
    {

    }
}
