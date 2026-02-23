using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleVehicleAppearanceToDecalsName : CVariable
	{
		private CName _appearanceName;
		private CArray<CName> _decalsName;

		[Ordinal(0)] 
		[RED("appearanceName")] 
		public CName AppearanceName
		{
			get => GetProperty(ref _appearanceName);
			set => SetProperty(ref _appearanceName, value);
		}

		[Ordinal(1)] 
		[RED("decalsName")] 
		public CArray<CName> DecalsName
		{
			get => GetProperty(ref _decalsName);
			set => SetProperty(ref _decalsName, value);
		}

		public vehicleVehicleAppearanceToDecalsName(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
