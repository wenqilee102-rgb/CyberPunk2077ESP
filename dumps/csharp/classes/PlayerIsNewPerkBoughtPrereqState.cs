using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerIsNewPerkBoughtPrereqState : gamePrereqState
	{
		private CHandle<redCallbackObject> _listenerPerksVariant;
		private wCHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("listenerPerksVariant")] 
		public CHandle<redCallbackObject> ListenerPerksVariant
		{
			get => GetProperty(ref _listenerPerksVariant);
			set => SetProperty(ref _listenerPerksVariant, value);
		}

		[Ordinal(1)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		public PlayerIsNewPerkBoughtPrereqState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
