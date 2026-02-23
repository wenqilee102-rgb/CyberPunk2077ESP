using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleVehicleClearCoatOverrides : CVariable
	{
		private CFloat _opacity;
		private CColor _coatTintFwd;
		private CColor _coatTintSide;
		private CFloat _coatTintFresnelBias;
		private CColor _coatSpecularColor;
		private CFloat _coatFresnelBias;

		[Ordinal(0)] 
		[RED("opacity")] 
		public CFloat Opacity
		{
			get => GetProperty(ref _opacity);
			set => SetProperty(ref _opacity, value);
		}

		[Ordinal(1)] 
		[RED("coatTintFwd")] 
		public CColor CoatTintFwd
		{
			get => GetProperty(ref _coatTintFwd);
			set => SetProperty(ref _coatTintFwd, value);
		}

		[Ordinal(2)] 
		[RED("coatTintSide")] 
		public CColor CoatTintSide
		{
			get => GetProperty(ref _coatTintSide);
			set => SetProperty(ref _coatTintSide, value);
		}

		[Ordinal(3)] 
		[RED("coatTintFresnelBias")] 
		public CFloat CoatTintFresnelBias
		{
			get => GetProperty(ref _coatTintFresnelBias);
			set => SetProperty(ref _coatTintFresnelBias, value);
		}

		[Ordinal(4)] 
		[RED("coatSpecularColor")] 
		public CColor CoatSpecularColor
		{
			get => GetProperty(ref _coatSpecularColor);
			set => SetProperty(ref _coatSpecularColor, value);
		}

		[Ordinal(5)] 
		[RED("coatFresnelBias")] 
		public CFloat CoatFresnelBias
		{
			get => GetProperty(ref _coatFresnelBias);
			set => SetProperty(ref _coatFresnelBias, value);
		}

		public vehicleVehicleClearCoatOverrides(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
