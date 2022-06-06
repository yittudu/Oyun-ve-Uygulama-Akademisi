using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class ChangeScene : MonoBehaviour
{
    public void MoveToScene(int sceneID)
{

SceneManager.LoadScene(sceneID);

}

public void Quit()
{
    Application.Quit();
}








}
