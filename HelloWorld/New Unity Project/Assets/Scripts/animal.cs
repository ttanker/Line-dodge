using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animal : MonoBehaviour
{
    public string name;
    public string sound;

    public void PlaySound()
    {
        Debug.Log(name + ":" + sound);
    }
    // Start is called before the first frame update
    void Start()
    {
        animal tom = new animal();
        tom.name = "Åè";
        tom.sound = "³Ä¿Ë!";

        animal jerry = new animal();
        jerry.name = "Á¦¸®";
        jerry.sound = "ÂïÂï";

        jerry = tom;
        jerry.name = "¹ÌÅ°";

        tom.PlaySound();
        jerry.PlaySound();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
