    IEnumerator RequestWebService()
    {
        string getDataUrl = "http://geoplugin.net/json.gp?ip=157.37.222.199";
        print(getDataUrl);
        
        UnityWebRequest webData = UnityWebRequest.Get(getDataUrl);
        
        yield return webData.SendWebRequest();
        JSONNode jsonData = JSON.Parse(System.Text.Encoding.UTF8.GetString(webData.downloadHandler.data));
        print("---------------- JSON DATA ----------------");
        print("jsonData.Count:" + jsonData.Count);
        print(jsonData["geoplugin_countryName"]);
       // continentTxt.text = jsonData["geoplugin_continentName"];
        
}
