using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleLightQuestChangeColorEvent : redEvent
	{
		private CColor _color;
		private CEnum<vehicleELightType> _lightType;
		private CBool _forceOverrideEmissiveColor;

		[Ordinal(0)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetProperty(ref _color);
			set => SetProperty(ref _color, value);
		}

		[Ordinal(1)] 
		[RED("lightType")] 
		public CEnum<vehicleELightType> LightType
		{
			get => GetProperty(ref _lightType);
			set => SetProperty(ref _lightType, value);
		}

		[Ordinal(2)] 
		[RED("forceOverrideEmissiveColor")] 
		public CBool ForceOverrideEmissiveColor
		{
			get => GetProperty(ref _forceOverrideEmissiveColor);
			set => SetProperty(ref _forceOverrideEmissiveColor, value);
		}

		public VehicleLightQuestChangeColorEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
