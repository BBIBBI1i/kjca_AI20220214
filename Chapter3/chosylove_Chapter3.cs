using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chosylove_Chapter3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string nurby = "30";
        string nopy = "40";
        int nurBY = int.Parse(nurby);
        int noPY = int.Parse(nopy);
        int nullby = nurBY * noPY;

        Debug.Log($"�簢���� �ʺ�� {nurby}�Դϴ�.");
        Debug.Log($"�簢���� ���̴� {nopy}�Դϴ�.");
        Debug.Log($"�簢���� ���̴� : {nullby}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
