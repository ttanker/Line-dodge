using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         string characterName = "���";
         char bloodType = 'A';
         int age = 17;
         float height = 168.3f;
         bool isFemale = true;
        int love = 60;

         Debug.Log("ĳ���� �̸� : " + characterName);
         Debug.Log("������ : " + bloodType);
         Debug.Log("���� : " + age);
         Debug.Log("Ű : " + height);
         Debug.Log("�����ΰ�? : " + isFemale);
        Debug.Log("ȣ���� : " + love);
       
        for (int j = 0; j < 100; j++)
        {
            Debug.Log(j + "ȸ��.. �÷��̾ ���� ���� Ÿ�� ���� �մϴ�! ");
            if (love >= 90)
            {
                Debug.Log("���� ��ȥ�Ͽ���!");
            }
            else if (love >= 70 && love < 90)
            {
                Debug.Log("���� ����Ʈ�� ���� �߽��ϴ�~");
            }
            else
            {
                Debug.Log("��󿡰� ������!");
            }
            
            love += 1;

            if (love > 90)
            { 
                break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
