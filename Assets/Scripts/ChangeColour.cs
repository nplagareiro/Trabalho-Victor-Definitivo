using System.Collections; 

using System.Collections.Generic; 

using UnityEngine; 

  

public class ChangeColor : MonoBehaviour 

{ 

    public float timer = 6f; 

    public Material groundMaterial; 

  

    private void Update() 

    { 

        timer -= Time.deltaTime; 

        if (timer < 0) 

        { 

            colorGenerator(); 

            timer = 6f; 

        } 

    } 

  

    private void colorGenerator() 

    { 

        int index = Random.Range(0, 4); 

  

        switch (index) 

        { 

            case 0: 

                groundMaterial.color = Color.red; 

                break; 

  

            case 1: 

                groundMaterial.color = Color.green; 

                break; 

  

            case 2: 

                groundMaterial.color = Color.blue; 

                break; 

  

            case 3: 

                groundMaterial.color = Color.yellow; 

                break; 

        } 

    } 

} 

 