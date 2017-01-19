<Query Kind="Program" />

void Main()
{
	string emptyString = "";
	string emptyString2 = string.Empty;
	string nullString = null;
	string spaceString = " "; //THROWS AN EXCEPTION ON IsNullOrEmpty
	
	var listOfStrings = new List<StringExtentionsTest> {
		new StringExtentionsTest { Value = emptyString, Name = "emptyString" },
		new StringExtentionsTest { Value = emptyString2, Name = "emptyString2" },
		new StringExtentionsTest { Value = nullString, Name = "nullString" },
		new StringExtentionsTest { Value = spaceString, Name = "spaceString" }
	};
	
	foreach(var str in listOfStrings)
	{
		if(string.IsNullOrWhiteSpace(str.Value))
		{
			string message = $"{str.Name} is ok on IsNullOrWhiteSpace";
		  	message.Dump();
		} 
		else 
		{
			throw new Exception(str.Name);
		}
	}
	
	foreach(var str in listOfStrings)
	{		
		if(string.IsNullOrEmpty(str.Value))
		{
			string message = $"{str.Name} is ok on IsNullOrEmpty";
		  	message.Dump();
		} 
		else 
		{
			throw new Exception(str.Name);
		}
	}
}

public class StringExtentionsTest
{
	public string Value {get;set;}
	
	public string Name {get;set;}
}

