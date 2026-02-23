using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PoliceChaseParamsDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Float _searchAreaRadius;
		private gamebbScriptID_Float _chasePlayerDistance;

		[Ordinal(0)] 
		[RED("SearchAreaRadius")] 
		public gamebbScriptID_Float SearchAreaRadius
		{
			get => GetProperty(ref _searchAreaRadius);
			set => SetProperty(ref _searchAreaRadius, value);
		}

		[Ordinal(1)] 
		[RED("ChasePlayerDistance")] 
		public gamebbScriptID_Float ChasePlayerDistance
		{
			get => GetProperty(ref _chasePlayerDistance);
			set => SetProperty(ref _chasePlayerDistance, value);
		}

		public PoliceChaseParamsDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
