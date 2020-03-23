using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //typ_zmiennej nazwa;
        //deklaracja
        int a;
        //inicjalizacja
        a = 10;
        //2 w 1
        int b = 20;
        Debug.Log(a);

        {//skakanie
            Debug.Log(b);
		}

        {//chodzenie
            int c = 20;
        
		}
        //Debug.Log(c);

        float fa = 1.5f;
        fa = 20.0f;
        bool logiczna = true;  //false
        string str = "jakiś napis";

        Debug.Log("fa: " + fa + ", logiczna: " + logiczna + ", str: " + str);

        //operacja na zmiennych + - * /
        Debug.Log(a/b);
        Debug.Log(a/fa);
        Debug.Log(Mathf.Sqrt(2));

        //operacje logiczne
        Debug.Log(a == b); //rowne
        Debug.Log(a != b); //rozne
        Debug.Log(a > b);
        Debug.Log(a >= b);
        Debug.Log(a < b);
        Debug.Log(a <= b);

        //if (warunek_logiczny){
        //}

        if(a == b)
        {
            Debug.Log("Tak,, jest różna!");  
		} else if(a < b)
        {
            Debug.Log("a > b");  
		} else
        {
            Debug.Log("żadne z powyższych");
		}

        Debug.Log((a != b) && (a > 0));

        if ((a != b) && (a > 0))
        {
            //kot 
		}

        Koniunkcja(a, b);


        
    }


    public void Koniunkcja(int a, int b)
    {
     //Koniunkcja
     Debug.Log((a != b) && (a > 0));

     if (a > b)
     {
     
	 }
	}

    public void Alternatywa()
    {
        int hp = 2, time = 1;
        bool amulet = true;
        
        if ((hp <= 0) || (time <= 0))
        {
            if (!amulet) //sprawdzamy czy amulet == false
            {
               //kot      
			} else
            {
               //kot      
			}
		}
	}

    
    
    
    
    
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
