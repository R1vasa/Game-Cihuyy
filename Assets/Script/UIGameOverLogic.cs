using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   public void Retrybutton(){
        SceneManager.LoadScene("Retry");
    }
    public void ExitbutTon(){
        SceneManager.LoadScene("Exit");
    }
}
