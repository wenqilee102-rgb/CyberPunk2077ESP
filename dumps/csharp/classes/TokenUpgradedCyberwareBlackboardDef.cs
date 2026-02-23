using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TokenUpgradedCyberwareBlackboardDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _cyberwareTypes;

		[Ordinal(0)] 
		[RED("CyberwareTypes")] 
		public gamebbScriptID_Variant CyberwareTypes
		{
			get => GetProperty(ref _cyberwareTypes);
			set => SetProperty(ref _cyberwareTypes, value);
		}

		public TokenUpgradedCyberwareBlackboardDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
