using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChargedItemsPrereqState : gamePrereqState
	{
		private CEnum<EChargesAmount> _chargesState;
		private CEnum<EChargesItem> _typeOfItem;
		private CHandle<BaseStatPoolPrereqListener> _listener;
		private ScriptGameInstance _owner;

		[Ordinal(0)] 
		[RED("chargesState")] 
		public CEnum<EChargesAmount> ChargesState
		{
			get => GetProperty(ref _chargesState);
			set => SetProperty(ref _chargesState, value);
		}

		[Ordinal(1)] 
		[RED("typeOfItem")] 
		public CEnum<EChargesItem> TypeOfItem
		{
			get => GetProperty(ref _typeOfItem);
			set => SetProperty(ref _typeOfItem, value);
		}

		[Ordinal(2)] 
		[RED("listener")] 
		public CHandle<BaseStatPoolPrereqListener> Listener
		{
			get => GetProperty(ref _listener);
			set => SetProperty(ref _listener, value);
		}

		[Ordinal(3)] 
		[RED("owner")] 
		public ScriptGameInstance Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		public ChargedItemsPrereqState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
