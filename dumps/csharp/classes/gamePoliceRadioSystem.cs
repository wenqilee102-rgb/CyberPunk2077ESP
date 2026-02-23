using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePoliceRadioSystem : gameIPoliceRadioSystem
	{
		private CName _lastDistrictEntry;
		private CBool _isHeat1LineRequestOngoing;

		[Ordinal(0)] 
		[RED("lastDistrictEntry")] 
		public CName LastDistrictEntry
		{
			get => GetProperty(ref _lastDistrictEntry);
			set => SetProperty(ref _lastDistrictEntry, value);
		}

		[Ordinal(1)] 
		[RED("isHeat1LineRequestOngoing")] 
		public CBool IsHeat1LineRequestOngoing
		{
			get => GetProperty(ref _isHeat1LineRequestOngoing);
			set => SetProperty(ref _isHeat1LineRequestOngoing, value);
		}

		public gamePoliceRadioSystem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
