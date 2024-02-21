using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour
{
    public void OnRetryButtonClicked()
    {
        Debug.Log("Retry button clicked. Loading scene: SampleScene");
        SceneManager.LoadScene("Scene2");
    }
}
