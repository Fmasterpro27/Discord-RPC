using UnityEngine;

#if UNITY_STANDALONE_WIN
using System;
using System.Runtime.InteropServices;
#endif

public class AppManager : MonoBehaviour
{
    public void QuitApp()
    {
        Debug.Log("Application is exiting...");
        Application.Quit();
    }

    public void MinimizeApp()
    {
#if UNITY_STANDALONE_WIN
        IntPtr hwnd = GetActiveWindow();
        ShowWindow(hwnd, 2);
#endif
    }

#if UNITY_STANDALONE_WIN
    [DllImport("user32.dll")]
    private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

    [DllImport("user32.dll")]
    private static extern IntPtr GetActiveWindow();
#endif
}