using UnityEngine;
using UnityEngine.SceneManagement;

public class GameReseter : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D other){
        if(!other.gameObject.CompareTag("Ball")) return;
        SceneManager.LoadScene("SampleScene");
    }
}
