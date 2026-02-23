using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleToggleBrokenTireEvent : redEvent
	{
		private CUInt32 _tireIndex;
		private CBool _toggle;

		[Ordinal(0)] 
		[RED("tireIndex")] 
		public CUInt32 TireIndex
		{
			get => GetProperty(ref _tireIndex);
			set => SetProperty(ref _tireIndex, value);
		}

		[Ordinal(1)] 
		[RED("toggle")] 
		public CBool Toggle
		{
			get => GetProperty(ref _toggle);
			set => SetProperty(ref _toggle, value);
		}

		public vehicleToggleBrokenTireEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
