using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OptionalAreaEffectData : IScriptable
	{
		private CBool _includeInAoeData;
		private CHandle<AreaEffectData> _aoeData;

		[Ordinal(0)] 
		[RED("includeInAoeData")] 
		public CBool IncludeInAoeData
		{
			get => GetProperty(ref _includeInAoeData);
			set => SetProperty(ref _includeInAoeData, value);
		}

		[Ordinal(1)] 
		[RED("aoeData")] 
		public CHandle<AreaEffectData> AoeData
		{
			get => GetProperty(ref _aoeData);
			set => SetProperty(ref _aoeData, value);
		}

		public OptionalAreaEffectData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
