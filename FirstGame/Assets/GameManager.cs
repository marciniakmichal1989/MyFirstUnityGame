using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour{

    bool gameHasEnded = false;
    public float restartDeley = 1f;

    public GameObject completeLevelUI;

    public void CompleteLevel(){
        completeLevelUI.SetActive(true);
    }

    public void EndGame(){
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDeley);
        }
        
    }

    void Restart(){
        //SceneManager.LoadScene("Level01");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
