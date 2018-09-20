using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{   //int=heltal Float=, Double=bouble float. Bool= ja,nej. Char=x,a,1,2 string=

    public bool testBool = true;
    public char testChar = 'a';
    public string testString;
    public string mening1;
    public string mening2;
    public string mening3;
    public float number;
    public float @base;
    public float angle;
    public float tårtbitar;
    public string username;
    public float radius;
    public int damage;
    public int life;
    public int demoner;
    public int minDamage;
    public int maxDamage;  

    // Use this for initialization
    void Start()
    {
        Uppgift1();
        Uppgift2();
        Uppgift3();
        uppgift4();
        uppgift5();
        uppgift5a();
        uppgift6();
        uppgift7();
        uppgift8();
    }
    void Uppgift1()
    {
        Debug.Log(string.Format("svaret på (963 * 421) - (175463 / 87) är {0}",
            (963f * 421f) - (175463F / 87f)));
    }
    void Uppgift2()
    {
        Mening1();
        Mening2();
        Mening3();
    }
    void Mening1()
    {
        Debug.Log(mening1);
    }
    void Mening2()
    {
        Debug.Log(mening2);
    }
    void Mening3()
    {
        Debug.Log(mening3);
    }
    void Uppgift3()
    {
        Debug.Log(string.Format("talet {0} upphöjt med 2 blir {1}. " +
            "Roten ur talet {0} blir {2}", number, Mathf.Pow(number, 2), Mathf.Sqrt(number)));

    }
    void uppgift4()
    {
        Debug.Log(string.Format("om du tar basen {0} och gångrar det med höjeden 8 och sen delar det på 2 får du triangelns area som är  {1}cm2", @base, (@base * 8f / 2f)));
    }

    void uppgift5()
    {
        Debug.Log(string.Format("om du tar tårtans vinkel 360 och delar på vinkel {0} får du hur {1} tårtbitar ", angle, (360f / angle)));
    }
    void uppgift5a()
    {
        Debug.Log(string.Format(" om {0} peroner får 1 tårtbit var, blir vinkeln {1} på dom {0} tårtbitarna ", tårtbitar, (360f / tårtbitar)));
    }

    void uppgift6()
    {
        Debug.Log(string.Format("cheif {0} of dreams", username));
    }

    void uppgift7()
    {
        Debug.Log(string.Format("om du tar radien {0} och vill ha ett klots volym gångrar du {0} med sig själv som blir {1}.\nSen gångar du det med 4 och sen delar du på 3 och sen gångrar med 3,14 så får du klotets volym som är {2}", radius, (radius * radius * radius), (radius * radius * radius * 4f * 3.14f / 3)));
    }

    void uppgift8()
    {
        Debug.Log(string.Format("om du skadar {0} damage på en fiende med 890000 måste du slå fienden {1} gånger", damage, (890000 / damage))); 

        Debug.Log(string.Format("demonen har {0} liv", life)); //a

        Debug.Log(string.Format("det finns {0} demons", demoner));

        Debug.Log(string.Format("om du skadar {0} som är ditt maxdamage behövs det {1} slag att döda en demon slagaadar {2} som är din mindamage kommer det ta {3} slag för att döda demonen. Om du skadar skadar {4} som genomsnitt kommer det ta {5} slag", maxDamage, (life / maxDamage), minDamage, (life / minDamage), (minDamage + maxDamage / 2), (life  + maxDamage / 2)));












             

            

            
    }
   
    // Update is called once per frame
    void Update()
    {
          
    }
}
