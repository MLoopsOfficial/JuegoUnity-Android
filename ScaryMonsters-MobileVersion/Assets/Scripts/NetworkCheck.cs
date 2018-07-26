using UnityEngine;
using System.Collections;
using System.Net;
using System;
using System.IO;
using UnityEngine.UI;

public class NetworkCheck : MonoBehaviour {

	public String levelName;
	public Text notificar;

	public string GetHtmlFromUri(string resource){
		string html = string.Empty;
		HttpWebRequest req = (HttpWebRequest)WebRequest.Create(resource);
		try
		{
			using (HttpWebResponse resp = (HttpWebResponse)req.GetResponse())
			{
				bool isSuccess = (int)resp.StatusCode < 299 && (int)resp.StatusCode >= 200;
				if (isSuccess)
				{

					using (TextReader reader = new StreamReader(resp.GetResponseStream()))
					{
						//We are limiting the array to 80 so we don't have
						//to parse the entire html document feel free to 
						//adjust (probably stay under 300)
						char[] cs = new char[80];
						reader.Read(cs, 0, cs.Length);
						foreach(char ch in cs)
						{
							html +=ch;
						}
					}
				}
			}
		}
		catch
		{
			return "";
		}
		return html;
	}
	void Start()
	{
		string HtmlText = GetHtmlFromUri("http://google.com");
		if(HtmlText == "")
		{
			//No connection
			notificar.text = "No se detecta una conexion a Internet";
            Debug.Log("No se detecta una conexion a Internet");
        }
		else if(!HtmlText.Contains("schema.org/WebPage"))
		{
			//Redirecting since the beginning of googles html contains that 
			//phrase and it was not found
		}
		else
		{
			//success
			notificar.text = "Estado de la red Normal"; 
            Debug.Log("Estado de la red Normal");
		}
	}	
}
