using System.Collections; 

using System.Collections.Generic; 

using UnityEngine; 

using UnityEngine.SceneManagement; 

 
 

public class MainMenu : MonoBehaviour 

{ 
public GameObject PlayButton;

public GameObject ExitButton;

public GameObject BackMenuButton;

public GameObject CreditsButton;
    

public void Play() 

{ 

   /*  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);  */
    SceneManager.LoadScene("Game"); 

} 

public void Back() 

{ 

   /*  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);  */
    SceneManager.LoadScene("MainMenu"); 

} 

public void Credits() 

{ 

   /*  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);  */
    SceneManager.LoadScene("Credits"); 

} 

 
 

public void Quit() 

{ 

    Application.Quit(); 

    Debug.Log("Player Has Quit The Game"); 

} 

} 