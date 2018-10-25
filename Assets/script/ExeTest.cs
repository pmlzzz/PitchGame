using UnityEngine;
using System.Collections;
using System.Diagnostics;

public class ExeTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Process myprocess = new Process();
        ProcessStartInfo startInfo = new ProcessStartInfo("test.exe", "Start");
        myprocess.StartInfo = startInfo;
        myprocess.StartInfo.UseShellExecute = false;
        myprocess.Start();
        //Process.Start("test.exe");
    }
	
	
}
