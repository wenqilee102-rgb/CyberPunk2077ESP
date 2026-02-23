using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IsDead : AIbehaviorconditionScript
	{
		private CHandle<gameStatPoolsSystem> _statPoolsSystem;
		private entEntityID _entityID;

		[Ordinal(0)] 
		[RED("statPoolsSystem")] 
		public CHandle<gameStatPoolsSystem> StatPoolsSystem
		{
			get => GetProperty(ref _statPoolsSystem);
			set => SetProperty(ref _statPoolsSystem, value);
		}

		[Ordinal(1)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get => GetProperty(ref _entityID);
			set => SetProperty(ref _entityID, value);
		}

		public IsDead(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
