using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeShooterTransporterSpawnData : CVariable
	{
		private CEnum<gameuiarcadeShooterAIType> _aiType;
		private CName _parameter;
		private CInt32 _count;

		[Ordinal(0)] 
		[RED("aiType")] 
		public CEnum<gameuiarcadeShooterAIType> AiType
		{
			get => GetProperty(ref _aiType);
			set => SetProperty(ref _aiType, value);
		}

		[Ordinal(1)] 
		[RED("parameter")] 
		public CName Parameter
		{
			get => GetProperty(ref _parameter);
			set => SetProperty(ref _parameter, value);
		}

		[Ordinal(2)] 
		[RED("count")] 
		public CInt32 Count
		{
			get => GetProperty(ref _count);
			set => SetProperty(ref _count, value);
		}

		public gameuiarcadeShooterTransporterSpawnData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
