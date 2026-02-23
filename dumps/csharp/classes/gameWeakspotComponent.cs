using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameWeakspotComponent : entIComponent
	{
		private gameWeakspotPhysicalDestructionProperties _defaultPhysicalDestructionProperties;

		[Ordinal(3)] 
		[RED("defaultPhysicalDestructionProperties")] 
		public gameWeakspotPhysicalDestructionProperties DefaultPhysicalDestructionProperties
		{
			get => GetProperty(ref _defaultPhysicalDestructionProperties);
			set => SetProperty(ref _defaultPhysicalDestructionProperties, value);
		}

		public gameWeakspotComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
