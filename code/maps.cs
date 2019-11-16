IReadOnlyDictionary&lt;string,string> occupations = 
                        new Dictionary&lt;string, string>
{
    ["Malcolm"] = "Captain",
    ["Kaylee"] = "Mechanic"
};

var occupationsMutable = new Dictionary&lt;string, string>
{
    ["Malcolm"] = "Captain",
    ["Kaylee"] = "Mechanic"
};
occupationsMutable["Jayne"] = "Public Relations";
occupationsMutable.Add("Rick", "Navigation");
