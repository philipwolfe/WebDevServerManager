using System;
using System.Collections.Specialized;

namespace WebDevServerManager
{
	[Serializable()]
	public class Arguments : StringDictionary
	{
		public Arguments(string[] args)
		{
			foreach (string s in args)
			{
				string[] val = s.Split(':');
				string key = val[0].Trim().Replace("/", "");

				if (string.IsNullOrEmpty(val[1]))
					break;

				if (val.Length > 2)
					val[1] = String.Join(":", val, 1, val.Length - 1);

				string value = val[1].Trim().Replace(@"""", "");

				Add(key, value);
			}
		}

		public bool NeedHelp()
		{
			return !String.IsNullOrEmpty(this["?"]);
		}

		public bool SomePassed()
		{
			return !String.IsNullOrEmpty(this["path"]) && !String.IsNullOrEmpty(this["port"]);
		}

	}
}
