using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSEquipSlot : CVariable
	{
		private gameItemID _itemID;
		private TweakDBID _slotID;
		private CHandle<gameIPrereq> _unlockPrereq;
		private CBool _visibleWhenLocked;

		[Ordinal(0)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(1)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		[Ordinal(2)] 
		[RED("unlockPrereq")] 
		public CHandle<gameIPrereq> UnlockPrereq
		{
			get => GetProperty(ref _unlockPrereq);
			set => SetProperty(ref _unlockPrereq, value);
		}

		[Ordinal(3)] 
		[RED("visibleWhenLocked")] 
		public CBool VisibleWhenLocked
		{
			get => GetProperty(ref _visibleWhenLocked);
			set => SetProperty(ref _visibleWhenLocked, value);
		}

		public gameSEquipSlot(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
