using System;
using UnityEditor;
using UnityEngine;

public class CustomCube : EditorWindow
{
    public Color myColor;
    public MeshRenderer GO;

    public Material newMat;
    private Transform MainCam;

    [MenuItem("Инструменты / Окна / Генератор префабов")]

    public static void ShowMyWindow()
    {
        GetWindow(typeof(CustomCube), false, "Генератор префабов");
    }

    private void OnGUI() 
    {

        GO = EditorGUILayout.ObjectField("Меш Объекта", GO, typeof(MeshRenderer), true) as MeshRenderer;
        newMat = EditorGUILayout.ObjectField("Материал Объекта", newMat, typeof(Material), true) as Material;

        if (GO)
        {
            myColor = RGBSlider(new Rect(10, 50, 200, 20), myColor);
            GO.sharedMaterial.color = myColor;
        }
        else
        {
            if(GUI.Button(new Rect(10, 60, 100, 30), "Создать"))
            {
                MainCam = Camera.main.transform;

                GameObject temp = GameObject.CreatePrimitive(PrimitiveType.Cube);
                MeshRenderer GORenderer = temp.GetComponent<MeshRenderer>();
                GORenderer.sharedMaterial = newMat;
                temp.transform.position = new Vector3(MainCam.position.x, MainCam.position.y, MainCam.position.z - 10f);
                GO = GORenderer;
            }
        }

        if (GUI.Button(new Rect(10, 160, 100, 30), "Удалить"))
        {
            DestroyImmediate(GO.gameObject);
            GO = null;
        }

    }

    float LabelSlider(Rect screenRect, float sliderValue, float sliderMaxValue, string labelText)
    {
        Rect labelRect = new Rect(screenRect.x, screenRect.y, screenRect.width / 2, screenRect.height);

        GUI.Label(labelRect, labelText);

        Rect sliderRect = new Rect(screenRect.x + screenRect.width / 2, screenRect.y, screenRect.width / 2, screenRect.height);
        sliderValue = GUI.HorizontalSlider(sliderRect, sliderValue, 0.0f, sliderMaxValue);
        return sliderValue;
    }

    Color RGBSlider(Rect screenRect, Color rgb)
    {

        if (GUI.Button(new Rect(10, 200, 160, 30), "Минимальное значение"))
        {

        }

        rgb.r = LabelSlider(screenRect, rgb.r, 1.0f, "Red");

        screenRect.y += 20;
        rgb.g = LabelSlider(screenRect, rgb.g, 1.0f, "Green");
        screenRect.y += 20;
        rgb.b = LabelSlider(screenRect, rgb.b, 1.0f, "Blue");
        screenRect.y += 20;
        rgb.a = LabelSlider(screenRect, rgb.a, 1.0f, "Alpha");

        return rgb;
    }
}

