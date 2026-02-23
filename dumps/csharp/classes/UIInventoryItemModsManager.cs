using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIInventoryItemModsManager : IScriptable
	{
		private CArray<TweakDBID> _emptySlots;
		private CArray<TweakDBID> _usedSlots;
		private CArray<CHandle<UIInventoryItemMod>> _mods;
		private CArray<CHandle<UIInventoryItemModAttachment>> _attachments;
		private CHandle<UIInventoryItemModAttachment> _dedicatedMod;
		private CHandle<gameTransactionSystem> _transactionSystem;

		[Ordinal(0)] 
		[RED("emptySlots")] 
		public CArray<TweakDBID> EmptySlots
		{
			get => GetProperty(ref _emptySlots);
			set => SetProperty(ref _emptySlots, value);
		}

		[Ordinal(1)] 
		[RED("usedSlots")] 
		public CArray<TweakDBID> UsedSlots
		{
			get => GetProperty(ref _usedSlots);
			set => SetProperty(ref _usedSlots, value);
		}

		[Ordinal(2)] 
		[RED("mods")] 
		public CArray<CHandle<UIInventoryItemMod>> Mods
		{
			get => GetProperty(ref _mods);
			set => SetProperty(ref _mods, value);
		}

		[Ordinal(3)] 
		[RED("attachments")] 
		public CArray<CHandle<UIInventoryItemModAttachment>> Attachments
		{
			get => GetProperty(ref _attachments);
			set => SetProperty(ref _attachments, value);
		}

		[Ordinal(4)] 
		[RED("dedicatedMod")] 
		public CHandle<UIInventoryItemModAttachment> DedicatedMod
		{
			get => GetProperty(ref _dedicatedMod);
			set => SetProperty(ref _dedicatedMod, value);
		}

		[Ordinal(5)] 
		[RED("transactionSystem")] 
		public CHandle<gameTransactionSystem> TransactionSystem
		{
			get => GetProperty(ref _transactionSystem);
			set => SetProperty(ref _transactionSystem, value);
		}

		public UIInventoryItemModsManager(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
