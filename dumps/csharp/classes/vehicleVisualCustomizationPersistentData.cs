using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleVisualCustomizationPersistentData : CVariable
	{
		private TweakDBID _iD;
		private vehicleVisualModdingDefinition _visualCustomizationData;

		[Ordinal(0)] 
		[RED("ID")] 
		public TweakDBID ID
		{
			get => GetProperty(ref _iD);
			set => SetProperty(ref _iD, value);
		}

		[Ordinal(1)] 
		[RED("visualCustomizationData")] 
		public vehicleVisualModdingDefinition VisualCustomizationData
		{
			get => GetProperty(ref _visualCustomizationData);
			set => SetProperty(ref _visualCustomizationData, value);
		}

		public vehicleVisualCustomizationPersistentData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
