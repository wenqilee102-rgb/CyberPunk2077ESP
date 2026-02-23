using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemappinsPointOfInterestMappinData : gamemappinsIMappinData
	{
		private CHandle<gamemappinsIPointOfInterestVariant> _typedVariant;
		private CBool _active;
		private CName _slotName;
		private Vector3 _slotOffset;
		private CFloat _dynamicMappinRadius;
		private TweakDBID _staticMappinDef;
		private TweakDBID _dynamicMappinDef;

		[Ordinal(0)] 
		[RED("typedVariant")] 
		public CHandle<gamemappinsIPointOfInterestVariant> TypedVariant
		{
			get => GetProperty(ref _typedVariant);
			set => SetProperty(ref _typedVariant, value);
		}

		[Ordinal(1)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetProperty(ref _active);
			set => SetProperty(ref _active, value);
		}

		[Ordinal(2)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(3)] 
		[RED("slotOffset")] 
		public Vector3 SlotOffset
		{
			get => GetProperty(ref _slotOffset);
			set => SetProperty(ref _slotOffset, value);
		}

		[Ordinal(4)] 
		[RED("dynamicMappinRadius")] 
		public CFloat DynamicMappinRadius
		{
			get => GetProperty(ref _dynamicMappinRadius);
			set => SetProperty(ref _dynamicMappinRadius, value);
		}

		[Ordinal(5)] 
		[RED("staticMappinDef")] 
		public TweakDBID StaticMappinDef
		{
			get => GetProperty(ref _staticMappinDef);
			set => SetProperty(ref _staticMappinDef, value);
		}

		[Ordinal(6)] 
		[RED("dynamicMappinDef")] 
		public TweakDBID DynamicMappinDef
		{
			get => GetProperty(ref _dynamicMappinDef);
			set => SetProperty(ref _dynamicMappinDef, value);
		}

		public gamemappinsPointOfInterestMappinData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
