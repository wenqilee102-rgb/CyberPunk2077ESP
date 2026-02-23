using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BasicDistractionDevice : InteractiveDevice
	{
		private CHandle<AnimFeature_DistractionState> _animFeatureDataDistractor;
		private CName _animFeatureDataNameDistractor;
		private CArray<CName> _distractionComponentSwapNamesToON;
		private CArray<CName> _distractionComponentSwapNamesToOFF;
		private CArray<CHandle<entIPlacedComponent>> _distractionComponentON;
		private CArray<CHandle<entIPlacedComponent>> _distractionComponentOFF;
		private CName _meshAppearanceNameON;
		private CName _meshAppearanceNameOFF;

		[Ordinal(98)] 
		[RED("animFeatureDataDistractor")] 
		public CHandle<AnimFeature_DistractionState> AnimFeatureDataDistractor
		{
			get => GetProperty(ref _animFeatureDataDistractor);
			set => SetProperty(ref _animFeatureDataDistractor, value);
		}

		[Ordinal(99)] 
		[RED("animFeatureDataNameDistractor")] 
		public CName AnimFeatureDataNameDistractor
		{
			get => GetProperty(ref _animFeatureDataNameDistractor);
			set => SetProperty(ref _animFeatureDataNameDistractor, value);
		}

		[Ordinal(100)] 
		[RED("distractionComponentSwapNamesToON")] 
		public CArray<CName> DistractionComponentSwapNamesToON
		{
			get => GetProperty(ref _distractionComponentSwapNamesToON);
			set => SetProperty(ref _distractionComponentSwapNamesToON, value);
		}

		[Ordinal(101)] 
		[RED("distractionComponentSwapNamesToOFF")] 
		public CArray<CName> DistractionComponentSwapNamesToOFF
		{
			get => GetProperty(ref _distractionComponentSwapNamesToOFF);
			set => SetProperty(ref _distractionComponentSwapNamesToOFF, value);
		}

		[Ordinal(102)] 
		[RED("distractionComponentON")] 
		public CArray<CHandle<entIPlacedComponent>> DistractionComponentON
		{
			get => GetProperty(ref _distractionComponentON);
			set => SetProperty(ref _distractionComponentON, value);
		}

		[Ordinal(103)] 
		[RED("distractionComponentOFF")] 
		public CArray<CHandle<entIPlacedComponent>> DistractionComponentOFF
		{
			get => GetProperty(ref _distractionComponentOFF);
			set => SetProperty(ref _distractionComponentOFF, value);
		}

		[Ordinal(104)] 
		[RED("meshAppearanceNameON")] 
		public CName MeshAppearanceNameON
		{
			get => GetProperty(ref _meshAppearanceNameON);
			set => SetProperty(ref _meshAppearanceNameON, value);
		}

		[Ordinal(105)] 
		[RED("meshAppearanceNameOFF")] 
		public CName MeshAppearanceNameOFF
		{
			get => GetProperty(ref _meshAppearanceNameOFF);
			set => SetProperty(ref _meshAppearanceNameOFF, value);
		}

		public BasicDistractionDevice(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
