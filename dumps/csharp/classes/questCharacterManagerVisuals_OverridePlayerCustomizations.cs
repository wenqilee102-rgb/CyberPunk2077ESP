using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerVisuals_OverridePlayerCustomizations : questICharacterManagerVisuals_NodeSubType
	{
		private CArray<gameuiForcePlayerCustomizationData> _customizationData;

		[Ordinal(0)] 
		[RED("customizationData")] 
		public CArray<gameuiForcePlayerCustomizationData> CustomizationData
		{
			get => GetProperty(ref _customizationData);
			set => SetProperty(ref _customizationData, value);
		}

		public questCharacterManagerVisuals_OverridePlayerCustomizations(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
