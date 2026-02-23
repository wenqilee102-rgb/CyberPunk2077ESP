using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_Carry : animAnimFeature
	{
		private CInt32 _state;
		private CInt32 _pickupAnimation;
		private CBool _useBothHands;
		private CBool _instant;
		private CBool _fastMode;
		private CBool _isCarryActive;
		private CBool _isFriendlyCarry;
		private CBool _wasThrown;

		[Ordinal(0)] 
		[RED("state")] 
		public CInt32 State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(1)] 
		[RED("pickupAnimation")] 
		public CInt32 PickupAnimation
		{
			get => GetProperty(ref _pickupAnimation);
			set => SetProperty(ref _pickupAnimation, value);
		}

		[Ordinal(2)] 
		[RED("useBothHands")] 
		public CBool UseBothHands
		{
			get => GetProperty(ref _useBothHands);
			set => SetProperty(ref _useBothHands, value);
		}

		[Ordinal(3)] 
		[RED("instant")] 
		public CBool Instant
		{
			get => GetProperty(ref _instant);
			set => SetProperty(ref _instant, value);
		}

		[Ordinal(4)] 
		[RED("fastMode")] 
		public CBool FastMode
		{
			get => GetProperty(ref _fastMode);
			set => SetProperty(ref _fastMode, value);
		}

		[Ordinal(5)] 
		[RED("isCarryActive")] 
		public CBool IsCarryActive
		{
			get => GetProperty(ref _isCarryActive);
			set => SetProperty(ref _isCarryActive, value);
		}

		[Ordinal(6)] 
		[RED("isFriendlyCarry")] 
		public CBool IsFriendlyCarry
		{
			get => GetProperty(ref _isFriendlyCarry);
			set => SetProperty(ref _isFriendlyCarry, value);
		}

		[Ordinal(7)] 
		[RED("wasThrown")] 
		public CBool WasThrown
		{
			get => GetProperty(ref _wasThrown);
			set => SetProperty(ref _wasThrown, value);
		}

		public AnimFeature_Carry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
