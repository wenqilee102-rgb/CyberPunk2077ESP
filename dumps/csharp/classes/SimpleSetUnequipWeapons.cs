using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SimpleSetUnequipWeapons : AIbehaviortaskScript
	{
		private wCHandle<ScriptedPuppet> _puppet;
		private ScriptGameInstance _game;
		private CHandle<gameTransactionSystem> _transactionSystem;
		private CArray<wCHandle<gamedataNPCEquipmentItem_Record>> _primaryItems;
		private CArray<wCHandle<gamedataNPCEquipmentItem_Record>> _secondaryItems;
		private CBool _secondaryEquipmentDuplicatesPrimary;
		private CBool _initialized;

		[Ordinal(0)] 
		[RED("puppet")] 
		public wCHandle<ScriptedPuppet> Puppet
		{
			get => GetProperty(ref _puppet);
			set => SetProperty(ref _puppet, value);
		}

		[Ordinal(1)] 
		[RED("game")] 
		public ScriptGameInstance Game
		{
			get => GetProperty(ref _game);
			set => SetProperty(ref _game, value);
		}

		[Ordinal(2)] 
		[RED("transactionSystem")] 
		public CHandle<gameTransactionSystem> TransactionSystem
		{
			get => GetProperty(ref _transactionSystem);
			set => SetProperty(ref _transactionSystem, value);
		}

		[Ordinal(3)] 
		[RED("primaryItems")] 
		public CArray<wCHandle<gamedataNPCEquipmentItem_Record>> PrimaryItems
		{
			get => GetProperty(ref _primaryItems);
			set => SetProperty(ref _primaryItems, value);
		}

		[Ordinal(4)] 
		[RED("secondaryItems")] 
		public CArray<wCHandle<gamedataNPCEquipmentItem_Record>> SecondaryItems
		{
			get => GetProperty(ref _secondaryItems);
			set => SetProperty(ref _secondaryItems, value);
		}

		[Ordinal(5)] 
		[RED("secondaryEquipmentDuplicatesPrimary")] 
		public CBool SecondaryEquipmentDuplicatesPrimary
		{
			get => GetProperty(ref _secondaryEquipmentDuplicatesPrimary);
			set => SetProperty(ref _secondaryEquipmentDuplicatesPrimary, value);
		}

		[Ordinal(6)] 
		[RED("initialized")] 
		public CBool Initialized
		{
			get => GetProperty(ref _initialized);
			set => SetProperty(ref _initialized, value);
		}

		public SimpleSetUnequipWeapons(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
