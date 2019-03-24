using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace XtremeHackerman.Classes
{
    internal class Class_FileManager
    {
	public struct FolderStruct
	{
	    public FolderStruct(string folderName, string parentFolder)
	    {
		Name = folderName;
		Parent = parentFolder;
	    }

	    public string Name { get; set; }
	    public string Parent { get; set; }
	}
	public static IList<FolderStruct> FolderList { get; set; } = JsonConvert.DeserializeObject<IList<FolderStruct>>(File.ReadAllText(""));
    }
}
