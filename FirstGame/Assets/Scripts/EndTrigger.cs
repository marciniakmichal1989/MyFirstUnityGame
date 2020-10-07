
using UnityEngine;

public class EndTrigger : MonoBehaviour{

    public GameManager gameMenager;

    void OnTriggerEnter(){

        gameMenager.CompleteLevel();
    }

}
