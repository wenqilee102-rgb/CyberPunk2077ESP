using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TV : InteractiveDevice
	{
		private CBool _isShortGlitchActive;
		private gameDelayID _shortGlitchDelayID;
		private CBool _isTVMoving;

		[Ordinal(98)] 
		[RED("isShortGlitchActive")] 
		public CBool IsShortGlitchActive
		{
			get => GetProperty(ref _isShortGlitchActive);
			set => SetProperty(ref _isShortGlitchActive, value);
		}

		[Ordinal(99)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get => GetProperty(ref _shortGlitchDelayID);
			set => SetProperty(ref _shortGlitchDelayID, value);
		}

		[Ordinal(100)] 
		[RED("isTVMoving")] 
		public CBool IsTVMoving
		{
			get => GetProperty(ref _isTVMoving);
			set => SetProperty(ref _isTVMoving, value);
		}

		public TV(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
