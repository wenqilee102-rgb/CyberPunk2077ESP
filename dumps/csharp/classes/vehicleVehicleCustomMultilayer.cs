using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleVehicleCustomMultilayer : CVariable
	{
		private CArray<CName> _onlyForPlayerVehicleAppearances;
		private CArray<CName> _affectedComponents;
		private CArray<CName> _excludedComponents;
		private redResourceReferenceScriptToken _customMlSetup;
		private redResourceReferenceScriptToken _customMlMask;
		private CFloat _coatLayerMin;
		private CFloat _coatLayerMax;

		[Ordinal(0)] 
		[RED("onlyForPlayerVehicleAppearances")] 
		public CArray<CName> OnlyForPlayerVehicleAppearances
		{
			get => GetProperty(ref _onlyForPlayerVehicleAppearances);
			set => SetProperty(ref _onlyForPlayerVehicleAppearances, value);
		}

		[Ordinal(1)] 
		[RED("affectedComponents")] 
		public CArray<CName> AffectedComponents
		{
			get => GetProperty(ref _affectedComponents);
			set => SetProperty(ref _affectedComponents, value);
		}

		[Ordinal(2)] 
		[RED("excludedComponents")] 
		public CArray<CName> ExcludedComponents
		{
			get => GetProperty(ref _excludedComponents);
			set => SetProperty(ref _excludedComponents, value);
		}

		[Ordinal(3)] 
		[RED("customMlSetup")] 
		public redResourceReferenceScriptToken CustomMlSetup
		{
			get => GetProperty(ref _customMlSetup);
			set => SetProperty(ref _customMlSetup, value);
		}

		[Ordinal(4)] 
		[RED("customMlMask")] 
		public redResourceReferenceScriptToken CustomMlMask
		{
			get => GetProperty(ref _customMlMask);
			set => SetProperty(ref _customMlMask, value);
		}

		[Ordinal(5)] 
		[RED("coatLayerMin")] 
		public CFloat CoatLayerMin
		{
			get => GetProperty(ref _coatLayerMin);
			set => SetProperty(ref _coatLayerMin, value);
		}

		[Ordinal(6)] 
		[RED("coatLayerMax")] 
		public CFloat CoatLayerMax
		{
			get => GetProperty(ref _coatLayerMax);
			set => SetProperty(ref _coatLayerMax, value);
		}

		public vehicleVehicleCustomMultilayer(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
