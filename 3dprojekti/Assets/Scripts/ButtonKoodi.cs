using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonKoodi : MonoBehaviour
{
    public void Aloitus()
    {
        SceneManager.LoadScene("Peli");
    }
}
