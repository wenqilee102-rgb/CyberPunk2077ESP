using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DodgeEvents : LocomotionGroundEvents
	{
		private CHandle<gameStatModifierData_Deprecated> _blockStatFlag;
		private CHandle<gameStatModifierData_Deprecated> _dashDecelerationModifier;
		private CHandle<gameStatModifierData_Deprecated> _airDashDecelerationModifier;
		private CInt32 _currentNumberOfJumps;
		private CBool _pressureWaveCreated;
		private CBool _crouching;
		private CBool _enteredFromSlide;
		private CBool _isAirDashSaveLockTriggered;

		[Ordinal(6)] 
		[RED("blockStatFlag")] 
		public CHandle<gameStatModifierData_Deprecated> BlockStatFlag
		{
			get => GetProperty(ref _blockStatFlag);
			set => SetProperty(ref _blockStatFlag, value);
		}

		[Ordinal(7)] 
		[RED("dashDecelerationModifier")] 
		public CHandle<gameStatModifierData_Deprecated> DashDecelerationModifier
		{
			get => GetProperty(ref _dashDecelerationModifier);
			set => SetProperty(ref _dashDecelerationModifier, value);
		}

		[Ordinal(8)] 
		[RED("airDashDecelerationModifier")] 
		public CHandle<gameStatModifierData_Deprecated> AirDashDecelerationModifier
		{
			get => GetProperty(ref _airDashDecelerationModifier);
			set => SetProperty(ref _airDashDecelerationModifier, value);
		}

		[Ordinal(9)] 
		[RED("currentNumberOfJumps")] 
		public CInt32 CurrentNumberOfJumps
		{
			get => GetProperty(ref _currentNumberOfJumps);
			set => SetProperty(ref _currentNumberOfJumps, value);
		}

		[Ordinal(10)] 
		[RED("pressureWaveCreated")] 
		public CBool PressureWaveCreated
		{
			get => GetProperty(ref _pressureWaveCreated);
			set => SetProperty(ref _pressureWaveCreated, value);
		}

		[Ordinal(11)] 
		[RED("crouching")] 
		public CBool Crouching
		{
			get => GetProperty(ref _crouching);
			set => SetProperty(ref _crouching, value);
		}

		[Ordinal(12)] 
		[RED("enteredFromSlide")] 
		public CBool EnteredFromSlide
		{
			get => GetProperty(ref _enteredFromSlide);
			set => SetProperty(ref _enteredFromSlide, value);
		}

		[Ordinal(13)] 
		[RED("isAirDashSaveLockTriggered")] 
		public CBool IsAirDashSaveLockTriggered
		{
			get => GetProperty(ref _isAirDashSaveLockTriggered);
			set => SetProperty(ref _isAirDashSaveLockTriggered, value);
		}

		public DodgeEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
