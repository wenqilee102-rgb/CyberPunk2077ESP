using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShouldExitVehicle : AIVehicleConditionAbstract
	{
		private wCHandle<gameIBlackboard> _bb;
		private CHandle<gamemountingIMountingFacility> _mf;
		private CBool _initialized;

		[Ordinal(0)] 
		[RED("bb")] 
		public wCHandle<gameIBlackboard> Bb
		{
			get => GetProperty(ref _bb);
			set => SetProperty(ref _bb, value);
		}

		[Ordinal(1)] 
		[RED("mf")] 
		public CHandle<gamemountingIMountingFacility> Mf
		{
			get => GetProperty(ref _mf);
			set => SetProperty(ref _mf, value);
		}

		[Ordinal(2)] 
		[RED("initialized")] 
		public CBool Initialized
		{
			get => GetProperty(ref _initialized);
			set => SetProperty(ref _initialized, value);
		}

		public ShouldExitVehicle(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
