using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MudarCena : MonoBehaviour {
  

    public  void CarregarCena(string cena)
    {
        SceneManager.LoadScene(cena);
        
    }

    public void sair()
    {
        Application.Quit();
       
    }

    
}
