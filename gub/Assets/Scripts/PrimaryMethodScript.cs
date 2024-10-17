using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimaryMethodScript : MonoBehaviour
{
    public int currentAge = 23;
    public int ageIncreasePerYear = 1;
    public int currentYear = (2024);
    public int delta;
    bool isTall = true; // or: false
    string Name = "Gustav";
    string Surname = "Haugesen";
    public int a = 512;
    public int b = 731;
   



    // Start is called before the first frame update
    void Start()
    {
        /*int c = a;
        a = b;
        b = c;
        Debug.Log(a);
        Debug.Log(b);*/  
        

        Debug.LogFormat("Initial Values are: a={0}, b={1}", a, b);
        int c = a;
        a = b;
        b = c;
        Debug.LogFormat("Secondary Values are: a={0}, b={1}", a, b);

        int d0 = 10;
        int d1 = 20;

        float f1 = 15;
        float f2 = 25;

        int y1 = 0;
        int y2 = 0;

        (a, b) = Swap(a, b);
        Debug.LogFormat("Swapped values with Swap Method are: a={0}, b={1}", a, b);

        (d0, d1) = Swap(d0, d1);
        Debug.LogFormat("Swapped values with Swap Method are: d0={0}, d1={1}", d0, d1);

        (int m1, int m2) = Swap(1, 7);
        Debug.LogFormat("Swapped 7 1 values with Swap Method are: {0}, {1}", m1, m2);

        (f1, f2) = FloatSwap(f1, f2);
        Debug.LogFormat("Swapped values with FloatSwap function are f1={0}, f2={1}", f1, f2);


        (int p, int o) = AgeIncreaseNextYear(currentAge, 2025);
        Debug.LogFormat("Current age, and age next year {0}, in the year {1}", p, o);

        (y1, y2) = AgeIncreaseInXYears(y1, y2);
        Debug.LogFormat("In year {1}, I will be {0} years old", y1, y2);


    }

    /// <summary>
    /// Swaps the value of two integers, by using a temporary integer
    /// </summary>
    (int, int) Swap(int m, int n)
        {
        /*
            int temp = m;
            m = n;
            n = temp;
        */
            return (n, m);
        }

        
        /// <summary>
        /// Swaps the value of two float, by using a temporary float
        /// </summary>
        (float, float) FloatSwap(float k, float l)
        {
        /*
            float temp = k;
            k = l;
            l = temp;
        */
            return (l, k);
        }

    /// <summary>
    /// Calculates my age next year
    /// </summary>
    (int, int) AgeIncreaseNextYear(int y1, int y2)
    {
        y1 = currentAge;
        y2 = ageIncreasePerYear;
        int ageNextYear = (y1 + y2);
        int nextYear = currentYear + 1;

        return (ageNextYear, nextYear);

    }

    /// <summary>
    /// Calculates age in 'delta' amount of years
    /// </summary>
    (int, int) AgeIncreaseInXYears(int y1, int y2)
    {

        int newAge = (currentAge + delta);
        int newYear = (currentYear + delta);

        y1 = newAge;
        y2 = newYear;
        return (y1, y2);

    }






    // Update is called once per frame
    void Update()
    {

    }
}
