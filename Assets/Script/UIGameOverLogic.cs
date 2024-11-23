using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   public void Retrybutton(){
        SceneManager.LoadScene(0);
    }
    public void ExitbutTon(){
        SceneManager.LoadScene("Exit");
    }
}
