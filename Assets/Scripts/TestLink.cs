using UnityEngine;
using System.Runtime.InteropServices;
using System.Collections;
using UnityEngine.UI;

public class TestLink : MonoBehaviour {

    
    public void OpenLinkJSPlugin()
    {
#if !UNITY_EDITOR
            openWindow("http://chirongames.se");
#endif
    }

    [DllImport("__Internal")]
    private static extern void openWindow(string url);
}
