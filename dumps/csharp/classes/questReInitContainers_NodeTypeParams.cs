using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questReInitContainers_NodeTypeParams : CVariable
	{
		private NodeRef _containerNodeRef;
		private CArray<TweakDBID> _lootTables;
		private CBool _useAreaLoot;

		[Ordinal(0)] 
		[RED("containerNodeRef")] 
		public NodeRef ContainerNodeRef
		{
			get => GetProperty(ref _containerNodeRef);
			set => SetProperty(ref _containerNodeRef, value);
		}

		[Ordinal(1)] 
		[RED("lootTables")] 
		public CArray<TweakDBID> LootTables
		{
			get => GetProperty(ref _lootTables);
			set => SetProperty(ref _lootTables, value);
		}

		[Ordinal(2)] 
		[RED("useAreaLoot")] 
		public CBool UseAreaLoot
		{
			get => GetProperty(ref _useAreaLoot);
			set => SetProperty(ref _useAreaLoot, value);
		}

		public questReInitContainers_NodeTypeParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
