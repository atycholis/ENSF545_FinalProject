using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Text displayResults;
    //public UserObject testObj;
    public float finalTime;

    public void EndScene()
    {
        Debug.Log("End");
        Application.Quit();
    }
}
