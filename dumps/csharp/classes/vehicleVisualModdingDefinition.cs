using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleVisualModdingDefinition : CVariable
	{
		private CBool _primaryColorDefined;
		private CFloat _primaryColorH;
		private CFloat _primaryColorS;
		private CFloat _primaryColorB;
		private CBool _secondaryColorDefined;
		private CFloat _secondaryColorH;
		private CFloat _secondaryColorS;
		private CFloat _secondaryColorB;
		private CBool _lightsColorDefined;
		private CFloat _lightsColorH;
		private CInt32 _decoPreset;
		private CName _defaultAppearance;

		[Ordinal(0)] 
		[RED("primaryColorDefined")] 
		public CBool PrimaryColorDefined
		{
			get => GetProperty(ref _primaryColorDefined);
			set => SetProperty(ref _primaryColorDefined, value);
		}

		[Ordinal(1)] 
		[RED("primaryColorH")] 
		public CFloat PrimaryColorH
		{
			get => GetProperty(ref _primaryColorH);
			set => SetProperty(ref _primaryColorH, value);
		}

		[Ordinal(2)] 
		[RED("primaryColorS")] 
		public CFloat PrimaryColorS
		{
			get => GetProperty(ref _primaryColorS);
			set => SetProperty(ref _primaryColorS, value);
		}

		[Ordinal(3)] 
		[RED("primaryColorB")] 
		public CFloat PrimaryColorB
		{
			get => GetProperty(ref _primaryColorB);
			set => SetProperty(ref _primaryColorB, value);
		}

		[Ordinal(4)] 
		[RED("secondaryColorDefined")] 
		public CBool SecondaryColorDefined
		{
			get => GetProperty(ref _secondaryColorDefined);
			set => SetProperty(ref _secondaryColorDefined, value);
		}

		[Ordinal(5)] 
		[RED("secondaryColorH")] 
		public CFloat SecondaryColorH
		{
			get => GetProperty(ref _secondaryColorH);
			set => SetProperty(ref _secondaryColorH, value);
		}

		[Ordinal(6)] 
		[RED("secondaryColorS")] 
		public CFloat SecondaryColorS
		{
			get => GetProperty(ref _secondaryColorS);
			set => SetProperty(ref _secondaryColorS, value);
		}

		[Ordinal(7)] 
		[RED("secondaryColorB")] 
		public CFloat SecondaryColorB
		{
			get => GetProperty(ref _secondaryColorB);
			set => SetProperty(ref _secondaryColorB, value);
		}

		[Ordinal(8)] 
		[RED("lightsColorDefined")] 
		public CBool LightsColorDefined
		{
			get => GetProperty(ref _lightsColorDefined);
			set => SetProperty(ref _lightsColorDefined, value);
		}

		[Ordinal(9)] 
		[RED("lightsColorH")] 
		public CFloat LightsColorH
		{
			get => GetProperty(ref _lightsColorH);
			set => SetProperty(ref _lightsColorH, value);
		}

		[Ordinal(10)] 
		[RED("decoPreset")] 
		public CInt32 DecoPreset
		{
			get => GetProperty(ref _decoPreset);
			set => SetProperty(ref _decoPreset, value);
		}

		[Ordinal(11)] 
		[RED("defaultAppearance")] 
		public CName DefaultAppearance
		{
			get => GetProperty(ref _defaultAppearance);
			set => SetProperty(ref _defaultAppearance, value);
		}

		public vehicleVisualModdingDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
