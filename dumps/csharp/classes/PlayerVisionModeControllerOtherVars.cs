using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerVisionModeControllerOtherVars : CVariable
	{
		private CBool _enabledByToggle;
		private CBool _active;
		private CBool _toggledDuringHold;
		private CFloat _buttonHoldPressTime;
		private CFloat _buttonHoldTapTime;
		private CInt32 _buttonHoldTapCount;

		[Ordinal(0)] 
		[RED("enabledByToggle")] 
		public CBool EnabledByToggle
		{
			get => GetProperty(ref _enabledByToggle);
			set => SetProperty(ref _enabledByToggle, value);
		}

		[Ordinal(1)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetProperty(ref _active);
			set => SetProperty(ref _active, value);
		}

		[Ordinal(2)] 
		[RED("toggledDuringHold")] 
		public CBool ToggledDuringHold
		{
			get => GetProperty(ref _toggledDuringHold);
			set => SetProperty(ref _toggledDuringHold, value);
		}

		[Ordinal(3)] 
		[RED("buttonHoldPressTime")] 
		public CFloat ButtonHoldPressTime
		{
			get => GetProperty(ref _buttonHoldPressTime);
			set => SetProperty(ref _buttonHoldPressTime, value);
		}

		[Ordinal(4)] 
		[RED("buttonHoldTapTime")] 
		public CFloat ButtonHoldTapTime
		{
			get => GetProperty(ref _buttonHoldTapTime);
			set => SetProperty(ref _buttonHoldTapTime, value);
		}

		[Ordinal(5)] 
		[RED("buttonHoldTapCount")] 
		public CInt32 ButtonHoldTapCount
		{
			get => GetProperty(ref _buttonHoldTapCount);
			set => SetProperty(ref _buttonHoldTapCount, value);
		}

		public PlayerVisionModeControllerOtherVars(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
