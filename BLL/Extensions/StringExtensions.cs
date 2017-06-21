using System;
using System.Text.RegularExpressions;

namespace Web.TORCHx.Core.BLL
{
	public static class StringExtensions
	{
		//https://stackoverflow.com/questions/5796383/insert-spaces-between-words-on-a-camel-cased-token
		public static string SplitCamelCase(this string str)
		{
			return Regex.Replace(
				Regex.Replace(
					str,
					@"(\P{Ll})(\P{Ll}\p{Ll})",
					"$1 $2"
				),
				@"(\p{Ll})(\P{Ll})",
				"$1 $2"
			);
		}
	}
}
