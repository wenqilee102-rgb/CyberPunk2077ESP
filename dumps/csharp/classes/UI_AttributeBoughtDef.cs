using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_AttributeBoughtDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _attribute;

		[Ordinal(0)] 
		[RED("attribute")] 
		public gamebbScriptID_Variant Attribute
		{
			get => GetProperty(ref _attribute);
			set => SetProperty(ref _attribute, value);
		}

		public UI_AttributeBoughtDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
