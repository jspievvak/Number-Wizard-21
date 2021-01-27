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
        Debug.Log("Witaj w grze Number Wizard");
        print("Wymysl liczbe w glowie z przedzialu od " + min + " do " + max);
        Debug.Log("Komputer bedzie pytal czy twoja liczba jest mniejsza lub wieksza od " + guess + " ?");
        print("Jesli nacisniesz gorna strzalke to liczba jest wieksza, dolna strzalke liczba jest mniejsza, enter to twoja liczba");
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
            Debug.Log("Zwyciezam");
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }

        // poprawic buga z wybieraniem liczby 1000 
        // sprobowac samodzielnie zamienic kolory komunikatow w konsoli 
        // dac uzytkownikowi mozliwosc w wybraniu przedzialu liczb (min i max)
        // Od razu po zakonczeniu jednej rozgrywki chcielibysmy restartowac nasza gre i uruchamiac ja na nowo (SceneManagement)
    }
}

