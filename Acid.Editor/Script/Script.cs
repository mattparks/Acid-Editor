/*using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;

namespace AcidEditor.Script
{
	public class Script
	{
		private Script<object> _script;

		public Script(string sourceCode) 
		{
			ScriptOptions options = ScriptOptions.Default
				.AddReferences(
					Assembly.GetAssembly(typeof(System.Dynamic.DynamicObject)), // System.Code
					Assembly.GetAssembly(typeof(Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo)), // Microsoft.CSharp
					Assembly.GetAssembly(typeof(System.Dynamic.ExpandoObject)));  // System.Dynamic
			_script = CSharpScript.Create(sourceCode, options);
			// TODO: Allow a component manager to get IComponent type of class and use it.
		}
	}
}*/
