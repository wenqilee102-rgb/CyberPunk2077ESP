using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameWeakspotPhysicalDestructionComponent : CVariable
	{
		private CName _componentName;
		private CBool _useDefaultOwnerProperties;
		private gameWeakspotPhysicalDestructionProperties _destructionProperties;

		[Ordinal(0)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get => GetProperty(ref _componentName);
			set => SetProperty(ref _componentName, value);
		}

		[Ordinal(1)] 
		[RED("useDefaultOwnerProperties")] 
		public CBool UseDefaultOwnerProperties
		{
			get => GetProperty(ref _useDefaultOwnerProperties);
			set => SetProperty(ref _useDefaultOwnerProperties, value);
		}

		[Ordinal(2)] 
		[RED("destructionProperties")] 
		public gameWeakspotPhysicalDestructionProperties DestructionProperties
		{
			get => GetProperty(ref _destructionProperties);
			set => SetProperty(ref _destructionProperties, value);
		}

		public gameWeakspotPhysicalDestructionComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
