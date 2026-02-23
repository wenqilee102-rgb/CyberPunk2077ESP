using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameWeakspotDestroyPhysicalComponentsEvent : redEvent
	{
		private CArray<gameWeakspotPhysicalDestructionComponent> _components;

		[Ordinal(0)] 
		[RED("components")] 
		public CArray<gameWeakspotPhysicalDestructionComponent> Components
		{
			get => GetProperty(ref _components);
			set => SetProperty(ref _components, value);
		}

		public gameWeakspotDestroyPhysicalComponentsEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
