using UnityEngine;

public class GUIinterface : MonoBehaviour
{
    private string _message;
    public GUISkin test;
    public Rect buttonRect;
    public Texture2D _icon;

    void OnGUI()
    {
        buttonRect = new Rect(Screen.width / 2 - 100, Screen.height / 2 - 70, 200, 250);

        GUI.skin = test;
        // отрисовка панели с текстом
        GUI.Box(buttonRect, "Бэйн Блэйд");

        // отрисовка кнопок с выводом сообщений
        if (GUI.Button(new Rect(Screen.width / 2 - 90, Screen.height / 2 - 35, 180, 30), "Мощь 11 стволов!"))
        {
            _message = "Мощь 11 стволов!";
        }

        if (GUI.Button(new Rect(Screen.width / 2 - 90, Screen.height / 2 - 0, 180, 30), "Мы справимся!"))
        {
            _message = "Мы справимся!";
        }

        if (GUI.Button(new Rect(Screen.width / 2 - 90, Screen.height / 2 + 35, 180, 30), "Сомнения для смертных!"))
        {
            _message = "Сомнения для смертных!";
        }

        if (GUI.Button(new Rect(Screen.width / 2 - 90, Screen.height / 2 + 140, 180, 30), "За Императора!"))
        {
            _message = "За Императора!";
        }

        GUI.Label(new Rect(220, 10, 100, 100), _message);

        //Угловые панели
        GUI.Box(new Rect(0, 0, 100, 50), "Top-left");
        GUI.Box(new Rect(Screen.width - 100, 0, 100, 50), "Top-right");
        GUI.Box(new Rect(0, Screen.height - 50, 100, 50), "Bottom-left");
        GUI.Box(new Rect(Screen.width - 100, Screen.height - 50, 100, 50), "Bottom-right");
        GUI.Box(new Rect(Screen.width - 100, Screen.height - 130, 100, 25), "Health: 100%");
        GUI.Box(new Rect(Screen.width - 100, Screen.height - 100, 100, 25), "Moral: 100%");

        // Иконка в панели
        GUI.Box(new Rect(10, Screen.height / 2 - 125, 100, 100), _icon);

        // Иконка в панели с текстом
        GUI.Box(new Rect(10, Screen.height / 2, 100, 100), new GUIContent("Ёмаё", _icon));

        // Группа GUI
        GUI.BeginGroup(new Rect(Screen.width / 2 - 25, 10, 100, 100));
        GUI.Label(new Rect(0, 0, 50, 20), "Terra");
        GUI.Label(new Rect(0, 25, 50, 20), "World");
        GUI.EndGroup();

    }

}
