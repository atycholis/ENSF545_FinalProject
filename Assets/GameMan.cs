using UnityEngine;
using UnityEngine.UI;

public class GameM : MonoBehaviour
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
