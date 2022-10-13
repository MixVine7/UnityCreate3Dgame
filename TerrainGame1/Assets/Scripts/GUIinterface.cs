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
        // ��������� ������ � �������
        GUI.Box(buttonRect, "���� �����");

        // ��������� ������ � ������� ���������
        if (GUI.Button(new Rect(Screen.width / 2 - 90, Screen.height / 2 - 35, 180, 30), "���� 11 �������!"))
        {
            _message = "���� 11 �������!";
        }

        if (GUI.Button(new Rect(Screen.width / 2 - 90, Screen.height / 2 - 0, 180, 30), "�� ���������!"))
        {
            _message = "�� ���������!";
        }

        if (GUI.Button(new Rect(Screen.width / 2 - 90, Screen.height / 2 + 35, 180, 30), "�������� ��� ��������!"))
        {
            _message = "�������� ��� ��������!";
        }

        if (GUI.Button(new Rect(Screen.width / 2 - 90, Screen.height / 2 + 140, 180, 30), "�� ����������!"))
        {
            _message = "�� ����������!";
        }

        GUI.Label(new Rect(220, 10, 100, 100), _message);

        //������� ������
        GUI.Box(new Rect(0, 0, 100, 50), "Top-left");
        GUI.Box(new Rect(Screen.width - 100, 0, 100, 50), "Top-right");
        GUI.Box(new Rect(0, Screen.height - 50, 100, 50), "Bottom-left");
        GUI.Box(new Rect(Screen.width - 100, Screen.height - 50, 100, 50), "Bottom-right");
        GUI.Box(new Rect(Screen.width - 100, Screen.height - 130, 100, 25), "Health: 100%");
        GUI.Box(new Rect(Screen.width - 100, Screen.height - 100, 100, 25), "Moral: 100%");

        // ������ � ������
        GUI.Box(new Rect(10, Screen.height / 2 - 125, 100, 100), _icon);

        // ������ � ������ � �������
        GUI.Box(new Rect(10, Screen.height / 2, 100, 100), new GUIContent("���", _icon));

        // ������ GUI
        GUI.BeginGroup(new Rect(Screen.width / 2 - 25, 10, 100, 100));
        GUI.Label(new Rect(0, 0, 50, 20), "Terra");
        GUI.Label(new Rect(0, 25, 50, 20), "World");
        GUI.EndGroup();

    }

}
