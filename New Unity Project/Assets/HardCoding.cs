using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardCoding : MonoBehaviour
{
    public int liczbaCalkowita;
    private int integerVariable;
    public float x;
    public bool trueVariable;
    public bool falseVariable;
    public string s1;
    public string s2;
    // Start is called before the first frame update
    void Start()
    {
        liczbaCalkowita = 5;
        x = 5.5f;
        trueVariable = true;
        falseVariable = false;
        s1 = "Programuje w C#";
        s2 = "EPG";

        //4
        Debug.Log(liczbaCalkowita);
        Debug.Log(liczbaCalkowita + " " + x);
        Debug.Log(liczbaCalkowita + x);
        Debug.Log(s1 + " " + s2);

        //5
        if (liczbaCalkowita == x)
        {
            Debug.Log("Tak, rowne");
        }
        else
        {
            Debug.Log("Nie, nierowne");
        }
        if (liczbaCalkowita != x)
        {
            Debug.Log("Tak, rozne");
        }else
        {
            Debug.Log("Nie, nierozne");
        }
        if (liczbaCalkowita > x)
        {
            Debug.Log("Tak, wieksze");
        }
        else
        {
            Debug.Log("Nie, niewieksze");
        }
        if (liczbaCalkowita < x)
        {
            Debug.Log("Tak, mniejsza");
        }
        else
        {
            Debug.Log("Nie, nie mniejsza");
        }
        if (liczbaCalkowita >= x)
        {
            Debug.Log("Tak, wieksza i rowne");
        }
        else
        {
            Debug.Log("Nie, nie wieksza i nie rowne");
        }
        if (liczbaCalkowita <= x)
        {
            Debug.Log("Tak, mniejsze i rowne");
        }
        else
        {
            Debug.Log("Nie, nie mniejsze  i nie rowne");
        }
        //6
        if (!s1.Equals(s2))
        {
            Debug.Log("rozne");
        }
        else
        {
            Debug.Log("rowne");
        }
        s1 = "EPG";
        if (s1.StartsWith("EP"))
        {
            Debug.Log("tak,zaczzyna sie od EP");
        }
        //7
        if(trueVariable && falseVariable){

            Debug.Log("Prawda");
        }
        else
        {
            Debug.Log("Falsz");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Zadanie1()
    {
        //Zadanie 1
        integerVariable = 5;
        
    }
}
