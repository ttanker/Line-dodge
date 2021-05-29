using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         string characterName = "라라";
         char bloodType = 'A';
         int age = 17;
         float height = 168.3f;
         bool isFemale = true;
        int love = 60;

         Debug.Log("캐릭터 이름 : " + characterName);
         Debug.Log("혈액형 : " + bloodType);
         Debug.Log("나이 : " + age);
         Debug.Log("키 : " + height);
         Debug.Log("여성인가? : " + isFemale);
        Debug.Log("호감도 : " + love);
       
        for (int j = 0; j < 100; j++)
        {
            Debug.Log(j + "회차.. 플레이어가 라라와 썸을 타기 시작 합니다! ");
            if (love >= 90)
            {
                Debug.Log("라라와 결혼하였다!");
            }
            else if (love >= 70 && love < 90)
            {
                Debug.Log("라라와 데이트를 성공 했습니다~");
            }
            else
            {
                Debug.Log("라라에게 차였다!");
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
