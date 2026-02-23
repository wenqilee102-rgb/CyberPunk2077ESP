using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipperdocMeterCapacityApplyEvent : redEvent
	{
		private CInt32 _currentCapacity;
		private CInt32 _maxCapacity;
		private CInt32 _overchargeCapacity;
		private CFloat _maxCapacityPossible;
		private CBool _isPurchase;

		[Ordinal(0)] 
		[RED("CurrentCapacity")] 
		public CInt32 CurrentCapacity
		{
			get => GetProperty(ref _currentCapacity);
			set => SetProperty(ref _currentCapacity, value);
		}

		[Ordinal(1)] 
		[RED("MaxCapacity")] 
		public CInt32 MaxCapacity
		{
			get => GetProperty(ref _maxCapacity);
			set => SetProperty(ref _maxCapacity, value);
		}

		[Ordinal(2)] 
		[RED("OverchargeCapacity")] 
		public CInt32 OverchargeCapacity
		{
			get => GetProperty(ref _overchargeCapacity);
			set => SetProperty(ref _overchargeCapacity, value);
		}

		[Ordinal(3)] 
		[RED("MaxCapacityPossible")] 
		public CFloat MaxCapacityPossible
		{
			get => GetProperty(ref _maxCapacityPossible);
			set => SetProperty(ref _maxCapacityPossible, value);
		}

		[Ordinal(4)] 
		[RED("IsPurchase")] 
		public CBool IsPurchase
		{
			get => GetProperty(ref _isPurchase);
			set => SetProperty(ref _isPurchase, value);
		}

		public RipperdocMeterCapacityApplyEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
