using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NumberWizard : MonoBehaviour
{
    int min;
    int max;
    int guess;

    void NextGuess()
    {
        guess = (min + max) / 2;  
        Debug.Log("Czy Twoja liczba jest mniejsza lub większa od " + guess + " ?");
                     
    }

    void StartGame()
    {
        min = 1;
        max = 1000;
        guess = (min + max) / 2;
        Debug.Log("Welcome to Number Wizard!!!");
        print("Pick a number between " + min + " do " + max);
        Debug.Log("Let me know if your number is greater or smaller than " + guess);
        print("Arrow Up means your number is higher, Arrow Down - lower. If I guessed, push Enter");
        max++;
    }

    void Start()
    {
        StartGame();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I won. I always do.");
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }

        // poprawic buga z wybieraniem liczby 1000 //////// zrobione
        // sprobowac samodzielnie zamienic kolory komunikatow w konsoli 
        // dac uzytkownikowi mozliwosc w wybraniu przedzialu liczb (min i max)
        // Od razu po zakonczeniu jednej rozgrywki chcielibysmy restartowac nasza gre i uruchamiac ja na nowo (SceneManagement)
    }
}

