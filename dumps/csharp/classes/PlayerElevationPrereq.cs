using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerElevationPrereq : gameIScriptablePrereq
	{
		private CFloat _elevationThreshold;

		[Ordinal(0)] 
		[RED("elevationThreshold")] 
		public CFloat ElevationThreshold
		{
			get => GetProperty(ref _elevationThreshold);
			set => SetProperty(ref _elevationThreshold, value);
		}

		public PlayerElevationPrereq(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
