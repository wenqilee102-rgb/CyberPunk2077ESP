using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entMechanicalComponentImpactEvent : redEvent
	{
		private wCHandle<entEntity> _otherEntity;
		private CArray<entImpactPointData> _impactPoints;

		[Ordinal(0)] 
		[RED("otherEntity")] 
		public wCHandle<entEntity> OtherEntity
		{
			get => GetProperty(ref _otherEntity);
			set => SetProperty(ref _otherEntity, value);
		}

		[Ordinal(1)] 
		[RED("impactPoints")] 
		public CArray<entImpactPointData> ImpactPoints
		{
			get => GetProperty(ref _impactPoints);
			set => SetProperty(ref _impactPoints, value);
		}

		public entMechanicalComponentImpactEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
