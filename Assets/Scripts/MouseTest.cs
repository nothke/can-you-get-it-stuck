using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using NDraw;

public class MouseTest : MonoBehaviour
{
    bool lmbDown;
    bool lmbUp;

    void Update()
    {
        lmbDown = Input.GetMouseButtonDown(0);
        lmbUp = Input.GetMouseButtonUp(0);

        if (Input.GetMouseButtonDown(0))
            Draw.Screen.FillRect(new Rect(300, 300, 300, 300));

        if (Input.GetMouseButtonUp(0))
            Draw.Screen.FillRect(new Rect(600, 300, 300, 300));

        if (Input.GetMouseButton(0))
            Draw.Screen.FillRect(new Rect(900, 300, 300, 300));
    }

    private void OnGUI()
    {
        GUILayout.BeginArea(new Rect(100, 100, 200, 200));

        if (GUILayout.Button("VSync: " + (QualitySettings.vSyncCount == 0 ? "Off" : "On")))
            QualitySettings.vSyncCount = QualitySettings.vSyncCount == 0 ? 1 : 0;

        GUILayout.Label("LMB down this frame: " + lmbDown);
        GUILayout.Label("LMB up this frame: " + lmbUp);
        GUILayout.Label("LMB pressed: " + Input.GetMouseButton(0));
        GUILayout.EndArea();
    }
}
