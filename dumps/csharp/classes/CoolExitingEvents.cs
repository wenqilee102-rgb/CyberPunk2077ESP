using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CoolExitingEvents : ExitingEvents
	{
		private Vector4 _exitMomentum;
		private CEnum<vehicleCoolExitImpulseLevel> _coolExitMagnitude;
		private CBool _willEquipMeleeWeapon;
		private CBool _cwArmsEquipRequested;
		private CBool _cwArmsEquipCompleted;
		private CBool _vehicleInTPP;
		private CHandle<redCallbackObject> _vehicleInTPPCallback;

		[Ordinal(5)] 
		[RED("exitMomentum")] 
		public Vector4 ExitMomentum
		{
			get => GetProperty(ref _exitMomentum);
			set => SetProperty(ref _exitMomentum, value);
		}

		[Ordinal(6)] 
		[RED("coolExitMagnitude")] 
		public CEnum<vehicleCoolExitImpulseLevel> CoolExitMagnitude
		{
			get => GetProperty(ref _coolExitMagnitude);
			set => SetProperty(ref _coolExitMagnitude, value);
		}

		[Ordinal(7)] 
		[RED("willEquipMeleeWeapon")] 
		public CBool WillEquipMeleeWeapon
		{
			get => GetProperty(ref _willEquipMeleeWeapon);
			set => SetProperty(ref _willEquipMeleeWeapon, value);
		}

		[Ordinal(8)] 
		[RED("cwArmsEquipRequested")] 
		public CBool CwArmsEquipRequested
		{
			get => GetProperty(ref _cwArmsEquipRequested);
			set => SetProperty(ref _cwArmsEquipRequested, value);
		}

		[Ordinal(9)] 
		[RED("cwArmsEquipCompleted")] 
		public CBool CwArmsEquipCompleted
		{
			get => GetProperty(ref _cwArmsEquipCompleted);
			set => SetProperty(ref _cwArmsEquipCompleted, value);
		}

		[Ordinal(10)] 
		[RED("vehicleInTPP")] 
		public CBool VehicleInTPP
		{
			get => GetProperty(ref _vehicleInTPP);
			set => SetProperty(ref _vehicleInTPP, value);
		}

		[Ordinal(11)] 
		[RED("vehicleInTPPCallback")] 
		public CHandle<redCallbackObject> VehicleInTPPCallback
		{
			get => GetProperty(ref _vehicleInTPPCallback);
			set => SetProperty(ref _vehicleInTPPCallback, value);
		}

		public CoolExitingEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
