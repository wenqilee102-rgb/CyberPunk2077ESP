using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleGridDestructionEvent : redEvent
	{
		private CArrayFixedSize<CFloat> _state;
		private CArrayFixedSize<CFloat> _rawChange;
		private CArrayFixedSize<CFloat> _desiredChange;
		private CFloat _damageMultiplier;
		private Vector3 _impactPoint;
		private wCHandle<gameObject> _otherVehicle;
		private CBool _rammedOtherVehicle;
		private CBool _otherVehicleRammed;

		[Ordinal(0)] 
		[RED("state", 16)] 
		public CArrayFixedSize<CFloat> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(1)] 
		[RED("rawChange", 16)] 
		public CArrayFixedSize<CFloat> RawChange
		{
			get => GetProperty(ref _rawChange);
			set => SetProperty(ref _rawChange, value);
		}

		[Ordinal(2)] 
		[RED("desiredChange", 16)] 
		public CArrayFixedSize<CFloat> DesiredChange
		{
			get => GetProperty(ref _desiredChange);
			set => SetProperty(ref _desiredChange, value);
		}

		[Ordinal(3)] 
		[RED("damageMultiplier")] 
		public CFloat DamageMultiplier
		{
			get => GetProperty(ref _damageMultiplier);
			set => SetProperty(ref _damageMultiplier, value);
		}

		[Ordinal(4)] 
		[RED("impactPoint")] 
		public Vector3 ImpactPoint
		{
			get => GetProperty(ref _impactPoint);
			set => SetProperty(ref _impactPoint, value);
		}

		[Ordinal(5)] 
		[RED("otherVehicle")] 
		public wCHandle<gameObject> OtherVehicle
		{
			get => GetProperty(ref _otherVehicle);
			set => SetProperty(ref _otherVehicle, value);
		}

		[Ordinal(6)] 
		[RED("rammedOtherVehicle")] 
		public CBool RammedOtherVehicle
		{
			get => GetProperty(ref _rammedOtherVehicle);
			set => SetProperty(ref _rammedOtherVehicle, value);
		}

		[Ordinal(7)] 
		[RED("otherVehicleRammed")] 
		public CBool OtherVehicleRammed
		{
			get => GetProperty(ref _otherVehicleRammed);
			set => SetProperty(ref _otherVehicleRammed, value);
		}

		public vehicleGridDestructionEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
