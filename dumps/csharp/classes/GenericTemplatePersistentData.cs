using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GenericTemplatePersistentData : CVariable
	{
		private CBool _primaryColorDefined;
		private CUInt8 _primaryColorR;
		private CUInt8 _primaryColorG;
		private CUInt8 _primaryColorB;
		private CBool _secondaryColorDefined;
		private CUInt8 _secondaryColorR;
		private CUInt8 _secondaryColorG;
		private CUInt8 _secondaryColorB;
		private CBool _lightsColorDefined;
		private CFloat _lightsColorHue;

		[Ordinal(0)] 
		[RED("primaryColorDefined")] 
		public CBool PrimaryColorDefined
		{
			get => GetProperty(ref _primaryColorDefined);
			set => SetProperty(ref _primaryColorDefined, value);
		}

		[Ordinal(1)] 
		[RED("primaryColorR")] 
		public CUInt8 PrimaryColorR
		{
			get => GetProperty(ref _primaryColorR);
			set => SetProperty(ref _primaryColorR, value);
		}

		[Ordinal(2)] 
		[RED("primaryColorG")] 
		public CUInt8 PrimaryColorG
		{
			get => GetProperty(ref _primaryColorG);
			set => SetProperty(ref _primaryColorG, value);
		}

		[Ordinal(3)] 
		[RED("primaryColorB")] 
		public CUInt8 PrimaryColorB
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
		[RED("secondaryColorR")] 
		public CUInt8 SecondaryColorR
		{
			get => GetProperty(ref _secondaryColorR);
			set => SetProperty(ref _secondaryColorR, value);
		}

		[Ordinal(6)] 
		[RED("secondaryColorG")] 
		public CUInt8 SecondaryColorG
		{
			get => GetProperty(ref _secondaryColorG);
			set => SetProperty(ref _secondaryColorG, value);
		}

		[Ordinal(7)] 
		[RED("secondaryColorB")] 
		public CUInt8 SecondaryColorB
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
		[RED("lightsColorHue")] 
		public CFloat LightsColorHue
		{
			get => GetProperty(ref _lightsColorHue);
			set => SetProperty(ref _lightsColorHue, value);
		}

		public GenericTemplatePersistentData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
